using System;

namespace Problem122
{
    internal class Program
    {
        public static double NaturalLogarithm(double x, double epsilon)
        {
            double lnX = 0;
            double n = 1;
            double term = (x - 1) / (x + 1);
            double currentTerm = term;

            while (Math.Abs(currentTerm) >= epsilon)
            {
                lnX += currentTerm;
                n += 2;
                currentTerm = Math.Pow(term, n) / n;
            }
            return 2 * lnX;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");
            int x = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter epsilon, preferably a number between 0 and 0,001: ");
            double epsilon = double.Parse(Console.ReadLine());

            Console.WriteLine("ln{0} is: {1}", x, Math.Log(x));
            Console.WriteLine("The calculated sum for ln{0} is: {1}", x, NaturalLogarithm(x, epsilon));
        }
    }
}