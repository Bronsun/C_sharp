using System;
using System.Collections.Generic;

namespace Homework{
    abstract class HamburgerDecorator : IHamburger{

        protected IHamburger _hamburger;
        public  HamburgerDecorator(IHamburger hamburger){
            _hamburger=hamburger;
        }

        public virtual double CalculateCost(){
            return _hamburger.CalculateCost();
        }

        public virtual string GetName(){
            return _hamburger.GetName();
        }

    }


}