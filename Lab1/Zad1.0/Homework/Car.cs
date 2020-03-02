using System;

namespace Homework{

        class Car{  

            public Car(){
                manufacture_="Unknown";
                model_="Unknown";
                generation_=0;
                year_=0;
                counter_++;
            }
            public Car(string manufacture_,string model_)
            {
                this.manufacture_=manufacture_;
                this.model_=model_;
            }
            public Car(int year_)
            {
                if (year_<1885){
                    Console.WriteLine("First car was create in 1885 so it is impossible to have older car.");
                }else if (year_>2020){
                    Console.WriteLine("We have 2020 you cannot have younger car XD");
                }else{
                    this.year_=year_;
                    //counter_++;
                }

            }
           
                private string manufacture_,model_;
                private int year_,generation_,counter_;

            public string Manufacture{
                get{return manufacture_;}
                set{manufacture_=value;}
            }
            public string Model{
                get{return model_;}
                set{model_=value;}
            }
            public int Generation{
                get{return generation_;}
                set{generation_=value;}
            }
            public int Year{
                get{return year_;}
                set{year_=value;}
            }
           

            public void PrintAll(){

            Console.WriteLine("\nManufacture: "+Manufacture+"\n"+"Model: "+Model+"\nGeneration: "+Generation+"\n"+"Year: "+Year+"\n");
            }
           public void HowManyCars(){
             Console.WriteLine("How many is cars in our database: " + counter_+"%\n");
            }
        }







}