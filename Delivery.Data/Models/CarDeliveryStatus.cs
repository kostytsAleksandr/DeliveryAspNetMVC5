using Delivery.Data.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delivery.Data.Models
{
    public class CarDeliveryStatus
    {
        public int Id { get; set; }
        public CarDeliveryState State { get; set; }

        public Department Department { get; set; }
        public int? DepartmentId { get; set; }

        public Driver Driver { get; set; }
        public int DriverId { get; set; }

        public PostManager PostManager { get; set; }
        public int PostManagerId { get; set; }
    }
}
