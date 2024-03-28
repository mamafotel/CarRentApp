using System.ComponentModel.DataAnnotations;

namespace CarRentApp.Models
{
    public class Rental
    {
        public int Id { get; set; }
        public string Userid { get; set; }
        public string Carid { get; set; }
        public DateTime Fromdate { get; set; }
        public DateTime Todate { get; set; }
        public int Created { get; set; }    //ideiglenesen int, nem tudom mibenlenne a legjobb eltel idő tárolni       
    }
}
