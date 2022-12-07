using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace MyBigInteger
{
    internal class Program
    {
		static void Main(string[] args)
		{
			/*try
			{
				BigInt b1 = new BigInt("1234512345623456234562345");
				BigInt b2 = new BigInt("567896675656786789678");
				BigInt sum = b1 + b2;
				Console.WriteLine($"{b1} + {b2} = {sum}");
			//}
			catch (Exception e)
			{
				Console.WriteLine(e.Message);
			}*/
			// TODO
			// implementati stocarea unui numar mare sub forma de lista de octeti
			// {1, 2, 3, 4, 5, 255 } =>> 00000101 00000100 00000011 00000010 00000001+
			// {1, 2, 4, 8, 16, 1} =>> 00010000 00001000 00000100 00000010 00000001
			// ------------------------------------------------------------------
			// {2, 4, 7, 12, 21, 0, 1}==>>                                    00000010  
			// {1, 2, 3, 4, 5} ==>> 1*256^0+2*256^1 +3*256^2+... 
			BigInteger b = new BigInteger(1234543212345654321);
			P1(b);
        }
		private static void P1(BigInteger b)
		{
			int nr = 0;
			BigInteger cb = b;
			while (cb > 0)
			{
				nr++;
				cb = cb/256;	
			}
			int[] v=new int[nr];
			int j = 0;
			while (b > 0)
			{
				v[j] =(int)( b % 256);
				b=b/256;
				j++;	
			}
			Console.Write("{");
			for(j = 0; j < v.Length-1; j++)
			{
				Console.Write(v[j]+",");
			}
			Console.Write(v[j]);
			Console.Write("}");
			Console.WriteLine();
			List<string> t=new List<string>();
			for(int i = 0; i < v.Length; i++)
			{
				int nrd = 0;
				string k=string.Empty;
				while (nrd < 8)
				{
					k =k+ Convert.ToString(v[i] % 2);
					v[i] = v[i]/2;
					nrd++;
				}
				string reverse = string.Empty;
				for(int l = k.Length-1; l >= 0; l--)
				{
					reverse = reverse + k[l];
				}
				t.Add(reverse);
			}
			for(int i = 0; i < t.Count; i++)
			{
				Console.Write(t[i] + " ");
			}
			Console.ReadKey();
		}
	}
}
