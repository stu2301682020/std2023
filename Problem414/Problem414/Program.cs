namespace Problem414
{
    internal class Program
    {

        public static int[] ReadArray(int length)
        {
            Console.WriteLine("Enter {0} numbers: ", length);
            int[] numbers = new int[length];
            for (int i = 0; i < length; i++)
            {
                Console.Write("Enter number for index {0}: ", i);
                string input = Console.ReadLine();
                numbers[i] = int.Parse(input);
            }

            return numbers;
        }

        public static int CalculateSumOfOddNumbersBetweenZeroAndOneHundred(int[] numbers)
        {
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (IsOdd(numbers[i]) && IsBetweenZeroAndOneHundred(numbers[i]))
                {
                    sum += numbers[i];
                }
            }

            return sum;
        }

        private static bool IsOdd(int number)
        {
            return number % 2 != 0;
        }

        private static bool IsBetweenZeroAndOneHundred(int number)
        {
            return number > 0 && number <= 100;
        }

        public static void RecalculateArray(int[] a, int[] b, int[] c)
        {
            for (int i = 0; i < c.Length; i++)
            {
                c[i] = (int) (Math.Pow(a[i], (i + 1) * 2 - 1) * Math.Pow(b[i], 2 * (i + 1)));
            }
        }

        public static void PrintArray(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine("arr[{0}]={1}", i, a[i]);
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter n:");
            string input = Console.ReadLine();
            int n = int.Parse(input);

            Console.WriteLine("Enter array A:");
            int[] a = ReadArray(n);
            Console.WriteLine("Enter array B:");
            int[] b = ReadArray(n);
            Console.WriteLine("Enter array C:");
            int[] c = ReadArray(n);

            int sumOfA = CalculateSumOfOddNumbersBetweenZeroAndOneHundred(a);
            int sumOfB = CalculateSumOfOddNumbersBetweenZeroAndOneHundred(b);
            int sumOfC = CalculateSumOfOddNumbersBetweenZeroAndOneHundred(c);

            Console.WriteLine("Sum of A is: {0}", sumOfA);
            Console.WriteLine("Sum of B is: {0}", sumOfB);
            Console.WriteLine("Sum of C is: {0}", sumOfC);

            Console.WriteLine("Max sum is: {0}", new[] { sumOfA, sumOfB, sumOfC }.Max());

            RecalculateArray(a, b, c);

            PrintArray(c);
        }
    }
}