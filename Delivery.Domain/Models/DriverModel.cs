using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delivery.Domain.Models
{
    public class DriverModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }

        public int CarId { get; set; }
        public CarModel CarModel { get; set; }

        public ICollection<ParcelModel> ParcelInCarModels { get; set; }
        public ICollection<CarDeliveryStatusModel> StatusModels { get; set; }
    }
}
