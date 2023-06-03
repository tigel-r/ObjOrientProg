using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Product
    {
        public string Type;
        public float Price;
        public int Mass;
        public bool Fragile;

        public bool DeliveryPoss(int SignifMass, bool SignifFragility, int WeightLimit)
        {
            bool DelivPoss;

            if (SignifMass > WeightLimit && SignifFragility)
                DelivPoss = false;

            else
                DelivPoss = true;

            return DelivPoss;
        }
    }
}
