using System;

namespace Zadania
{
    class Boat: Vehicle{

              public override void ShowData(){

                  Console.WriteLine("Vehicle type: boat");


              }      
            
            public Boat(string powerType_, int maxV_)
            {
                powerType=powerType_;
                maxV=maxV_;
            }


            public string powerType{get;set;}
            public int maxV{get;set;}

            public override string ToString(){


                return "This is a Boat.\nPower: "+powerType+"\nVmax: "+ maxV + "km/h";


            }




        }










}