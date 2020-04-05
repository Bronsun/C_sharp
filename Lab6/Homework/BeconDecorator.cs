using System;
using System.Collections.Generic;

namespace Homework{
     class BeconDecorator : HamburgerDecorator{
        public BeconDecorator(IHamburger hamburger):base(hamburger){}

         public override double  CalculateCost(){
            return base.CalculateCost() + 5.15;
        }
         public override string GetName(){
            return base.GetName() + " + Extra Bacon";
        }
    }

}