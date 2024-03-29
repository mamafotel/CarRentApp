namespace CarRentAPI.Models
{
    public class Rental
    {
        public int Id { get; set; }
        public string UserID { get; set; }
        public string CarID { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public int Created { get; set; }
    }
}
