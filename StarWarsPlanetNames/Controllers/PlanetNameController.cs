using Microsoft.AspNetCore.Mvc;
using StarWarsApi.Models;
using StarWarsPlanetNames.Models;
using StarWarsPlanetNames.Services;
using System.Threading.Tasks;

namespace StarWarsPlanetNames.Controllers
{
    public class PlanetNameController : Controller
    {
        private readonly IPlanetObjClient _planetNameClient;
        private int _Page;
         
        public PlanetNameController(IPlanetObjClient planetNameClient)
        {
            _planetNameClient = planetNameClient;
            _Page++;
           
        }

        
        //public async Task<IActionResult> PageIncrementer()
        //{
        //   _Page++;
            
            
        //    var response = await _planetNameClient.GetPlanetInfo(_Page);
        //    var model = new PeoplePlanetCombinedModel();
        //    model.PlanetInfo.results = response.PlanetInfo.results;


            
        //    return View("PlanetObj", model);
            
        //}

       
        public async Task<IActionResult> PlanetObj()
        {
            if(_Page == 0)
            {
                _Page = 1;
            }


            var response = await _planetNameClient.GetPlanetInfo(_Page);
            var model = new PeoplePlanetCombinedModel();
            model.PlanetModel = response.PlanetModel;
 

            return View(model.PlanetModel);
        }

    }
}
