using System;
using System.Collections.Generic;

namespace Homework{
     class CheeseDecorator : HamburgerDecorator{
        
        
        public CheeseDecorator(IHamburger hamburger):base(hamburger){


        }

       public override  double  CalculateCost(){
            return base.CalculateCost() + 2.15;
        }
        public override string GetName(){
            return base.GetName() + " + Cheese";
        }
    }

}