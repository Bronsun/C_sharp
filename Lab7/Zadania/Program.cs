using System;

namespace Zadania
{
    class Program
    {
        static void Main(string[] args)
        {
           TouristAtrraction schonbrunn = new TouristAtrraction("Schonbrunn");

            schonbrunn.Execute();
        VisitCommand museum = new VisitCommand(11,"museum");
            museum.Execute();

        }
    }
}
