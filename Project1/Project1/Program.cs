using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float eps = 0.001f;
            float suma = 0f;
            for (int i = 0; i < 1000000; i++)
            {
                suma += eps;
            }
            Console.WriteLine(suma);
        }
    }
}
