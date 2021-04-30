using Delivery.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delivery.Domain.Contracts
{
    public interface IManagersService
    {
        void CreateCity(CityModel model);
        void CreateDepartment(DepartmentModel model);
        IReadOnlyCollection<ParcelModel> SetDriverForNewParcel();
        IReadOnlyCollection<ParcelModel> GetAllParselsInfo();
        IReadOnlyCollection<ParcelModel> GetParcelsByDepartmentFrom(int departmentId);
        void CreateCar(CarModel model);
        void CreateCarDeliveryStatus(CarDeliveryStatusModel model);
    }
}
