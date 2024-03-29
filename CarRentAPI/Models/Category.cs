using Humanizer.Localisation.TimeToClockNotation;

namespace CarRentAPI.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Car> cars { get; set; }
    }
}
