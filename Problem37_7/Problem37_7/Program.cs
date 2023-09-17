namespace Problem37_7
{
    internal class Program
    {
        public static bool Expression(int d, int t, int s, int r, bool q, bool v)
        {
            return (d == t || d != t && s + d > 5 * r) && !(q || !v) || q && v;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Expression(1, 0, 0, 6, true, false));
        }
    }
}