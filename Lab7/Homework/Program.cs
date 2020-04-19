using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            Choice starch = new Choice("Chleb zytni");
            Choice water = new Choice("Żywiec-Zdrój 500ml");
            Choice meat = new Choice("Szynka Wiejska 20deg");

            TypeOfBag paper = new TypeOfBag();
            TypeOfBag plastic = new TypeOfBag();
            TypeOfBag bigPaper = new TypeOfBag();

            ShoppingCommand orderStarch = new ShoppingCommand(starch,4);
            DiscountCommand orderMeat = new DiscountCommand(meat,20);
            BagCommand packedInBag = new BagCommand(paper,"Torba ekologiczna papierowa");

            ShoppingBag firstClient = new ShoppingBag();

            firstClient.Add(orderStarch);
            firstClient.Add(orderMeat);
            firstClient.Add(packedInBag);
            firstClient.Run();

            ShoppingBagAdapter OrderAdapter = new ShoppingBagAdapter();
            OrderAdapter.Run(new List<ICommand>() {orderStarch,orderMeat,packedInBag});

            

        }
    }
}
