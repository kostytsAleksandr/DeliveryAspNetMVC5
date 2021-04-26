using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delivery.Data.Models
{
    public class Car
    {
        public int Id { get; set; }
        public int CarryingCapacity { get; set; }

        public ICollection<Driver> Drivers { get; set; }
    }
}
