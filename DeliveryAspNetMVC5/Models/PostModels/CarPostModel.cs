using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliveryAspNetMVC5.Models
{
    public class CarPostModel
    {
        public int Id { get; set; }
        public int CarryingCapacity { get; set; }

        public ICollection<DriverPostModel> DriverPostModels { get; set; }
    }
}
