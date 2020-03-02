using System;

namespace Homework{

        class Range: Car{
                public Range(int km_)
                {
                        this.km_ = km_;
                }
                public int km_{get;set;}
                public string nModel{
                        get{return Model;}
                        set{Model=value;}
                }

                public void ShowInfo(){
                        System.Console.WriteLine("Range is: "+km_);
                }






        }


}




