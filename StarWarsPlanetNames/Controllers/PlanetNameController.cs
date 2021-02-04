using Microsoft.AspNetCore.Mvc;
using StarWarsPlanetNames.Models;
using StarWarsPlanetNames.Services;
using System.Threading.Tasks;

namespace StarWarsPlanetNames.Controllers
{
    public class PlanetNameController : Controller
    {
        private readonly IPlanetObjClient _planetNameClient;

        public int page {get; set;}
        public async Task<IActionResult> PageIncrementer()
        {
            page = page;
            if (page == 0)
            {
                page = 1;
                page++;
            }
            else if (page == 1)
            {
                page = 2;
                page++;

            }
            else if  (page == 2)
            {
                page = 3;
                page++;
            }
            
            
            var response = await _planetNameClient.GetPlanetInfo(page);
            var model = new PlanetModel();
            model.results = response.results;


            
            return View("PlanetObj", model);
            
        }
        public PlanetNameController(IPlanetObjClient planetNameClient)
        {
            _planetNameClient = planetNameClient;
            
        }
        public async Task<IActionResult> PlanetObj()
        {
            if(page == 0)
            {
                page = 1;
            }


            var response = await _planetNameClient.GetPlanetInfo(page);
            var model = new PlanetModel();
            model.results = response.results;
 

            return View(model);
        }

    }
}
