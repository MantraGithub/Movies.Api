using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Movie.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MoviesController : ControllerBase
    {
        public static IEnumerable<MovieEntity> Movies { get; set; }

        public MoviesController()
        {
            Movies = new List<MovieEntity>
            {
                new MovieEntity { Id = 1, Title = "Toy Story 1", Director = "John Lasseter" },
                new MovieEntity { Id = 2, Title = "Toy Story 4", Director = "Josh Cooley" },
                new MovieEntity { Id = 3, Title = "Arrival", Director = "Denis Villeneuve" },
                new MovieEntity { Id = 4, Title = "Interstellar", Director = "Christopher Nolan" },
                new MovieEntity { Id = 5, Title = "The Martian", Director = "Ridley Scott" },

                new MovieEntity { Id = 6, Title = "Avatar", Director = "James Cameron" },
                new MovieEntity { Id = 7, Title = "Prometheus", Director = "Ridley Scott" },
                new MovieEntity { Id = 8, Title = "Sunshine", Director = "Danny Boyle" },

                new MovieEntity { Id = 9, Title = "Serenity", Director = "Joss Whedon" },
                new MovieEntity { Id = 10, Title = "WALL-E", Director = "Andrew Stanton" },
            };
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(Movies);
        }
    }

    public class MovieEntity
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Director { get; set; }
    }
}
