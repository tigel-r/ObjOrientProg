using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    abstract class Delivery
    {
        public string Address;
    }

    class HomeDelivery : Delivery
    {

    }

    class PickPointDelivery : Delivery
    {

    }

    class ShopDelivery : Delivery
    {

    }
}
