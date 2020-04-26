using System;

namespace Lab8{
    class Diesel : StrategyOfFuel{


       
        public double Amount{get;}

       


        public override void Fuel(){
            System.Console.WriteLine("Client chose: " + GetType().Name + "\n");
        }
    }
}