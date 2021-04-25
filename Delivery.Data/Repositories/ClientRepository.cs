using Delivery.Data.Contracts;
using Delivery.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delivery.Data.Repositories
{
    public class ClientRepository : IClientRepository
    {
        public void CreateParcel(Parcel model)
        {
            throw new NotImplementedException();
        }

        public IReadOnlyCollection<Client> GetAll()
        {
            throw new NotImplementedException();
        }

        public Client GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void GetParcel(Parcel model)
        {
            throw new NotImplementedException();
        }

        public void GetParselInfo(Parcel model)
        {
            throw new NotImplementedException();
        }
    }
}
