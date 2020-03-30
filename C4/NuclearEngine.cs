using System;
using System.Collections.Generic;
using System.Text;

namespace C4
{
    class NuclearEngine:Engine{

        private Waste nuclearWaste = new Waste("Nuclear");
        public override void CheckSupplies(){
            fuel.HowMuchLeft();
            nuclearWaste.HowMuchLeft();
        }
        public NuclearEngine(){}
        public override void OneDayOfTravel(){
            fuel.Amount-=10;
            nuclearWaste.Amount+=1;
            fuel.HowMuchLeft();
            nuclearWaste.HowMuchLeft();
            //System.Console.WriteLine("Fuel supply: "+fuel.Amount);
        }
        public override double Refill(double amount){
            
            nuclearWaste.Amount = 0;
            fuel.Amount+=amount;
            return amount;
        }


    }


}