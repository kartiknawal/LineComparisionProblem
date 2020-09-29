using System;

namespace LineComparisionProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Line Comparison Computation Program");
            Console.WriteLine("Length of the line P1P2 is : " + lengthOfLine());
        }
        static double lengthOfLine()
        {
            Console.WriteLine("Enter the X & Y coordinates of P1");
            double X1 = double.Parse(Console.ReadLine());
            double Y1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the X & Y coordinates of P2");
            double X2 = double.Parse(Console.ReadLine());
            double Y2 = double.Parse(Console.ReadLine());

            //formula to calculate the line length
            double length = Math.Sqrt(Math.Pow((X2 - X1), 2) + Math.Pow((Y2 - Y1), 2));
            return length;
        }
    }
}