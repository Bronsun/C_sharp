using System;

namespace Homework{
    
        class Square{

            public Square(int a_=0)
            {
                this.a_=a_;
            }
            private int a_;
            
            public int A{
                get{return a_;}
            }
            
            public double Diagonal{
                get{return A/Math.Sqrt(2);}
            }
            


        }





}