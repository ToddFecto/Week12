using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Assessment9_IceAndFire_After.Models
{
    public class Character
    {
        public string Name { get; set; }
        public string Gender { get; set; }
        public List<string> PlayedBy { get; set; }
    }
}
