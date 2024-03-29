using Microsoft.AspNetCore.OpenApi;
using Microsoft.AspNetCore.Http.HttpResults;
namespace CarRentAPI.Models
{
    public class Car
    {
        public int Id { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public int CategoryId { get; set; }
        public List<Sale> sales { get; set; }
        public List<Rental> rentals { get; set; }
    }
}