namespace Problem346
{
    internal class Program
    {
        public static bool ValidateNumberIsBetween(int x1, int x2)
        {
            Console.Write("Enter input: ");
            int value;
            bool isInteger = int.TryParse(Console.ReadLine(), out value);

            if (isInteger && value >= x1 && value <= x2)
            {
                return true;
            }
            return false;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter x1: ");
            int x1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter x2: ");
            int x2 = int.Parse(Console.ReadLine());

            Console.WriteLine("The number belongs to [{0},{1}]: {2}", x1, x2, ValidateNumberIsBetween(x1, x2));
        }
    }
}