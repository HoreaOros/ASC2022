using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1213
{
    internal class Program
    {
        static void Main(string[] args)
        {
            uint a = 0b1001_0101_1100_0000_0101;
            Console.WriteLine($"{Convert.ToString(a, toBase: 2).PadLeft(32, '0'), 32}");
            Console.WriteLine($"{a.GetBit(3)}");

            a = a.SetBit(3);
            Console.WriteLine($"{Convert.ToString(a, toBase: 2).PadLeft(32, '0'),32}");
            Console.WriteLine($"{a.GetBit(3)}");

            a = a.ResetBit(3);
            Console.WriteLine($"{Convert.ToString(a, toBase: 2).PadLeft(32, '0'),32}");
            Console.WriteLine($"{a.GetBit(3)}");


            uint m = 2587, k = 3658, c, r;
            c = m ^ k;
            r = c ^ k;
            Console.WriteLine($"r = {r}");
        }
    }
}
