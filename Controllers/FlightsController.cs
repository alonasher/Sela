using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication3.Dal;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    [ApiController]
    [Route("api/flights")]
    public class FlightsController : Controller
    {
        private FlightsContext _context;
        public FlightsController(FlightsContext context)
        {
            _context = context;
        }
        //GET api/flights
        [HttpGet]
        public IEnumerable<Flight> Get()
        {
            return _context.Flights.ToList();
        }

        // POST api/flights
        [HttpPost]
        public IActionResult Post([FromBody] Flight flight)
        {
            _context.Flights.Add(flight);
            _context.SaveChanges();
            return CreatedAtAction(nameof(Get), flight.Id);
        }

    }
}
