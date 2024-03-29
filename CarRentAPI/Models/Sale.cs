namespace CarRentAPI.Models
{
    public class Sale
    {
        public int Id { get; set; }
        public int CarID { get; set; }
        public string Description { get; set; }
        public int Percent { get; set; }
    }
}