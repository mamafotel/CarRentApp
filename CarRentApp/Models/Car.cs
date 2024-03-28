namespace CarRentApp.Models
{
    public class Car
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public double Dailyprice { get; set; }
        public ICollection<Sale> Sales { get; set; }
    }
}
