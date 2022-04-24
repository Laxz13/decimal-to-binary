using System;

namespace _01.Decimal_to_Binary
{
    class DecimalToBinary
    {

        static void Main(string[] args)
        {
            int decimalNumber;
            string value = string.Empty;
            int solution;
            
            Intro();  // delete this

            Console.Write("digit a decimal:");
            decimalNumber = int.Parse(Console.ReadLine());

            while(decimalNumber > 0)
            {
                solution = decimalNumber % 2;
                decimalNumber /= 2;
                value = solution.ToString() + value;
                Console.Write(value);
            }
            Console.ReadLine();
        }
            //delete this
        private static void Intro()
        {
            Console.WriteLine("made by:");
            System.Threading.Thread.Sleep(1000);
            Console.Write('L');
            System.Threading.Thread.Sleep(500);
            Console.Write('a');
            System.Threading.Thread.Sleep(500);
            Console.Write('x');
            System.Threading.Thread.Sleep(500);

            Console.Write('z');
            Console.WriteLine();
            System.Threading.Thread.Sleep(500);
            Console.WriteLine("Press enter to continue:");
            Console.ReadLine();
            Console.Clear();
        }
           
    }
}
