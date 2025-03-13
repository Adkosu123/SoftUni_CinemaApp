using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaApp.Data.Models
{
    public class ApplicationUser : IdentityUser<Guid>
    {
		public ApplicationUser()
		{
			Id = Guid.NewGuid();
		}

		// ICollection<T> is used as a type to benefit from higher abstraction
		// HashSet<T> is chosen as implementation type, since  users can add many movies to the watchlist and we will benefit from it.
		public ICollection<ApplicationUserMovie> Watchlist { get; set; } 
		             = new HashSet<ApplicationUserMovie>();

		public ICollection<Ticket> Tickets { get; set; }
		         = new HashSet<Ticket>();
	}
}
