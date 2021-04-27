using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delivery.Domain.Models
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
