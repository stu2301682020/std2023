namespace NumeralSystemsCalculator
{
    internal class Program
    {
        static string ConvertDecimalToBinary(int decimalNumber)
        {
            string binaryValue = "";
            int remainder;

            while (decimalNumber > 0)
            {
                remainder = decimalNumber % 2;
                Console.WriteLine("{0, 5} : 2 | {1}", decimalNumber, remainder);
                decimalNumber /= 2;
                binaryValue = remainder.ToString() + binaryValue;
            }
            return binaryValue;
        }
        public static int ConvertBinaryToDecimal(string binaryString)
        {
            int decimalValue = 0;
            int power = 0;

            for (int i = binaryString.Length - 1; i >= 0; i--)
            {
                int digit = ConvertCharToInt(binaryString[i]);
                decimalValue += digit * (int)Math.Pow(2, power);
                power++;
            }
            return decimalValue;
        }

        private static int ConvertCharToInt(char charValue)
        {
            return charValue - '0';
        }

        static int ConvertBinaryToOctal(string binary)
        {

            int padLength = 3 - binary.Length % 3;
            binary = new string('0', padLength) + binary;

            int numberOfGroups = binary.Length / 3;
            int octal = 0;

            for (int i = 0; i < numberOfGroups; i++)
            {
                string group = binary.Substring(i * 3, 3);
                int decimalValue = ConvertBinaryToDecimal(group);
                Console.WriteLine("{0} -> {1}", group, decimalValue);

                octal = octal * 10 + decimalValue;
            }
            return octal;
        }

        static string ConvertBinaryToHexadecimal(string binary)
        {

            int padLength = 4 - binary.Length % 4;
            binary = new string('0', padLength) + binary;

            int numberOfGroups = binary.Length / 4;
            char[] hexArray = new char[numberOfGroups];

            for (int i = 0; i < numberOfGroups; i++)
            {
                string group = binary.Substring(i * 4, 4);
                char hexValue = ConvertBinaryGroupToHex(group);
                Console.WriteLine("{0} -> {1}", group, hexValue);

                hexArray[i] = hexValue;
            }
            return new string(hexArray);
        }

        private static char ConvertBinaryGroupToHex(string binary)
        {
            int number = ConvertBinaryToDecimal(binary);

            if (number >= 0 && number <= 9)
            {
                return (char)('0' + number);
            }
            else
            {
                return (char)('A' + number - 10);
            }
        }

        static void Main(string[] args)
        {
            string binary = ConvertDecimalToBinary(2020);
            Console.WriteLine("{0} in Binary:  {1}", 2020, binary);

            int octal = ConvertBinaryToOctal(binary);
            Console.WriteLine("{0} in Octal:  {1}", 2020, octal);

            string hexadecimal = ConvertBinaryToHexadecimal(binary);
            Console.WriteLine("{0} in Hexadecimal:  {1}", 2020, hexadecimal);
        }
    }
}