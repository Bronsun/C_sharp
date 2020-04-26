using System;

namespace Lab8{
    class Petrol95 : StrategyOfFuel{


        


        public override void Fuel(){
            System.Console.WriteLine("Client chose: " + GetType().Name + "\n");
        }
    }
}