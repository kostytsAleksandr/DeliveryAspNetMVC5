using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delivery.Data.Models
{
    public class Car
    {
        public int Id { get; set; }
        public int CarryingCapacity { get; set; }
        public bool IsFree { get; set; }

        public ICollection<CarDeliveryStatus> Statuses { get; set; }
    }
}
