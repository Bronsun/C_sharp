using System;

namespace Lab8{
    class Car : IObserver{
        private string name;
        public int positionNumber;

        public Car (string name)
        {
            this.name = name;
        }
         

        public void update()
        {
            System.Console.WriteLine(name + " is " + positionNumber);
            if ( positionNumber > 10){
                System.Console.WriteLine("There is no position left please wait");
            }else if(positionNumber==0){
                System.Console.WriteLine("The " + name + " left the gas station");
            }
            else{
                System.Console.WriteLine("Please go to the " + positionNumber + " fuel pump");
            }

        }
        public void giveNewPosition(int newPositionNumber)
        {
            positionNumber=newPositionNumber;
        }

    }
}