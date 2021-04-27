using Delivery.Domain.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delivery.Domain.Models
{
    public class CarDeliveryStatusModel
    {
        public int Id { get; set; }
        public CarDeliveryState State { get; set; }

        public DepartmentModel DepartmentModel { get; set; }
        public int? DepartmentId { get; set; }

        public DriverModel DriverModel { get; set; }
        public int DriverId { get; set; }

        public PostManagerModel PostManagerModel { get; set; }
        public int PostManagerId { get; set; }
    }
}
