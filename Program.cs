using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Test
{

    class Order <TDelivery, TStruct> where TDelivery : Delivery
    {
        public TDelivery Delivery;

        public int Number;

        public string Description;

        public void DisplayAddress()
        {
            Console.WriteLine(Delivery.Address);
        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Product Pro = new Product("товар ");

            Pro.PrintInfo();



          





        }
    }
}
