using Microsoft.AspNetCore.Mvc;

namespace modul8_1302194027.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MoviesController : ControllerBase
    {
        private static readonly string[] Titles = new[]
        {
        "The Shawshank Redemption", "The Godfather", "The Dark Knight"
        
    };

        private readonly ILogger<MoviesController> _logger;

        public MoviesController(ILogger<MoviesController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetMovies")]
        public Movies Get()
        {
            return new Movies
            {
                Title = new []
                {
                    "The Shawshank Redemption", 
                },

                Director = new[]
                {
                    "Frank Darabont"
                },

                Stars = new List<string>
                {
                    "Tim Robbins",
                    "Morgan Freeman",
                    "Bob Gunton",
                    "William Sadler"
                },

                Description = new[]
                {
                    "Two imprisoned men bond over a number of years, finding solace and eventual redemption through acts of common decency."
                }
            };
        }
    }
}