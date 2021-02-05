using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StarWarsPlanetNames.Models
{
    public class PeoplePlanetCombinedModel
    {
        public List<PeopleModel> PeopleInfo { get; set; }
        public PlanetModel PlanetModel { get; set; }
    }
}
