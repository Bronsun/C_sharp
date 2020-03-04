using System;

namespace Homework{

    class Raspberry:IDevice, IProcessor{

        public Raspberry(double price_,string kind_){
            price=price_;
            kind=kind_;
        }

        public double price{get;set;}
        public string kind{get;set;}


        public  void Kind(){
            System.Console.WriteLine("Processor: "+ kind);
        }
        public  void Price(){
            System.Console.WriteLine("Price of device: " +price);
        }


    } 



}