using System;
using System.Collections.Generic;
namespace Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            Device myDevice1 = new Phone("Samsung",5);
            myDevice1.ShowInfo();
            System.Console.WriteLine(myDevice1.ToString());

            List<Device> myElectronics = new List<Device>();
           myElectronics.Add(new Phone("iPhone",5));
           myElectronics.Add(new Vacuum("Bosh",230));
           myElectronics.Add(new Computer("Macbook Pro",20));
           foreach (Device v in myElectronics) Console.WriteLine(v);
            
            System.Console.WriteLine(myElectronics.ToString());

            Raspberry myRaspberry1 = new Raspberry(150,"Cortex");

            myRaspberry1.Kind();
            myRaspberry1.Price();



        }
    }
}
