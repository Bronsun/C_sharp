using System;

namespace Homework{

        class Vacuum: Device{

            public override void ShowInfo(){
                System.Console.WriteLine("Device: Vacuum");
            }

            public Vacuum(string name_, int voltage_){
                name=name_;
                volatge=voltage_;
            }

            public string name{get;set;}
            public int volatge{get;set;}

            public override string ToString(){
                return "Name of device "+ name + "\nWhat voltage it takes "+ volatge +" V\n";
            }

        }
}
