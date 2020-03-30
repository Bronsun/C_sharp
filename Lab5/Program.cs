using System;
using System.Collections.Generic;
namespace Lab5{

    class Program{
        static void Main(string[] args){

           Phone phone1 = new BestPhoneFactory().CheapestPhone();
            phone1.ShowInfo();
            Phone phone2 = new CheapPhoneFactory().NewestPhone();
            phone2.ShowInfo();
            Phone phone3 = new EasyPhoneFactory().OldestPhone();
            phone3.ShowInfo();
            Phone phone4 = new BestPhoneFactory().CreatePhone("iPhone");
            phone4.ShowInfo();
            Phone phone5 = new BestPhoneFactory().CreatePhone("NONAME");
            phone5.ShowInfo();
            }







        }



    }
