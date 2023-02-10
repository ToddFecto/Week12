using Lab12_2_RESTAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab12_2_RESTAPI.Controllers
{
    [Route("api/movie")]
    [ApiController]
    public class MovieController : ControllerBase
    {
        // CRUD Functions

        //"R" Read all or one (byid then all in a category) - next three functions
        // https://localhost:44319/api/movie
        [HttpGet("getAll")] // or [HttpGet()]
        public List<Movie> getAll()
        {
            return DAL.GetAllMovies();
        }

        // https://localhost:44388/api/movie?id=1
        [HttpGet("getSingleMovie")]
        public Movie getSingleMovie(int id)
        {
            return DAL.GetMovie(id);
        }

        // https://localhost:44388/api/movie/getByCategory?cat=Action
        [HttpGet("getByCategory")]
        public List<Movie> getByCategory(string cat)
        {
            List<Movie> result = DAL.GetAllByCategory(cat);
            return result;
        }

        //"D" Delete Function
        //https://localhost:44388/api/movie/deleteMovie?id=8
        [HttpDelete("deleteMovie")]
        public bool deleteMovie(int id)
        {
            return DAL.DeleteMovie(id);
        }

        //"C" Create or Add Function
        //https://localhost:44388/api/movie/addMovie [data in the body in a Body/Raw/JSON form]
        [HttpPost("addMovie")]
        public Movie addMovie(Movie movie)
        {
            return DAL.AddMovie(movie);
        }

        //"U" Update Function - need to grab id (primary key)
        //https://localhost:44388/api/movie/UpdateMovie [data in the body in a Body/Raw/JSON form]
        [HttpPut("updateMovie")]
        public Movie updateMovie(Movie movie)
        {
            return DAL.UpdateMovie(movie);
        }
    }
}
