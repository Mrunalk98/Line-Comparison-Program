using System;

namespace LineComparison
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Line Comparison Computation Program");

            Console.WriteLine("Enter coordinates of point 1 (x1 and y1)");
            var x1 = Convert.ToDouble(Console.ReadLine());
            var y1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter coordinates  of point 2 (x and y2)");
            var x2 = Convert.ToDouble(Console.ReadLine());
            var y2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Length of line : " + LengthCalculation(x1, x2, y1, y2));

        }

        // Use Case 1
        static double LengthCalculation(double x1, double x2, double y1, double y2)
        {
            
            double length;

            double val1 = Math.Pow((x2 - x1), 2);
            double val2 = Math.Pow((y2 - y1), 2);
            length = Math.Sqrt(val1 + val2);

            return length;

        }
    }
}
