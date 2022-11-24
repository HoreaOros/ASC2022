using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace BigInt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BigInteger b1 = new BigInteger(123456);
            BigInteger b2 = BigInteger.Parse("12345678912345678345678234567234567234563456");
            BigInteger b3 = BigInteger.Parse("3456783456723456734567234562345");

            Console.WriteLine($"{b1}{Environment.NewLine}{b2}{Environment.NewLine}{b3}{Environment.NewLine}");

            BigInteger b4 = b2 + b3;
            BigInteger b5 = b2 << 1; // echivalent cu inmultirea cu 2

            Console.WriteLine($"{b2}{Environment.NewLine}{b5}{Environment.NewLine}");

            byte[] bytes = { 5, 4, 3, 2, 1 };
            BigInteger number = new BigInteger(bytes);
            Console.WriteLine("The value of number is {0} (or 0x{0:x}).", number);

            if (b2 > b3)
            {
                Console.WriteLine($"b2 este mai mare decat b3");
            }
            Console.WriteLine($"b2*b3 = {b2 * b3}");
        }
    }
}
