using System;
using System.Collections.Generic;


namespace Homework
{
    class Hobbies : IPerson{

        public string hobby{get; private set;}



        public Hobbies(string _hobby){
            hobby=_hobby;
        }


        public void ShowData(){
            System.Console.WriteLine("                  "+hobby);
        }

    }
    
}