using System.Collections.Generic;

using System;

namespace Lab8{
    class GasStationEmployee:ISubject{
        private List<IObserver> observerList;
        public GasStationEmployee(){
            observerList = new List<IObserver>();
        }
        public void newGasPump(){
            informObservers();
        }
        public void addCar(IObserver o)
        {
            observerList.Add(o);
            
        }
        public void informObservers(){
            foreach(IObserver o in observerList)
            {
                o.update();
            }
        }


    }
}