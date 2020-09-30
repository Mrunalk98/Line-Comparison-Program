using System;
using System.Collections.Generic;
using System.Text;

namespace LineComparison
{
    public interface ILineComputation
    {
        public void CompareLengths();
    }
    class LengthComputation : ILineComputation
    {
        public double len1;
        public double len2;

        public void LengthCalculation(double x1, double x2, double y1, double y2, int index)
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

        public void CompareLengths()
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

