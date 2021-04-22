using Delivery.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delivery.Data.Contracts
{
    public interface IClientRepository
    {
        IReadOnlyCollection<Client> GetAll();
        Client GetById(int id);
        void CreateParcel(Parcel model);
        void GetParselInfo(Parcel model);
        void GetParcel(Parcel model);
    }
}
