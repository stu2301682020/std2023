namespace Project
{
    internal class Program
    {
        public static double CalculateArithmeticProgressionSum(double firstTerm, double commonDifference, int numberOfTerms)
        {
            double lastTerm = firstTerm + (numberOfTerms - 1) * commonDifference;

            return (firstTerm + lastTerm) * numberOfTerms / 2;
        }
        static void Main(string[] args)
        {
            Console.Write("Enter the first term: ");
            double firstTerm = double.Parse(Console.ReadLine());

            Console.Write("Enter the common difference: ");
            double commonDifference = double.Parse(Console.ReadLine());

            Console.Write("Enter the number of terms: ");
            int numberOfTerms = int.Parse(Console.ReadLine());

            Console.WriteLine(CalculateArithmeticProgressionSum(firstTerm, commonDifference, numberOfTerms));
        }
    }
}