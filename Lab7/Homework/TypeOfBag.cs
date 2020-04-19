using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
	class TypeOfBag
    {
        public string Type{set;get;}
        public void showType() {
            System.Console.WriteLine( $"Your bag is {Type}");
        }
    }
}