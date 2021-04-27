using Delivery.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delivery.Data.Contracts
{
    public interface IClientsRepository
    {
        IReadOnlyCollection<Client> GetAll();
        Client GetClientById(int id);
        void CreateParcel(Parcel model);
        Parcel GetParcelById(int pacelId);
        void GetParcel(Parcel model);
        void AddBadParcel(Parcel model);
    }
}
