using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Product
    {
        public Product(string Name)
        {
            this.Name = Name;
        }
        
        public string Name;
        public float Price;
        private bool DelivPoss;
        private int Mass;
        private bool Fragile;
        private int MassLimit = 10;

        private bool PossibilitCheck()
        {
            if (Mass > MassLimit && Fragile)
                DelivPoss = false;

            else
                DelivPoss = true;

            return DelivPoss;

        }

        private void ProductEvaluation(string NameProd)
        {

            Catalog Cat = new Catalog();

            string TestName = Cat.ProductSearch(NameProd);

            if (NameProd == TestName)
            {
                Random random = new Random();

                Price = random.Next(500, 1500);
                Mass = random.Next(3, 15);
                Fragile = (random.Next(6)%2 == 0);

            }

            else
            {
                Console.WriteLine("Товара не существует!");

                
            }
        }

        public void PrintInfo()
        {
            ProductEvaluation(this.Name);

            Console.WriteLine("Наименование: " + Name);
            Console.WriteLine("Стоимость: " + Price);

            Console.WriteLine(Price + " " + Mass + " " + Fragile);

            if (PossibilitCheck())
            Console.WriteLine("Доставка на дом: Да");
            else
            Console.WriteLine("Доставка на дом: Нет");

        }
    }
}
