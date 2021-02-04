using Microsoft.AspNetCore.Mvc;
using StarWarsPlanetNames.Models;
using StarWarsPlanetNames.Services;
using System.Threading.Tasks;

namespace StarWarsPlanetNames.Controllers
{
    public class PeopleController : Controller
    {
        private readonly IPeopleObjClient _peopleObjClient;
        public PeopleController(IPeopleObjClient peopleObjClient)
            {
            _peopleObjClient = peopleObjClient;
        }
        public async Task<IActionResult> PeopleObj()
        {
            var response = await _peopleObjClient.GetPeopleInfo();
            var model = new PeopleModel();
            model.name = response.name;

            return View(model);
        }
    }
}
