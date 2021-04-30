using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliveryAspNetMVC5.Models
{
    public enum ParcelState
    {
        taken,
        inRoad,
        delivered,
        received,
        canceled
    }
}
