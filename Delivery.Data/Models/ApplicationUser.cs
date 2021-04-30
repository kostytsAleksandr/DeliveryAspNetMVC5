using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delivery.Data.Models
{
    public class ApplicationUser : IdentityUser
    {
        public ICollection<Client> Clients { get; set; }
        public ICollection<Driver> Drivers { get; set; }
        public ICollection<PostManager> PostManagers { get; set; }
    }
}
