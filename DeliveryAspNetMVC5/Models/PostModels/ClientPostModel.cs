using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliveryAspNetMVC5.Models
{
    public class ClientPostModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public int CountBadParcels { get; set; }

        public ICollection<ParcelPostModel> ParcelsSentPostModel { get; set; }
        public ICollection<ParcelPostModel> ParcelsGotPostModel { get; set; }
    }
}
