using Microsoft.AspNetCore.Mvc;
using StarWarsPlanetNames.Models;
using StarWarsPlanetNames.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StarWarsPlanetNames.Controllers
{
    public class PlanetNameController : Controller
    {
        private readonly IPlanetNameClient _planetNameClient;
        public PlanetNameController(IPlanetNameClient planetNameClient)
        {
            _planetNameClient = planetNameClient;
        }
        public async Task<IActionResult> PlanetName()
        {
            var response = await _planetNameClient.GetPlanetName();
            var model = new PlanetModel();
            model.results = response.results;

            return View(model);
        }
    }
}
