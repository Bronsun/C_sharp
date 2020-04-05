using System;
using System.Collections.Generic;


namespace Homework{
     class UltraBurger : IHamburger{
        public double CalculateCost(){
            return 35.00;
        }
        public string GetName(){
            return "UltraBurger";
        }

    }
}