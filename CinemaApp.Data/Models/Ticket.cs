﻿using CinemaApp.Common.Constants;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CinemaApp.Data.Models
{
	[Comment("Tickets in the system")]
	public class Ticket
	{
		[Key]
		[Comment("Ticket identifier")]
		public Guid Id { get; set; }

		[Required]
		[Column(TypeName = EntityConstants.MoneyType)]
		[Comment("Ticket Price")]
		public decimal Price { get; set; }

		//Normalize the DB structure by introducing a relation to Mapping Entity CinemaMovie
		[Required]
		[Comment("Foreign key to the CinemaMovie projection entity")]
		public Guid CinemaMovieId { get; set; }

		public CinemaMovie CinemaMovie { get; set; } = null!;

		[Required]
		[Comment("Foreign key to the user bought the ticket")]
		public Guid ApplicationUserId { get; set; }

		public ApplicationUser? ApplicationUser { get; set; }
	}
}