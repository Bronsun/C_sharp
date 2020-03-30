using System;
using System.Collections.Generic;
using System.Text;

namespace C4
{
    class FoodSupply:IStorable{

    
        public double Amount{
            get;
            set;
        }

        public void HowMuchLeft(){
            System.Console.WriteLine("Food supply: "+Math.Round(Amount,1));
        }


    }


}