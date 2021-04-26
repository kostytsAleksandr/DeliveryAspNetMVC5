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
        public void AddBadParcel(Parcel model)
        {
            using (var ctx = new DeliveriesContext())
            {
                ctx.Parcels.FirstOrDefault(x => x.Id == model.Id).ClientWhoSend.CountBadParcels++;
                ctx.SaveChanges();
            }
        }

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
                parcel.Driver = ctx.CarDeliveryStatuses
                .FirstOrDefault(x => x.State == (CarDeliveryState)1 && x.DepartmentId == parcel.DepartmentFromId).Driver;
                ctx.SaveChanges();
                return parcel.Driver != null;
            }
        }

        public void DeleteClient(Client model)
        {
            using (var ctx = new DeliveriesContext())
            {
                ctx.Clients.Remove(model);
                ctx.SaveChanges();
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
