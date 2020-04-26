using System;
using System.Collections.Generic;
namespace Lab8
{
    class Program
    {
        static void Main(string[] args)
        {


            // Observer
            GasStationEmployee employee = new GasStationEmployee();

            Car car1 = new Car("Audi");
            employee.addCar(car1);

            Car car2 = new Car ("BMW");
            employee.addCar(car2);

            Car car3 = new Car("Honda");
            employee.addCar(car3);

            Car car4 = new Car("Toyota");
            employee.addCar(car4);

            car1.giveNewPosition(1);
            car2.giveNewPosition(2);
            car3.giveNewPosition(11);
            car4.giveNewPosition(12);

            employee.newGasPump();

            car1.giveNewPosition(0);
            car2.giveNewPosition(1);
            car3.giveNewPosition(10);
            car4.giveNewPosition(11);
            employee.newGasPump();



        // Strategy



            TypeOfFuel typeoffuel = new TypeOfFuel(new Petrol98());
            typeoffuel.Fuel();

            typeoffuel = new TypeOfFuel(new Diesel());
            typeoffuel.Fuel();

             typeoffuel = new TypeOfFuel(new Petrol95());
             typeoffuel.Fuel();

            



        }
    }
}
