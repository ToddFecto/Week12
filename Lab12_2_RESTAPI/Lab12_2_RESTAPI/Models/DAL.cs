using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;
using Dapper;
using MySql.Data.MySqlClient;

namespace Lab12_2_RESTAPI.Models
{
    public class DAL
    {
        public static MySqlConnection DB;

        public static List<Movie> GetAllMovies()
        {
            return DB.GetAll<Movie>().ToList();
        }

        public static Movie GetMovie(int id)
        {
            return DB.Get<Movie>(id);
        }

        public static List<Movie> GetAllByCategory(string cat)
        {
            Object myparams = new { cat = cat };
            string sql = "select * from movie where category = @cat";
            List<Movie> movies = DB.Query<Movie>(sql, myparams).ToList();
            return movies;
        }

        public static bool DeleteMovie(int id)
        {
            var myparams = new { id = id };
            Movie temp = new Movie() { id = id };
            DB.Delete<Movie>(temp);
            return true;
        }

        public static Movie AddMovie(Movie movie)
        {
            DB.Insert<Movie>(movie);
            return movie;
        }

        public static Movie UpdateMovie(Movie movie)
        {
            DB.Update<Movie>(movie);
            return movie;
        }
    }
}
