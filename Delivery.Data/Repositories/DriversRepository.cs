using Delivery.Data.Contracts;
using Delivery.Data.Models;
using Delivery.Data.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delivery.Data.Repositories
{
    public class DriversRepository : IDriversRepository
    {
        public void UpdateDeliveryStatusBeforeWay(Parcel parcel, CarDeliveryStatus carDeliveryStatus)
        {
            using (var ctx = new DeliveriesContext())
            {
                ctx.Parcels.FirstOrDefault(x => x.Id == parcel.Id).State = (ParcelState)1;
                ctx.CarDeliveryStatuses.FirstOrDefault(x => x.Id == carDeliveryStatus.Id)
                    .State = (CarDeliveryState)0;
                ctx.SaveChanges();
            }
        }

        public void UpdateDeliveryStatusAfterWay(Parcel parcel, CarDeliveryStatus carDeliveryStatus)
        {
            using (var ctx = new DeliveriesContext())
            {
                ctx.Parcels.FirstOrDefault(x => x.Id == parcel.Id).State = (ParcelState)2;
                ctx.CarDeliveryStatuses.FirstOrDefault(x => x.Id == carDeliveryStatus.Id)
                    .State = (CarDeliveryState)1;
                ctx.SaveChanges();
            }
        }
    }
}
