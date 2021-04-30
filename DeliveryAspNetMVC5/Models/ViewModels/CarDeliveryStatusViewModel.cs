using DeliveryAspNetMVC5.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliveryAspNetMVC5.Models
{
    public class CarDeliveryStatusViewModel
    {
        public int Id { get; set; }
        public CarDeliveryState State { get; set; }

        public DepartmentViewModel DepartmentViewModel { get; set; }
        public int? DepartmentId { get; set; }

        public DriverViewModel DriverViewModel { get; set; }
        public int DriverId { get; set; }

        public PostManagerViewModel PostManagerViewModel { get; set; }
        public int PostManagerId { get; set; }
    }
}
