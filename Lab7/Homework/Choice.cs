using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework{
    class Choice{
        public string item {set;get;}
        public double price{set;get;}

        public Choice(string _item){
            item=_item;
        }
        public void info(){
            System.Console.WriteLine($"Price for the {item} is {price} zł");
        }


    }



}