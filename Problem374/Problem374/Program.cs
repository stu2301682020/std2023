namespace Problem374
{
    internal class Program
    {
        public static int CalculateSumOfNonZeroNumbers()
        {
            Console.WriteLine("Enter a random number k:");
            Console.ReadLine();

            int number;
            int sum = 0;
            do
            {
                Console.WriteLine("Enter a random number, or zero for exit: ");
                string input = Console.ReadLine();
                number = int.Parse(input);
                sum += number;
            } while (number != 0);

            Console.WriteLine("Sum is: {0}", sum);
            return sum;
        }

        public static void CalculateProductOfNumbersBetweenTwoAndTwelve()
        {
            Console.WriteLine("Enter ten numbers: ");
            int product = 1;
            for (int i = 0; i < 9; i++)
            {
                Console.WriteLine("Enter number {0}: ", i + 1);
                string input = Console.ReadLine();

                int number = int.Parse(input);
                if (number >= 2 && number <= 12)
                {
                    product *= number;
                }
            }
            Console.WriteLine("The Product is: {0}", product);
        }

        public static int Sum(int k)
        {
            Random random = new Random();
            int sum = 0;

            for (int i = 0; i < k; i++)
            {
                int randomNumber = random.Next(0, 100);
                if (IsEven(randomNumber))
                {
                    sum += randomNumber;
                }
            }

            Console.WriteLine("Sum: {0}", sum);
            return sum;
        }

        private static bool IsEven(int number)
        {
            return number % 2 == 0;
        }

        static void Main(string[] args)
        {
            CalculateSumOfNonZeroNumbers();

            CalculateProductOfNumbersBetweenTwoAndTwelve();

            Console.Write("Enter the first positive number a=");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Enter the second positive number b=");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Enter the third positive number c=");
            int c = int.Parse(Console.ReadLine());

            Console.WriteLine("Sum(a*b) + Sum(c) is: {0}", Sum(a * b) + Sum(c));
        }
    }
}