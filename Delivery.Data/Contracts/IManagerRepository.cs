using Delivery.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delivery.Data.Contracts
{
    public interface IManagerRepository
    {
        void CreateCity(City model);
        void CreateDepartment(Department model);
        void SetDriverForNewParcel(Driver driver, Parcel parcel);
        IReadOnlyCollection<Parcel> GetAllParselsInfo();
        IReadOnlyCollection<Parcel> GetParcelsByDepartmentFrom(int departmentId);
        void BlockBadParcel(Parcel model);
    }
}
