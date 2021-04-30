using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliveryAspNetMVC5.Models
{
    public class CityViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<DepartmentViewModel> DepartmentViewModels { get; set; }
    }
} 
