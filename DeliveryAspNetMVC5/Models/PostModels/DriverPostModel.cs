using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliveryAspNetMVC5.Models
{
    public class DriverPostModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }

        public int CarId { get; set; }
        public CarPostModel CarPostModel { get; set; }

        public ICollection<ParcelPostModel> ParcelInCarPostModels { get; set; }
        public ICollection<CarDeliveryStatusPostModel> StatusPostModels { get; set; }
    }
}
