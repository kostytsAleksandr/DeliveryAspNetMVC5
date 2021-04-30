using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliveryAspNetMVC5.Models
{
    public class PostManagerViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }

        public ICollection<ParcelViewModel> ParcelViewModels { get; set; }
        public ICollection<CarDeliveryStatusViewModel> CarDeliveryStatusViewModels { get; set; }
    }
}
