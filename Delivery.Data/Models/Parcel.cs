using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delivery.Data.Models
{
    public class Parcel
    {
        public int Id { get; set; }
        public int Weight { get; set; }
        public decimal Costs { get; set; }      
        public ParcelState State { get; set; }

        public int ClientWhoSendId { get; set; }
        public Client ClientWhoSend { get; set; }

        public int ClientWhoGetId { get; set; }
        public Client ClientWhoGet { get; set; }

        public int? PostManagerId { get; set; }
        public PostManager PostManager { get; set; }

        public int? DriverId { get; set; }
        public Driver Driver { get; set; }

        public int FromDepartmentId { get; set; }
        public Department From { get; set; }

        public int ToDepartmentId { get; set; }
        public Department To { get; set; }
    }
}
