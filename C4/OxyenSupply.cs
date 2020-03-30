using System;
using System.Collections.Generic;
using System.Text;


namespace C4{

    class OxygenSupply:IStorable{

        public double Amount {get;set;}
        public double MaxCapacity{get;set;}


        public void HowMuchLeft(){
            System.Console.WriteLine("Oxyen supply: "+ Amount);
        }
        public OxygenSupply(double capacity)
        {
            this.MaxCapacity = capacity;
        }
         

    }




}