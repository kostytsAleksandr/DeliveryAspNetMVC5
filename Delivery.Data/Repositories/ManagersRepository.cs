using Delivery.Data.Contracts;
using Delivery.Data.Models;
using Delivery.Data.Models.Enums;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delivery.Data.Repositories
{
    public class ManagersRepository : IManagersRepository
    {
        public void CreateCity(City model)
        {
            using (var ctx = new DeliveriesContext())
            {
                ctx.Cities.Add(model);
                ctx.SaveChanges();
            }
        }

        public void CreateDepartment(Department model)
        {
            using (var ctx = new DeliveriesContext())
            {
                ctx.Departments.Add(model);
                ctx.SaveChanges();
            };
        }

        public IReadOnlyCollection<Parcel> GetAllParselsInfo()
        {
            using (var ctx = new DeliveriesContext())
            {
                return ctx.Parcels.AsNoTracking().ToList();
            }
        }

        public IReadOnlyCollection<Parcel> GetParcelsByDepartmentFrom(int departmentId)
        {
            using (var ctx = new DeliveriesContext())
            {
                return ctx.Parcels.Where(x => x.DepartmentFromId == departmentId).AsNoTracking().ToList();
            }
        }
    
        public IReadOnlyCollection<Parcel> SetDriverForNewParcel()
        {
          Collection<Parcel> parcelsWithDrivers = new Collection<Parcel>();

            using (var ctx = new DeliveriesContext())
            {
                ICollection<Parcel> parcelsWithoutDrivers = ctx.Parcels.Where(x => x.Driver == null).ToList();
                foreach (var parcel in parcelsWithoutDrivers)
                {
                    Driver driver = ctx.CarDeliveryStatuses
               .FirstOrDefault(x => x.State == (CarDeliveryState)1 && x.DepartmentId == parcel.DepartmentFromId).Driver;
                    ctx.Parcels.FirstOrDefault(x => x.Id == parcel.Id).Driver = driver;
                    parcelsWithDrivers.Add(parcel);
                }              
                ctx.SaveChanges();
                return parcelsWithDrivers;
            }
        }

        public void CreateCar(Car model)
        {
            using (var ctx = new DeliveriesContext())
            {
                ctx.Cars.Add(model);
                ctx.SaveChanges();
            }
        }

        public void CreateCarDeliveryStatus(CarDeliveryStatus model)
        {
            using (var ctx = new DeliveriesContext())
            {
                ctx.CarDeliveryStatuses.Add(model);
                ctx.SaveChanges();
            }
        }
    }
}
