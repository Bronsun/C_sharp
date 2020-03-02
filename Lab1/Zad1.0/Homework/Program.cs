using System;
using System.Collections.Generic;
namespace Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Car newCar1 = new Car();
            Range range1 = new Range(1280000);
            newCar1.Manufacture= "Audi";
            newCar1.Model = "A4";
            newCar1.Generation = 8;
            newCar1.Year=2009;
            
            newCar1.PrintAll();
            newCar1.HowManyCars();

            
            range1.nModel = "A8";
            range1.ShowInfo();
            System.Console.WriteLine("Model: "+ range1.nModel);
             List<Car> myGarage = new List<Car>();
            myGarage.Add(new Car(){Manufacture= "Mercedes"});
            myGarage.Add(new Car(){Manufacture= "BMW"});
            myGarage.Add(new Car(){Manufacture= "Ferrari"});
            myGarage.Add(new Car(){Manufacture= "Porsche"});
                foreach(Car dev in myGarage){
                    dev.PrintAll();
                }

            Square mySquare = new Square(5);
            Console.WriteLine("Digoanl: "+mySquare.Diagonal);


        }
    }
}
