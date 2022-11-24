using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overflow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;

            a = 2000000000;
            b = 2000000000;
            try
            {
                checked
                {
                    c = a + b;
                    Console.WriteLine(c);
                }
            }
            catch (OverflowException e)
            {
                Console.WriteLine(e.Message);
            }
            
            
            
        }
    }
}
