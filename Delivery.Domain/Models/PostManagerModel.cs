using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delivery.Domain.Models
{
    public class PostManagerModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }

        public ICollection<ParcelModel> ParcelModels { get; set; }
        public ICollection<CarDeliveryStatusModel> CarDeliveryStatusModels { get; set; }
    }
}
