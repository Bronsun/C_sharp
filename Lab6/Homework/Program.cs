using System;

namespace Homework
{
    class Program
    {
        static void Main(string[] args)
        {

        //Działanie kompozytu. Nie miałem kompletnie pomysłu na niego
             System.Console.WriteLine("######## KOMPOZYT #########");
            System.Console.WriteLine("");
            System.Console.WriteLine("");
           GroupOfPeople Mateusz = new GroupOfPeople("Mateusz", 22);
           Hobbies car = new Hobbies("MotorSport");
           GroupOfPeople Milosz = new GroupOfPeople("Miłosz", 19);
           Hobbies sport = new Hobbies("Dancing");

           Kompozyt s = new Kompozyt();
            s.Add(Mateusz);s.Add(car);
            s.Add(Milosz); s.Add(sport);    
            s.ShowData();

        //Działanie dekoratora 
            System.Console.WriteLine("######## DEKORATOR #########");
            System.Console.WriteLine("");
            
            IHamburger animal = new AnimalStyleBurger();
            animal = new CheeseDecorator(animal);
            animal = new MeatDecorator(animal); 
            System.Console.WriteLine(animal.GetName());
            System.Console.WriteLine(animal.CalculateCost()+" zł");
            
            IHamburger WrongVeggie = new VeggieBurger();
            WrongVeggie = new BeconDecorator(WrongVeggie);
            WrongVeggie = new MeatDecorator(WrongVeggie);
            System.Console.WriteLine(WrongVeggie.GetName());
            System.Console.WriteLine(WrongVeggie.CalculateCost()+" zł");



        }
    }
}
