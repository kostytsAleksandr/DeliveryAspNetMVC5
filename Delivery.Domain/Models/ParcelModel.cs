using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delivery.Domain.Models
{
    public class ParcelModel
    {
        public int Id { get; set; }
        public int Weight { get; set; }
        public decimal Costs { get; set; }      
        public ParcelState State { get; set; }

        public int ClientWhoSendId { get; set; }
        public ClientModel ClientWhoSendModel { get; set; }

        public int ClientWhoGetId { get; set; }
        public ClientModel ClientWhoGetModel { get; set; }

        public int PostManagerId { get; set; }
        public PostManagerModel PostManagerModel { get; set; }

        public int? DriverId { get; set; }
        public DriverModel DriverModel { get; set; }

        public int DepartmentFromId { get; set; }
        public DepartmentModel DepartmentFromModel { get; set; }

        public int DepartmentToId { get; set; }
        public DepartmentModel DepartmentToModel { get; set; }
    }
}
