using System;

namespace Lab8{
    class TypeOfFuel
    {
        private StrategyOfFuel _strategy;
        public TypeOfFuel(StrategyOfFuel strategy){
            _strategy = strategy;
        }
        public void Fuel(){
            _strategy.Fuel();
        }
    }
}