using System;

namespace Zadania
{
	interface IWeatherAlert
    {
        string CurrentDate { get; set; }
        void Alert();
    }

    class NoAlert : IWeatherAlert
    {
        public string CurrentDate { get; set; }
        public void Alert() { }
    }
    class RainAlert : IWeatherAlert
    {
        public string CurrentDate { get; set; }
        public void Alert()
        {
            Console.WriteLine("Today expexted: rain");
        }
    }
    class FogAlert : IWeatherAlert{
        public string CurrentDate{get;set;}
        public void Alert(){
            System.Console.WriteLine("Today expexted: fog");
        }
    }
}