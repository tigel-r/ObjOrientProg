using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    public class Catalog
    {
        private string[,] ProdCatalog = new string[,]
        {
            {"товар 1","товар 2","товар 3","товар 4","товар 5" },
            {"товар 6","товар 7","ААААААА","товар 9","товар 10" },
            {"товар 11","товар 12","товар 13","товар 14","товар последний" }
        };

        public void ShowingPage(int PageNum)
        {
            Console.WriteLine("Страница #" + PageNum);
            Console.WriteLine("==================" + "\n");

            for (int j = 0; j < ProdCatalog.GetLength(1); j++)
            {
                Console.WriteLine(ProdCatalog[PageNum-1, j]);

            }
        }

        public void ShowingOptions()
        {
            for (int i = 0; i < ProdCatalog.GetLength(0); i++)
            {
                Console.WriteLine("Страница #" + (i + 1));
                Console.WriteLine("==================" + "\n");

                for (int j = 0; j < ProdCatalog.GetLength(1); j++)
                {
                    Console.WriteLine(ProdCatalog[i, j]);

                }

                Console.WriteLine();

            }

            Console.WriteLine();

        }

        public string ProductSearch(String Name)
        {
            for (int i = 0; i < ProdCatalog.GetLength(0); i++)
            {
               
                for (int j = 0; j < ProdCatalog.GetLength(1); j++)
                {
                    if ( Name == ProdCatalog[i, j])
                     return ProdCatalog[i, j];
                }

            }

            return "";
        }
    }
}
