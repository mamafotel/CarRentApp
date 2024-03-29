﻿using Microsoft.AspNetCore.Mvc;
using CarRentAPI.Models;
using Newtonsoft.Json;
using System.Net;
using System.Net.Http;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CarRentAPI.Controllers
{
    [Route("api/[controller]-[action]")]
    [ApiController]
    public class CarController : ControllerBase
    {
        public List<Car> cars;
        public CarController()
        {
            cars = new List<Car>{
                new Car { Id = 1, Brand="Ford", Model = "Focus", CategoryId = 1 },
                new Car { Id = 2, Brand="Ford", Model = "Mustang", CategoryId = 2 },
                new Car { Id = 3, Brand="Volkswagen", Model = "Golf", CategoryId = 1 },
                new Car { Id = 4, Brand="Dodge", Model = "Charger", CategoryId = 2 },
                new Car { Id = 5, Brand="Ferrari", Model = "GTS", CategoryId = 3 },
                new Car { Id = 6, Brand="Lamborghini", Model = "Aventador", CategoryId = 3 },
            };
        }
        
        [HttpGet]
        public IActionResult listCars()
        {
            var json = JsonConvert.SerializeObject(cars); // Autók listájának JSON formátumba szerializálása
            Console.WriteLine(json); // Logoljuk a JSON adatot
            return Ok(json);
        }

        
        [HttpGet("{categoryid}")]
        public ActionResult<List<Car>> filteredList(int categoryid)
        {
            List<Car> filtered_cars = new List<Car>();
            foreach (var car in cars)
            {
                if(car.CategoryId == categoryid)
                {
                    filtered_cars.Add(car);
                }
            }
            if (filtered_cars.Count > 0) return filtered_cars;
            else throw new Exception("No car found within the category");
        }
    }
}