using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Assessment9_IceAndFire_ConsumingAPI.Models
{
    public class Character
    {
        [ExplicitKey]
        public string name { get; set; }
        public string gender { get; set; }
        public List<Actors> playedBy { get; set; }
    }

    public class Actors
    {
        public List<string> playedBy { get; set; }
    }
}
