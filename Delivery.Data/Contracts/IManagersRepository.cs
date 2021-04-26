using Delivery.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delivery.Data.Contracts
{
    public interface IManagersRepository
    {
        void AddBadParcel(Parcel model);
        void DeleteClient(Client model);
        void CreateCity(City model);
        void CreateDepartment(Department model);
        bool SetDriverForNewParcel(CarDeliveryStatus carDeliveryStatus, Parcel parcel);
        IReadOnlyCollection<Parcel> GetAllParselsInfo();
        IReadOnlyCollection<Parcel> GetParcelsByDepartmentFrom(int departmentId);
        void CreateCar(Car model);
        void CreateCarDeliveryStatus(CarDeliveryStatus model);
    }
}
