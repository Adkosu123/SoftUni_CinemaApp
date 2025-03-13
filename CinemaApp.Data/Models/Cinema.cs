using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace CinemaApp.Data.Models
{
	[Comment("Cinemas in the system")]
	public class Cinema
    {
		[Key]
		[Comment("Cinema identifier")]
		public Guid Id { get; set; }

		[Required]
		[MaxLength(256)]
		[Comment("Cinema name")]
		public string Name { get; set; } = null!;

		[Required]
		[MaxLength(256)]
		[Comment("Cinema location")]
		public string Location { get; set; } = null!;

		[Comment("Shows if a cinema is deleted")]
		public bool isDeleted { get; set; }

		[Comment("List of cinema movies")]
		//Navigation collection is not virtual, because we are not expected to use LazyLoading.
		// ICollection<T> is used as a type to benefit from higher abstraction
		//List<T> is chosen as implementation type, since we do not ecxpect to have many movies in the cinema at the same time.
		public ICollection<CinemaMovie> CinemaMovies { get; set; } 
		        = new List<CinemaMovie>();

		[Comment("List of tickets")]
		// ICollection<T> is used as a type to benefit from higher abstraction
		//HashSet<T> is chosen as implementation type, since we expect to have many tickets at the cinema and will benefit to have better loop times.
		public ICollection<Ticket> Tickets { get; set; } 
		        = new HashSet<Ticket>();
	}
}
