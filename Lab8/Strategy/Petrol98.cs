using System;

namespace Lab8{
    class Petrol98 : StrategyOfFuel{


        
        


        public override void Fuel(){
            
            System.Console.WriteLine("Client chose: " + GetType().Name+ "\n");
        }
    }
}