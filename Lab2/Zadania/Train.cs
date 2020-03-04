using System;

namespace Zadania{

        class Train: Vehicle{

              public override void ShowData(){

                  Console.WriteLine("Vehicle type: train");


              }      
            
            public Train(string powerType_, int maxV_)
            {
                powerType=powerType_;
                maxV=maxV_;
            }


            public string powerType{get;set;}
            public int maxV{get;set;}

            public override string ToString(){


                return "This is a train.\nPower: "+powerType+"\nVmax: "+ maxV + "km/h";


            }




        }








}