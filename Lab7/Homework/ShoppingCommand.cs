using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
	class ShoppingCommand:ICommand
    {
        private readonly Choice _Choice;
        private readonly int _price;
        public ShoppingCommand (Choice Choice,int price){
            _Choice = Choice;
            _price = price;
        }
        public double Price(){
            return _price;
        }
        public void Execute(){
            _Choice.price = _price;
            _Choice.info();
        }
    }
}