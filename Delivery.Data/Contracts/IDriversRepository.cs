using Delivery.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delivery.Data.Contracts
{
    public interface IDriversRepository
    {
        void UpdateDeliveryStatusBeforeWay(Parcel parcel, CarDeliveryStatus carDeliveryStatus);
        void UpdateDeliveryStatusAfterWay(Parcel parcel, CarDeliveryStatus carDeliveryStatus);
    }
}
