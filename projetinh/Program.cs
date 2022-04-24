using System;

namespace _01.Decimal_to_Binary
{
    class DecimalToBinary
    {
        static void Main(string[] args)
        {
            int decimalNumber;
            string value = string.Empty;
            int remainter;

            Console.Write("digit a decimal:");
            decimalNumber = int.Parse(Console.ReadLine());

            while(decimalNumber > 0)
            {
                remainter = decimalNumber % 2;
                decimalNumber /= 2;
                value = remainter.ToString() + value;
                Console.Write(value);
            }
            Console.ReadLine();
        }
    }
}
