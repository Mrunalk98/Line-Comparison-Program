
using System;

namespace LineComparison
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Line Comparison Computation Program");

            LengthComputation lenComputation = new LengthComputation();

            for (int i = 1; i <= 2; i++)
            {
                Console.WriteLine("Enter points of line " + i + " :");
                Console.WriteLine("Enter coordinates of point 1 (x1 and y1)");
                var x1 = Convert.ToDouble(Console.ReadLine());
                var y1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Enter coordinates  of point 2 (x and y2)");
                var x2 = Convert.ToDouble(Console.ReadLine());
                var y2 = Convert.ToDouble(Console.ReadLine());

                lenComputation.LengthCalculation(x1, x2, y1, y2, i);

            }
            lenComputation.CompareLengths();

        }
    }
}
