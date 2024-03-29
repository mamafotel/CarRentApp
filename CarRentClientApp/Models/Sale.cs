using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentClientApp.Models
{
    internal class Sale
    {
        public int Id { get; set; }
        public int CarID { get; set; }
        public string Description { get; set; }
        public int Percent { get; set; }
    }
}
