using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadania{
    public class VisitCommand:ICommand{
        private double hour{get;set;}
        private string name{get;set;}

        public VisitCommand(double _hour, string _name){
            _hour=hour;
            _name=name;
        }

        public void Execute(){
            System.Console.WriteLine(hour + " visiting: "+ name);
        }


    }








}