using System.ComponentModel.DataAnnotations;

using CinemaApp.Common.Constants;
using Newtonsoft.Json;

namespace CinemaApp.Data.Dtos
{
    public class CinemaMovieDto
	{
		// Movie title from the deserialized JSON
		[Required]
		[MinLength(EntityConstants.Movie.TitleMinLength)]
		[MaxLength(EntityConstants.Movie.TitleMaxLength)]
		public string Movie { get; set; } = null!;

		[Required]
		[MinLength(EntityConstants.Cinema.NameMinLength)]
		[MaxLength(EntityConstants.Cinema.NameMaxLength)]
		public string Cinema { get; set; } = null!;

		[Required]
		[Range(EntityConstants.CinemaMovie.AvailableTicketsMinValue,
			EntityConstants.CinemaMovie.AvailableTicketsMaxValue)]
		public int AvailableTickets { get; set; }

		[Required]
		public bool IsDeleted { get; set; }

		public string? Showtimes { get; set; }

	}
}
