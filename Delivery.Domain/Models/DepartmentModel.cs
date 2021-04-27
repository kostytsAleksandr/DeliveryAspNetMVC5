using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delivery.Domain.Models
{
    public class DepartmentModel
    {
        public int Id { get; set; }
        public string Address { get; set; }

        public int CityId { get; set; }
        public CityModel CityModel { get; set; }

        public ICollection<ParcelModel> ParcelsFromModel { get; set; }
        public ICollection<ParcelModel> ParcelsToModel { get; set; }

        public ICollection<CarDeliveryStatusModel> StatusModels { get; set; }
    }
}
