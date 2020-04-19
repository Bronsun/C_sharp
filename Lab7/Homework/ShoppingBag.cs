using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
	class ShoppingBag
    {
        private List<ICommand> OrderSet;
        private double total = 0;
        public ShoppingBag()
        {
            OrderSet = new List<ICommand>();
        }
        public void Add(ICommand com)
        {
            OrderSet.Add(com);
        }
        public void Run()
        {
            
            foreach (ICommand com in OrderSet)
            {
                com.Execute();
                total +=com.Price();
            }
            System.Console.WriteLine("Price for all items: "+ total+"PLN");
        }
    }
}