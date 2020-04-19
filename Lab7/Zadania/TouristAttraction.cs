using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadania{

    class TouristAtrraction: ICommand{
 
        private string _Nazwa{get;set;}

        public TouristAtrraction(string nazwa){
            _Nazwa=nazwa;   
        }

        public void Execute(){
            System.Console.WriteLine("Tickets reserved for: "+ _Nazwa);
        }

    }


}