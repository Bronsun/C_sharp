using System;
using System.Collections.Generic;


namespace Homework{
     class AnimalStyleBurger : IHamburger{
        public double CalculateCost(){
            return 40.00;
        }
        public string GetName(){
            return "Animal Style Burger";
        }

    }
}