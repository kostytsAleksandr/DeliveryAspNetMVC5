using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delivery.Data.Models
{
    public class Driver
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }

        public int CarId { get; set; }
        public Car Car { get; set; }

        public ICollection<Parcel> ParcelsInCar { get; set; }
        public ICollection<CarDeliveryStatus> Statuses { get; set; }
    }
}
