using System;

namespace LineComparison
{
    class Program
    {
        public static double len1;
        public static double len2;

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Line Comparison Computation Program");

            for (int i=1; i<=2; i++)
            {
                Console.WriteLine("Enter points of line " + i + " :");
                Console.WriteLine("Enter coordinates of point 1 (x1 and y1)");
                var x1 = Convert.ToDouble(Console.ReadLine());
                var y1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Enter coordinates  of point 2 (x and y2)");
                var x2 = Convert.ToDouble(Console.ReadLine());
                var y2 = Convert.ToDouble(Console.ReadLine());

                LengthCalculation(x1, x2, y1, y2, i);

            }
            CheckEquality();

        }

        // Use Case 1
        static void LengthCalculation(double x1, double x2, double y1, double y2, int index)
        {
            
            double length;

            double val1 = Math.Pow((x2 - x1), 2);
            double val2 = Math.Pow((y2 - y1), 2);
            length = Math.Sqrt(val1 + val2);

            if (index == 1)
            {
                len1 = length;
                
            }
            else
            {
                len2 = length;
            }
            Console.WriteLine("Length of line " + index + " : " + length + "\n");

        }

        static void CheckEquality()
        {
            if (len1.Equals(len2))
            {
                Console.WriteLine("The two lines are equal");
            }
            else
            {
                Console.WriteLine("The two lines are not equal");
            }
        }
    }
}
