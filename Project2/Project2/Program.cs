using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pad = 8;
            
            string set = "abcdefgh";
            for (int i = 0; i < 256; i++)
            {
                ShowPad(i, pad, set);
            }
        }

        private static void ShowPad(int i, int pad, string set)
        {
            Stack<int> stack = new Stack<int>();
            while (i > 0)
            {
                stack.Push(i % 2);
                i = i / 2;
            }
            int z;
            z = pad - stack.Count;

            while(z > 0)
            {
                stack.Push(0);
                z--;
            }

            //while (stack.Count > 0)
            //{
            //    Console.Write(stack.Pop());
            //}
            //Console.WriteLine();


            for (int j = 0; j < pad; j++)
            {
                if (stack.Pop() == 1)
                {
                    Console.Write(set[j]);
                }
            }
            Console.WriteLine();
        }
    }
}
