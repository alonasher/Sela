using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication3.Models;

namespace WebApplication3.Dal
{
    public class FlightsContext:DbContext
    {
        public FlightsContext(DbContextOptions<FlightsContext> options): base(options)
        {
        }

        public DbSet<Flight> Flights { get; set; }
    }
}
