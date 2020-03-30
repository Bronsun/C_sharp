using System;
using System.Collections.Generic;
using System.Text;

namespace C4
{
    class DieselEngine:Engine{
        public override void OneDayOfTravel(){
            fuel.Amount-=10;
            fuel.HowMuchLeft();
        }
        public override double Refill(double amount){
            return amount +=amount;
        }


    }


}