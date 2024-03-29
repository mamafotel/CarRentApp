using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentClientApp.Models
{
    internal class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Car> cars { get; set; }
    }
}
