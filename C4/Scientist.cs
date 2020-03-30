using System;
using System.Collections.Generic;
using System.Text;

namespace C4{
    class Scientist:Human{

       
         public  Scientist(double s): base(s){}

        public void Work(){
            ScientificProbe scientitist = new ScientificProbe();
            scientitist.GatherData();
        }
        public ScientificProbe myProbe{get;set;}    
        

    }

}