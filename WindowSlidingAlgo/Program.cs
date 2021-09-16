using System;
using System.Collections.Generic;

namespace Tasks
{
    class Program
    {

        /*
         
         I pasted my code here since I could not find which repository link I had to paste to "Text Reply".
         
         Please run this code in Visual Studio. You will see instructions in the console as You proceed.

         
         */
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of cars (n):");
            var allCarsAmount = Convert.ToInt64(Console.ReadLine());

            Console.WriteLine("Enter the number of cars to be covered by roof (k):");
            var carsCoveredAmount = Convert.ToInt64(Console.ReadLine());


            var cars = new List<long>();

            Console.WriteLine("Enter car values (array values) :");

            for (int i = 0; i < allCarsAmount; i++)
            {
                cars.Add(Convert.ToInt64(Console.ReadLine()));
            }

            Console.WriteLine(allCarsAmount + " cars have been entered.");

            Console.WriteLine("Answer is " + carParkingRoof(cars.ToArray(), carsCoveredAmount) + ".");


        }


        public static long carParkingRoof(long[] cars, long k)
        {
            if (cars.Length <= 0 || k < 1)
            {
                return 0;
            }

            Array.Sort(cars);
            var x = long.MaxValue;

            for (int i = 0; i < cars.Length - k; i++)
            {
                x = Math.Min(x, cars[i + k - 1] - cars[i]);
            }
            return x + 1;
        }
    }
}
