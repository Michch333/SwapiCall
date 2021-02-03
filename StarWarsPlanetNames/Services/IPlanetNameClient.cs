using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StarWarsPlanetNames.Services
{
    public interface IPlanetNameClient
    {
        Task<PlanetNameResponse> GetPlanetName();
    }
}
