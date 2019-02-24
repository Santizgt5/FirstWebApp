using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace EventosWeb.Models
{
    public class EventosWebContext : DbContext
    {
        public EventosWebContext (DbContextOptions<EventosWebContext> options)
            : base(options)
        {
        }

        public DbSet<EventosWeb.Models.Cotizacion> Cotizacion { get; set; }
    }
}
