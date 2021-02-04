using StarWarsPlanetNames.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StarWarsPlanetNames.Services
{
    public interface IPlanetObjClient
    {
        Task<PlanetModel> GetPlanetInfo(int page);
    }
}
