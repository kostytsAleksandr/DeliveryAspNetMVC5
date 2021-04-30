namespace Delivery.Data.Migrations
{
    using Delivery.Data.Models;
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using System;
    using System.Collections.ObjectModel;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Delivery.Data.DeliveriesContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Delivery.Data.DeliveriesContext context)
        {
            var userManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));
            var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(context));

            if (!context.Roles.Any())
            {
                roleManager.Create(new IdentityRole { Name = "Driver" });
                roleManager.Create(new IdentityRole { Name = "Admin" });
                roleManager.Create(new IdentityRole { Name = "Client" });
            }
            if (userManager.FindByEmail("alekseenko@gmail.com") == null)
            {
                var admin = new ApplicationUser { Email = "alekseenko@gmail.com", PhoneNumber = "1234567890", UserName = "alekseenko@gmail.com" };
                userManager.Create(admin, "Alex@1234");
                userManager.AddToRole(admin.Id, "Admin");
                admin.PostManagers = new Collection<PostManager>();
                admin.PostManagers.Add(new PostManager { Name = "Aleksey", LastName = "Alekseenko" });
                context.SaveChanges();
            }
            if (userManager.FindByEmail("driver@gmail.com") == null)
            {
                var driver = new ApplicationUser { Email = "driver@gmail.com", PhoneNumber = "4567890123", UserName = "driver@gmail.com" };
                userManager.Create(driver, "Alex@1234");
                userManager.AddToRole(driver.Id, "Driver");
                driver.Drivers = new Collection<Driver>();
                driver.Drivers.Add(new Driver { Name = "Sergey", LastName = "Sergeenko" });
                context.SaveChanges();
            }
        }
    }
}