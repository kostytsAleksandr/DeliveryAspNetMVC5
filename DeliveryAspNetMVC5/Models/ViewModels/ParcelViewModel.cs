using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliveryAspNetMVC5.Models
{
    public class ParcelViewModel
    {
        public int Id { get; set; }
        public int Weight { get; set; }
        public decimal Costs { get; set; }      
        public ParcelState State { get; set; }

        public int ClientWhoSendId { get; set; }
        public ClientViewModel ClientWhoSendViewModel { get; set; }

        public int ClientWhoGetId { get; set; }
        public ClientViewModel ClientWhoGetViewModel { get; set; }

        public int PostManagerId { get; set; }
        public PostManagerViewModel PostManagerViewModel { get; set; }

        public int? DriverId { get; set; }
        public DriverViewModel DriverViewModel { get; set; }

        public int DepartmentFromId { get; set; }
        public DepartmentViewModel DepartmentFromViewModel { get; set; }

        public int DepartmentToId { get; set; }
        public DepartmentViewModel DepartmentToViewModel { get; set; }
    }
}
