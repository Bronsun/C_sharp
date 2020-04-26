using System;

namespace Lab8{
    interface ISubject{
        void addCar(IObserver o);
        void informObservers();

    }
}