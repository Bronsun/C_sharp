using System;

using System.Collections.Generic;


namespace Homework{
    public class Kompozyt : IPerson{

        private List<IPerson> people = new List<IPerson>();


        public void ShowData(){
            System.Console.WriteLine("Name:   Age:     Hobby:");
            foreach(var person in people){
                person.ShowData();
            }

        }
        public void Add(IPerson person){
            people.Add(person);
        }

    }


}