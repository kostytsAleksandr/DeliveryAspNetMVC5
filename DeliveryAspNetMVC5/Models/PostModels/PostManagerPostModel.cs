using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliveryAspNetMVC5.Models
{
    public class PostManagerPostModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }

        public ICollection<ParcelPostModel> ParcelPostModels { get; set; }
        public ICollection<CarDeliveryStatusPostModel> CarDeliveryStatusPostModels { get; set; }
    }
}
