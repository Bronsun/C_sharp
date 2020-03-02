using System;
using System.Collections.Generic;
namespace Zad2._0
{
    class Program
    {
        static void Main(string[] args)
        {

            //////Right Triangle/////////
            RightTriangle triangle = new RightTriangle();
            triangle.A = 2;
            triangle.B = 6; 
            Console.WriteLine(triangle.Circumference);
            //Console.WriteLine(triangle.ComputeSine);
            //Console.WriteLine(triangle.ComputeTangent);


            //////Album//////////
            Album album1 = new Album();
            album1.albumName = "Nothing Great About Britian";
            album1.artistName = "Slowthai";
            album1.date = 2019;
            album1.numberOfTracks = 12;

            Album album2 = new Album(){
                date = 1992,
                numberOfTracks = 2
            };

            Album album3 = new Album ("Golden Age", 1987);
            album1.ShowAlbumInfo();
            album2.ShowAlbumInfo();
            album3.ShowAlbumInfo();



              List <string> myList = new List<string>{
                "XDDDD",
                "LOLOLOLO",
                "elelelele",
                "memem",
            };
              int counter =0;  
            myList.Add("MAMA");
            myList.Insert(2,"TATA");
            Console.WriteLine(myList.IndexOf("TATA"));

            for(int i =0; i<myList.Count;++i){
                Console.WriteLine("Element "+i+" wynosi "+myList[i]);
            }

            foreach(string elems in myList){
                counter++;
                Console.WriteLine($"Element #{counter}: {elems}");
            }









        }

    }
}
