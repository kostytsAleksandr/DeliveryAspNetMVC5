using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delivery.Data.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string Address { get; set; }

        public int CityId { get; set; }
        public City City { get; set; }

        public ICollection<Parcel> ParcelsFrom { get; set; }
        public ICollection<Parcel> ParcelsTo { get; set; }

        public ICollection<CarDeliveryStatus> Statuses { get; set; }
    }
}
