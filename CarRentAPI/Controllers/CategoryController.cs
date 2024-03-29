using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using CarRentAPI.Models;
using Newtonsoft.Json;

namespace CarRentAPI.Controllers
{
    [Route("api/[controller]-[Action]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        List<Category> categories;
        public readonly CarController _carController;

        public CategoryController(CarController carController)
        {
            //gyász és szenvedés ami nem is fog kelleni...
            _carController = carController;
            categories = new List<Category>();
            categories.Add(new Category(1, "Kozep Kategoria", _carController.cars));
            categories.Add(new Category(2, "Felso Kategoria", _carController.cars));
            categories.Add(new Category(3, "Luxus Kategoria", _carController.cars));
        }


        //Kategória alapú listázás
        [HttpGet("{categoryname}")]
        public IActionResult filteredList(string categoryname)
        {
            var category = categories.Find(c => c.Name == categoryname);
            var json = JsonConvert.SerializeObject(category.cars);
            return Ok(json);
        }
    }
}
