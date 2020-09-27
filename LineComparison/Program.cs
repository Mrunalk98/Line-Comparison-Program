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
            CompareLengths();

        }

        // Use Case 3
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

        static void CompareLengths()
        {
            var val = len1.CompareTo(len2);
            if (val == 0)
            {
                Console.WriteLine("The two lines are equal");
            } 
            else if (val == 1)
            {
                Console.WriteLine("Line 1 is greater than Line 2");
            }
            else if (val == -1)
            {
                Console.WriteLine("Line 1 is less than Line 2");
            }
        }
    }
}
