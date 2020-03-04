using System;

namespace Zadania
{
    class Car: Vehicle{

              public override void ShowData(){

                  Console.WriteLine("Vehicle type: Car");


              }      
            
            public Car(string powerType_, int maxV_)
            {
                powerType=powerType_;
                maxV=maxV_;
            }


            public string powerType{get;set;}
            public int maxV{get;set;}

            public override string ToString(){


                return "This is a Car.\nPower: "+powerType+"\nVmax: "+ maxV + "km/h";


            }




        }










}