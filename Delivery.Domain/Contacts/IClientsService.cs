using Delivery.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delivery.Domain.Contracts
{
    public interface IClientsService
    {
        IReadOnlyCollection<ClientModel> GetAll();
        ClientModel GetClientById(int id);
        string CreateParcel(ParcelModel model);
        ParcelModel GetParcelById(int pacelId);
        void GetParcel(ParcelModel model);
    }
}
