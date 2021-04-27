using Delivery.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delivery.Domain.Contracts
{
    public interface IDriversService
    {
        void UpdateDeliveryStatusBeforeWay(ParcelModel parcelModel, CarDeliveryStatusModel carDeliveryStatusModel);
        void UpdateDeliveryStatusAfterWay(ParcelModel parcelModel, CarDeliveryStatusModel carDeliveryStatusModel);
        Dictionary<int, int> DriverTrips(int driverId);
    }
}
