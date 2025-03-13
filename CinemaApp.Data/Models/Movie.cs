using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace CinemaApp.Data.Models
{
	[Comment("Movies in the system")]	
	public class Movie
	{
		[Key]
		[Comment("Movie identifier")]
		public Guid Id { get; set; }

		[Required]
		[MaxLength(300)]
		[Comment("Movie title")]
		public string Title { get; set; } = null!;

		[Required]
		[MaxLength(30)]
		[Comment("Movie genre")]
		public string Genre { get; set; } = null!;

		[Required]
		[Comment("Movie release date")]
		public DateTime ReleaseDate { get; set; }

		[Required]
		[MaxLength(150)]
		[Comment("Movie director")]
		public string Director { get; set; } = null!;

		[Required]
		[Comment("Movie duration")]
		public int Duration { get; set; }

		[Required]
		[MaxLength(2000)]
		[Comment("Movie description")]
		public string Description { get; set; } = null!;

		[MaxLength(256)]
		[Comment("Movie image URL from the image store")]
		public string? ImageUrl { get; set; }

		[Comment("Shows if movie is deleted")]
		public bool IsDeleted { get; set; }

		//Navigation collections are not virtual, because we are not expected to use LazyLoading.
		// ICollection<T> is used as a type to benefit from higher abstraction
		//Both List<T> and HashSet<T> may be suitable as implementation type, choose best on the scale of the application.
		public ICollection<CinemaMovie> MovieCinemas { get; set; }
		       = new HashSet<CinemaMovie>();

		// ICollection<T> is used as a type to benefit from higher abstraction
		// HashSet<T> is chosen as implementation type, since many users can add the movie to the watchlist and we will benefit from it.
		public ICollection<ApplicationUserMovie> MovieApplicationUsers { get; set; }
		       = new HashSet<ApplicationUserMovie>();
		
		// ICollection<T> is used as a type to benefit from higher abstraction
		// HashSet<T> is chosen as implementation type, since many tickets may be sold for a movie.
		public ICollection<Ticket> Tickets { get; set; }
		       = new List<Ticket>();
	}
}