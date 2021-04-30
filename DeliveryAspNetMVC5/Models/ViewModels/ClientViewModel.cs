using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliveryAspNetMVC5.Models
{
    public class ClientViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public int CountBadParcels { get; set; }

        public ICollection<ParcelViewModel> ParcelsSentViewModel { get; set; }
        public ICollection<ParcelViewModel> ParcelsGotViewModel { get; set; }
    }
}
