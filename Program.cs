using System;
using System.Collections.Generic;
using System.Diagnostics;

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
            int a = 8;

            

            Product productp = new Product();

            
        ;
            int test1 = 4;
            bool test2 = true;
            productp.DeliveryPoss(test1,test2,a);


            




        }

    }
}
