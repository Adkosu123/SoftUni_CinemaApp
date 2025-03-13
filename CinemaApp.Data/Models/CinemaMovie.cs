using Microsoft.EntityFrameworkCore;

using System.ComponentModel.DataAnnotations;

namespace CinemaApp.Data.Models
{
	[Comment("Movies in a cinema with available tickets and schedule")]
	public class CinemaMovie
	{
		public Guid Id { get; set; }

		[Comment("Foreign key to the movie")]
		public Guid MovieId { get; set; }

		public Movie Movie { get; set; } = null!;

		[Comment("Foreign key to the cinema")]
		public Guid CinemaId { get; set; }
		public Cinema Cinema { get; set; } = null!;

		[Comment("Ammount of available tickets for this movie in this cinema")]
		public int AvailableTickets { get; set; }

		[Comment("Shows if movie in a cinema is deleted")]
		public bool IsDeleted { get; set; }

		[Comment("Shows the movie schedule in the cinema")]
		public string Showtimes { get; set; } = "00000";

		// ICollection<T> is used as a type to benefit from higher abstraction
		//List<T> is chosen as implementation type, as we do not expect high ammount of tickets for a single projection of a movie.
		public ICollection<Ticket> Tickets { get; set; }  
		         = new List<Ticket>();
	}
}