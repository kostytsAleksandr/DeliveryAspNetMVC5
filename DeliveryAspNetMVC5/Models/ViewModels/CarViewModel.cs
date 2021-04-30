using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliveryAspNetMVC5.Models
{
    public class CarViewModel
    {
        public int Id { get; set; }
        public int CarryingCapacity { get; set; }

        public ICollection<DriverViewModel> DriverViewModels { get; set; }
    }
}
