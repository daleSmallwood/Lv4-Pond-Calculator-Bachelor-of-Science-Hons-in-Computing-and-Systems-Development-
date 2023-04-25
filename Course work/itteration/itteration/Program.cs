using System;

namespace itteration
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int convertedInput = Convert.ToInt32(input);
            for(int i =0; i <= 100; i = i + convertedInput)
            {
                Console.WriteLine(i);
            }  
            


            Console.WriteLine ("hello please type what shape you would like to calculate ");
            Console.WriteLine("1 Square");
            Console.WriteLine("2 Rectangle");
            Console.WriteLine("3 Circle");
            Console.WriteLine("4 Cube");
            Console.WriteLine("5 Cylinder");
            Console.WriteLine("6 sphere");


            {

            }
        }
    }
}
