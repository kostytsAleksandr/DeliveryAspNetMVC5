using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delivery.Domain.Models
{
    public class CityModel
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<DepartmentModel> DepartmentModels { get; set; }
    }
}
