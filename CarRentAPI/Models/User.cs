namespace CarRentAPI.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public IEnumerable<Rental> Users { get; set; }
    }
}
