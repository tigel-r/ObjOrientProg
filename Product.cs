using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Product
    {
        public Product(string Type)
        {
            this.Type = Type;
        }

        public string Type;
        public float Price;
        private bool DelivPoss;
        private int Mass;
        private bool Fragile;
        private int MassLimit = 10;

        public bool PossibilitCheck()
        {
            if (Mass > MassLimit && Fragile)
                DelivPoss = false;

            else
                DelivPoss = true;

            return DelivPoss;
        }

        public void PrintInfo()
        {
            Console.WriteLine("Наименование: " + Type);
            Console.WriteLine("Стоимость: ");
            Console.WriteLine();


        
        
        }
        

    }
}
