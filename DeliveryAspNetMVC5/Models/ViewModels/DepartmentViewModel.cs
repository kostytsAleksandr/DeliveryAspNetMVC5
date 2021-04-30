using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliveryAspNetMVC5.Models
{
    public class DepartmentViewModel
    {
        public int Id { get; set; }
        public string Address { get; set; }

        public int CityId { get; set; }
        public CityViewModel CityViewModel { get; set; }

        public ICollection<ParcelViewModel> ParcelsFromViewModel { get; set; }
        public ICollection<ParcelViewModel> ParcelsToViewModel { get; set; }

        public ICollection<CarDeliveryStatusViewModel> StatusViewModels { get; set; }
    }
}
