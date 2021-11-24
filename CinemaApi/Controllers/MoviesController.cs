using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using CinemaApi.Models;
using CinemaApi.Data;

namespace CinemaApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : ControllerBase
    {
        private CinemaDbContext _dbContext;
        public MoviesController(CinemaDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        //private List<Movie> movies = new List<Movie>()
        //{
        //    new Movie(){Id = 0, Name ="The harder they Fall", Language="English"},
        //    new Movie(){Id =2, Name = "Red Notice", Language="Portuguese"}
        //};

        [HttpGet]
        public IEnumerable<Movie> Get()
        {
            return _dbContext.Movies;
        }


        [HttpGet]
        public Movie Get(int Id)
        {
            var movie = _dbContext.Movies.FirstOrDefault(m => m.Id == Id);

            return movie;
        }

        [HttpPost]
        public void AddMovie(Movie movie)
        {
           // movies.Add(movie);
        }

        [HttpPut("{Id}")]
        public void Edit(int Id, [FromBody] Movie movie)
        {
            //movies[Id] = movie;
        }

        [HttpDelete("{Id}")]
        public void DeleteMovie(int Id)
        {
            //movies.RemoveAt(Id);
        }
    }
}
