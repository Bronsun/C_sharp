using System;
using System.Collections.Generic;
namespace Zadania
{
    class Program
    {
        static void Main(string[] args)
        {
           Vehicle newVehicle1 = new Train("Disele",190);
           System.Console.WriteLine(newVehicle1.ToString());

           newVehicle1.ShowData();


           List<Vehicle> myTransport = new List<Vehicle>();
           myTransport.Add(new Train("Electric",90));
           myTransport.Add(new Car("Hybrid",120));
           myTransport.Add(new Boat("Prom",20));
           foreach (Vehicle v in myTransport) Console.WriteLine(v);

           System.Console.WriteLine(myTransport.ToString());



           
           
        }
    }
}
