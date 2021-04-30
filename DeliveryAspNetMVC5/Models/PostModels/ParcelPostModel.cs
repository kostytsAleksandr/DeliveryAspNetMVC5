using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliveryAspNetMVC5.Models
{
    public class ParcelPostModel
    {
        public int Weight { get; set; }
        public decimal Costs { get; set; }      

        public int ClientWhoSendId { get; set; }
        public ClientPostModel ClientWhoSendPostModel { get; set; }

        public int ClientWhoGetId { get; set; }
        public ClientPostModel ClientWhoGetPostModel { get; set; }

        public int PostManagerId { get; set; }
        public PostManagerPostModel PostManagerPostModel { get; set; }

        public int DepartmentFromId { get; set; }
        public DepartmentPostModel DepartmentFromPostModel { get; set; }

        public int DepartmentToId { get; set; }
        public DepartmentPostModel DepartmentToPostModel { get; set; }
    }
}
