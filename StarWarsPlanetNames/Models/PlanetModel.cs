using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StarWarsPlanetNames.Models
{
    public class PlanetModel : StarWarsBase
    { 
        public string rotation_period { get; set; }
        public string diameter { get; set; }
        public string terrain { get; set; }
        public string orbital_period { get; set; }
        public IEnumerable<string> residents { get; set; }
        public string Name { get; set; }
        public string surface_water { get; set; }
        public string gravity { get; set; }
        public IEnumerable<string> films { get; set; }
        public string population { get; set; }
        public string climate { get; set; }

    }
}
