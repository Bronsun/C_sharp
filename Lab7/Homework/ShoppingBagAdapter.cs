using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    class ShoppingBagAdapter: IOrder
    {
        private ShoppingBag _plan = new ShoppingBag();
        private double total =0;
        public void Run(List<ICommand> items){
            foreach(var item in items){
                _plan.Add(item);
                item.Execute();
                total +=item.Price();
            }
            System.Console.WriteLine("Total for order= "+ total+"zł");
        }

    }
}