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
        void ChooseDriver(Driver driver, Parcel parcel);
        void GetAllParselsInfo();

    }
}
