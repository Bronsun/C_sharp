using System;
using System.Collections.Generic;
using System.Text;



namespace C4{
    class NavigationPanel:ITool{

        private int currentNumber=0;
        private List<Destination> ports = new List<Destination>();
        private List<int> travelDays = new List<int>();

        public int TotalNumber{
            
            get{return travelDays.Count;}
        }
            public void AddPort(string name, int days){
                travelDays.Add(days);
                ports.Add(new Destination(name));
            }
            public void Arrived()
            {
                currentNumber++;
            }
            public void Conserve()
            {
                System.Console.WriteLine("Navigation panel ready");
            }

            public int DaysToNextDestination(){
                return travelDays[currentNumber];
            }
            public NavigationPanel(){}
            public string NextDestination(){
         
                Destination actualPort=ports[currentNumber];
                return actualPort.Name;


            }
        }

    }
