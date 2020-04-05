using System;
using System.Collections.Generic;

namespace Homework{
     class MeatDecorator : HamburgerDecorator{
        public MeatDecorator(IHamburger hamburger):base(hamburger){}

        public override double CalculateCost(){
            return base.CalculateCost() + 5.00;
        }
        public override string GetName(){
            return base.GetName() + " + Extra Meat";
        }
    }

}