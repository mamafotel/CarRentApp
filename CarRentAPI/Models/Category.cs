using CarRentAPI.Controllers;
using Humanizer.Localisation.TimeToClockNotation;

namespace CarRentAPI.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Car> cars { get; set; }


        //Nem fog kelleni mikor már adatbázis is lesz
        public Category(int _id, string _name, List<Car> _cars)
        {
            Id = _id;
            Name = _name;
            cars = new List<Car>();
            foreach (var _car in _cars)
            {
                if (_car.CategoryId == Id)
                {
                    cars.Add(_car);
                }
            }
        }
    }

}
