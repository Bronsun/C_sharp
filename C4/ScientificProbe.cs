using System;
using System.Collections.Generic;
using System.Text;

namespace C4{

    class ScientificProbe:ITool{

        public void Conserve(){
            System.Console.WriteLine("Scientific probe ready");
        }
        public void GatherData(){
           System.Console.WriteLine("Gathering data...");
        }
        
    }



}