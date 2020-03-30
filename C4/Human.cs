using System;
using System.Collections.Generic;
using System.Text;

namespace C4{
    abstract class Human{

        public static double MedianSalary = 1200;
        private Random random;

        public double Salary{get;set;}


        public int Breathe(){
            return 500;
            
        }

        public double Eat(){
            
            return Math.Round(4*random.NextDouble(),1);
        }
         public Human(double s){
         random=new Random((int)DateTime.Now.Ticks);   
        }




    }


}