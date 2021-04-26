using Delivery.Data.Contracts;
using Delivery.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delivery.Data.Repositories
{
    public class ClientsRepository : IClientsRepository
    {
        public void CreateParcel(Parcel model)
        {
            using (var ctx = new DeliveriesContext())
            {
                ctx.Parcels.Add(model);
                ctx.Parcels.FirstOrDefault(x => x.Id == model.Id).State = (ParcelState)0;
                ctx.SaveChanges();
            }
        }

        public IReadOnlyCollection<Client> GetAll()
        {
            using (var ctx = new DeliveriesContext())
            {
                return ctx.Clients.AsNoTracking().ToList();
            }
        }

        public Client GetClientById(int id)
        {
            using (var ctx = new DeliveriesContext())
            {
                return ctx.Clients.FirstOrDefault(x => x.Id == id);
            }
        }

        public void GetParcel(Parcel model)
        {
            using (var ctx = new DeliveriesContext())
            {
                model.State = (ParcelState)3;
                ctx.Parcels.FirstOrDefault(x => x.Id == model.Id).State = (ParcelState)3;
                ctx.Clients.FirstOrDefault(x => x.Id == model.ClientWhoGetId).ParcelsGot.Add(model);
                ctx.SaveChanges();
            }
        }

        public Parcel GetParcelById(int parcelId)
        {
            using (var ctx = new DeliveriesContext())
            {
                return ctx.Parcels.FirstOrDefault(x => x.Id == parcelId);
            }
        }
    }
}
