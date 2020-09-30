using System;

namespace LineComparisionProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Line Comparison Computation Program");
            Console.WriteLine("Line 1");
            double lengthOfLine1 = lengthOfLine();
            Console.WriteLine("Length of line 1: " + lengthOfLine1);
            Console.WriteLine("Line 2");
            double lengthOfLine2 = lengthOfLine();
            Console.WriteLine("Length of line 2: " + lengthOfLine2);
            if (lengthOfLine1.CompareTo(lengthOfLine2) == 0)
                Console.WriteLine("Line 1 & Line 2 are equal");
            else if (lengthOfLine1.CompareTo(lengthOfLine2) < 0)
                Console.WriteLine("Line 1 is smaller than Line 2");
            else
                Console.WriteLine("Line 1 is greater than Line 2");
        }
        static double lengthOfLine()
        {
            Console.WriteLine("Enter the X & Y coordinates of P1 (starting point)");
            double X1 = double.Parse(Console.ReadLine());
            double Y1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the X & Y coordinates of P2 (ending point)");
            double X2 = double.Parse(Console.ReadLine());
            double Y2 = double.Parse(Console.ReadLine());

            //formula to calculate the line length
            double length = Math.Sqrt(Math.Pow((X2 - X1), 2) + Math.Pow((Y2 - Y1), 2));
            return length;
        }
    }
}