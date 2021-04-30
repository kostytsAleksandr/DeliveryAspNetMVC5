using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliveryAspNetMVC5.Models
{
    public class DriverViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }

        public int CarId { get; set; }
        public CarViewModel CarViewModel { get; set; }

        public ICollection<ParcelViewModel> ParcelInCarViewModels { get; set; }
        public ICollection<CarDeliveryStatusViewModel> StatusViewModels { get; set; }
    }
}
