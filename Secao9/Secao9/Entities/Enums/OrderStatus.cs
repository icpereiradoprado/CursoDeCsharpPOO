using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enumeracao.Entites.Enums
{
    enum OrderStatus : int 
    {
        PendingPay = 0,
        Processing =1,
        Shiped = 2,
        Delivered = 3
    }
}
