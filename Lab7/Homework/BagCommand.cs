using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
	class BagCommand:ICommand
    {
        private readonly TypeOfBag _typeOfBag;
        private readonly string _type;
        public BagCommand (TypeOfBag typeOfBag,string type){
            
            _typeOfBag = typeOfBag;
            _type = type;
        }
        public double Price(){
            return 0;
        }
        public void Execute(){
            _typeOfBag.Type = _type;
            _typeOfBag.showType();
        }
    }
}