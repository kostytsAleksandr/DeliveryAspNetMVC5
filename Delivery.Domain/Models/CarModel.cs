using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delivery.Domain.Models
{
    public class CarModel
    {
        public int Id { get; set; }
        public int CarryingCapacity { get; set; }

        public ICollection<DriverModel> DriverModels { get; set; }
    }
}
