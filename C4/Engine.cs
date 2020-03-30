using System;
using System.Collections.Generic;
using System.Text;

namespace C4{
    abstract class Engine{
        protected Fuel fuel = new Fuel();
        public virtual void CheckSupplies(){
            System.Console.WriteLine("Fuel: "+ fuel.Amount);
        }
        public Engine(){
            
            fuel.Amount=100;
           
        }
        public abstract void OneDayOfTravel();
        public abstract double Refill(double amount);

    }


}