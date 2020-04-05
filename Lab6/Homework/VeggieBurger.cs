using System;
using System.Collections.Generic;


namespace Homework{
     class VeggieBurger : IHamburger{
        public double CalculateCost(){
            return 25.50;
        }
        public string GetName(){
            return "Veggie Burger";
        }

    }
}