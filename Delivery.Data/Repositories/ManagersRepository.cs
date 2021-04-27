using Delivery.Data.Contracts;
using Delivery.Data.Models;
using Delivery.Data.Models.Enums;
using System;
using System.Collections.Generic;
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

        public bool SetDriverForNewParcel(CarDeliveryStatus carDeliveryStatus, Parcel parcel)
        {
            using (var ctx = new DeliveriesContext())
            {
                Driver driver= ctx.CarDeliveryStatuses
                .FirstOrDefault(x => x.State == (CarDeliveryState)1 && x.DepartmentId == parcel.DepartmentFromId).Driver;
                ctx.Parcels.FirstOrDefault(x => x.Id == parcel.Id).Driver = driver;
                ctx.SaveChanges();
                return driver != null;
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
