using System;
using System.Collections.Generic;


namespace Homework{

    class GroupOfPeople : IPerson{
        public string Name { get; private set;}

        public int Age { get; private set;}

        public GroupOfPeople(string _Name, int _Age)
        {
            Name=_Name;
            Age=_Age;
        }

        public void ShowData(){

            System.Console.WriteLine(Name + " "+ Age);

        }


    }
}