using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MySql.Data;

namespace Lab12_2_RESTAPI.Models
{
    [Table("movie")]
    public class Movie
    {
        [Key]
        public int id { get; set; }
        public string title { get; set; }
        public string actor { get; set; }
        public string category { get; set; }
        public string director { get; set; }
    }
}
