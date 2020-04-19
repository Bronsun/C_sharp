using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
	class DiscountCommand:ICommand
    {
        private readonly Choice _choice;
        private readonly double _price;
        public DiscountCommand (Choice choice,int price){
            _choice = choice;
            _price = price;
        }
        public double Price(){
            return _price*0.5;
        }
        public void Execute(){
            _choice.price = _price*0.5;
            System.Console.WriteLine("Discounted for buying meat items is 50%");
            _choice.info();
        }
    }
}