using Delivery.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delivery.Data.Contracts
{
    public interface IDriverRepository
    {
        void UpdateCarDeliveryStatus(CarDeliveryStatus model);
        void UpdateParcelStatus(Parcel model);
    }
}
