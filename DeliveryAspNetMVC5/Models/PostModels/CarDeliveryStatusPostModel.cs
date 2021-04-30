using DeliveryAspNetMVC5.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliveryAspNetMVC5.Models
{
    public class CarDeliveryStatusPostModel
    {
        public int Id { get; set; }
        public CarDeliveryState State { get; set; }

        public DepartmentPostModel DepartmentPostModel { get; set; }
        public int? DepartmentId { get; set; }

        public DriverPostModel DriverPostModel { get; set; }
        public int DriverId { get; set; }

        public PostManagerPostModel PostManagerPostModel { get; set; }
        public int PostManagerId { get; set; }
    }
}
