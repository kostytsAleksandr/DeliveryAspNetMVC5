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
                .HasRequired<Driver>(x => x.Driver)
                .WithMany(x => x.Statuses)
                .HasForeignKey(x => x.DriverId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CarDeliveryStatus>()
                .HasOptional<Department>(x => x.Department)
                .WithMany(x => x.Statuses)
                .HasForeignKey(x => x.DepartmentId);

            modelBuilder.Entity<Department>()
                .HasRequired<City>(x => x.City)
                .WithMany(x => x.Departments)
                .HasForeignKey(x => x.CityId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Parcel>()
                .HasRequired<Client>(x => x.ClientWhoSend)
                .WithMany(x => x.ParcelsSent)
                .HasForeignKey(x => x.ClientWhoSendId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Parcel>()
                .HasRequired<Client>(x => x.ClientWhoGet)
                .WithMany(x => x.ParcelsGot)
                .HasForeignKey(x => x.ClientWhoGetId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Parcel>()
                .HasOptional<Driver>(x => x.Driver)
                .WithMany(x => x.ParcelsInCar)
                .HasForeignKey(x => x.DriverId);

            modelBuilder.Entity<Parcel>()
              .HasRequired<Department>(x => x.DepartmentFrom)
              .WithMany(x => x.ParcelsFrom)
              .HasForeignKey(x => x.DepartmentFromId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Parcel>()
                .HasRequired<Department>(x => x.DepartmentTo)
                .WithMany(x => x.ParcelsTo)
                .HasForeignKey(x => x.DepartmentToId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Parcel>()
                .HasRequired<PostManager>(x => x.PostManager)
                .WithMany(x => x.Parcels)
                .HasForeignKey(x => x.PostManagerId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CarDeliveryStatus>()
                .HasRequired<PostManager>(x => x.PostManager)
                .WithMany(x => x.CarDeliveryStatuses)
                .HasForeignKey(x => x.PostManagerId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Driver>()
               .HasRequired<Car>(x => x.Car)
               .WithMany(x => x.Drivers)
               .HasForeignKey(x => x.CarId)
               .WillCascadeOnDelete(false);
        }

    }
}
