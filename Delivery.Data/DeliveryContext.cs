using Delivery.Data.Models;
using DeliveryAspNetMVC5.Models;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delivery.Data
{
    public class DeliveriesContext : IdentityDbContext<ApplicationUser>
    {
        public DeliveriesContext() : base("DefaultConnection") { }

        public DbSet<Car> Cars { get; set; }
        public DbSet<CarDeliveryStatus> CarDeliveryStatuses { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Driver> Drivers { get; set; }
        public DbSet<Parcel> Parcels { get; set; }
        public DbSet<PostManager> PostManagers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<CarDeliveryStatus>()
                .HasRequired<Car>(x => x.Car)
                .WithMany(x => x.Statuses)
                .HasForeignKey(x => x.CarId);

            modelBuilder.Entity<CarDeliveryStatus>()
                .HasRequired<Department>(x => x.Department)
                .WithMany(x => x.Statuses)
                .HasForeignKey(x => x.DepartmentId);

            modelBuilder.Entity<Department>()
                .HasRequired<City>(x => x.City)
                .WithMany(x => x.Departments)
                .HasForeignKey(x => x.CityId);

            modelBuilder.Entity<Parcel>()
                .HasRequired<Client>(x => x.ClientWhoSend)
                .WithMany(x => x.ParcelsSent)
                .HasForeignKey(x => x.ClientWhoSendId);

            modelBuilder.Entity<Parcel>()
                .HasRequired<Client>(x => x.ClientWhoGet)
                .WithMany(x => x.ParcelsGot)
                .HasForeignKey(x => x.ClientWhoGetId);

            modelBuilder.Entity<Parcel>()
                .HasOptional<Driver>(x => x.Driver)
                .WithMany(x => x.ParcelsInCar)
                .HasForeignKey(x => x.DriverId);

            modelBuilder.Entity<Parcel>()
              .HasRequired<Department>(x => x.DepartmentFrom)
              .WithMany(x => x.ParcelsFrom)
              .HasForeignKey(x => x.DepartmentFromId);

            modelBuilder.Entity<Parcel>()
                .HasRequired<Department>(x => x.DepartmentTo)
                .WithMany(x => x.ParcelsTo)
                .HasForeignKey(x => x.DepartmentToId);

            modelBuilder.Entity<Parcel>()
                .HasOptional<PostManager>(x => x.PostManager)
                .WithMany(x => x.Parcels)
                .HasForeignKey(x => x.PostManagerId);

            modelBuilder.Entity<CarDeliveryStatus>()
                .HasOptional<PostManager>(x => x.PostManager)
                .WithMany(x => x.CarDeliveryStatuses)
                .HasForeignKey(x => x.PostManagerId);
        }

    }
}
