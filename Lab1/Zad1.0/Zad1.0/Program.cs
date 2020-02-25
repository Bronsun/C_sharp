using System;

namespace Zad1._0
{
    class Program
    {
        static void Main(string[] args)
        {
            // Fun with the basics
            int num1 = 1;
            int num2 = 2;
            int sum = num1 + num2;
            int sub = num1 - num2;
            int div = num2 / num1;
            int ilo = num2 * num1 * 5;
            string name = "Mateusz";
            double age = 21.5;

            Console.WriteLine("Sum: "+ sum);
            Console.WriteLine("Sub: "+ sub);
            Console.WriteLine("Div: "+ div);
            Console.WriteLine("Ilo: "+ ilo);
            Console.WriteLine("Name and age: " + " " + name +" "+ age);






            // All Prime numbers from 1 to 100
            Console.WriteLine("All Prime Numebrs from 1-100: ");
            for(int i = 2; i <= 100; i++)
            {
               if(IsPrime(i)==true)
                {
                    Console.WriteLine(i + " ");
                }
               else { continue; }
            }
            Console.WriteLine();
           // Console.ReadKey();



            // Factorial number

            int f;
            Console.WriteLine("Type in number");
            f = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("FactorialNumber" + "(" + PrintFactorial(f) + ")");













        }











        static double Pythagoras(double a, double b)
        {
            double result; 
            result = Math.Sqrt(a * a + b * b);
            return result; 
        }



        static bool IsPrime(int a)
        {
            for(int i = 2; i<a; i++)
            {
                if (a%i == 0)
                {
                    return false;
                }

            }
            return true;
        }

        static int PrintFactorial(int b)
        {
            if (b < 0)
            {
                Console.WriteLine("You cannot do factorial from negative number, try again");
                return 0;
            }
            else if (b == 0 || b == 1)
            {
                return 1;
            }
            else
                return b * PrintFactorial(b - 1);
        }

    


    }
}
