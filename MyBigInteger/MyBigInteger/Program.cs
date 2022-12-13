using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBigInteger
{
    internal class Program
    {
        static void Main(string[] args)
        {
			try
			{
				BigInt b1 = new BigInt("1234512345623456234562345");
				BigInt b2 = new BigInt("567896675656786789678");
                BigInt sum = b1 + b2;
				Console.WriteLine($"{b1} + {b2} = {sum}");
            }
			catch (Exception e)
			{
				Console.WriteLine(e.Message);
			}
			// TODO
			// implementati stocarea unui numar mare sub forma de lista de octeti
			// {1, 2, 3, 4, 5} =>> 00000101 00000100 00000011 00000010 00000001+
			// {1, 2, 4, 8, 16, 1} =>> 00010000 00001000 00000100 00000010 00000001
			// ------------------------------------------------------------------
			// {2, 4, 7, 12, 21, 0, 1}==>>                                    00000010  
			// {1, 2, 3, 4, 5} ==>> 1*256^0+2*256^1 +3*256^2+... 

			
        }
    }
}
