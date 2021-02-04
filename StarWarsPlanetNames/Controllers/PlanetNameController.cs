using Microsoft.AspNetCore.Mvc;
using StarWarsPlanetNames.Models;
using StarWarsPlanetNames.Services;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace StarWarsPlanetNames.Controllers
{
    public class PlanetNameController : Controller
    {   

        private readonly IPlanetObjClient _planetNameClient;
        
        public PlanetNameController(IPlanetObjClient planetNameClient)
        {
            _planetNameClient = planetNameClient;
        }
        public async Task<IActionResult> PlanetObj()
        {
            var response = await _planetNameClient.GetPlanetInfo();
            var model = new PlanetModel();
            model.results = response.results;
 

            return View(model);
        }

    }
}
