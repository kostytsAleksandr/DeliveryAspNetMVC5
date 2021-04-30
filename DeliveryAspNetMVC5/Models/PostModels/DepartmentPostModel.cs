using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliveryAspNetMVC5.Models
{
    public class DepartmentPostModel
    {
        public int Id { get; set; }
        public string Address { get; set; }

        public int CityId { get; set; }
        public CityPostModel CityPostModel { get; set; }

        public ICollection<ParcelPostModel> ParcelsFromPostModel { get; set; }
        public ICollection<ParcelPostModel> ParcelsToPostModel { get; set; }

        public ICollection<CarDeliveryStatusPostModel> StatusPostModels { get; set; }
    }
}
