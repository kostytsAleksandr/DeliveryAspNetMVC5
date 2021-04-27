using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delivery.Domain.Models
{
    public class ClientModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public int CountBadParcels { get; set; }

        public ICollection<ParcelModel> ParcelsSentModel { get; set; }
        public ICollection<ParcelModel> ParcelsGotModel { get; set; }
    }
}
