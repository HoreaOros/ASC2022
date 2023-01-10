using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;


namespace ASMProgAoC2015_23
{
    internal class Program
    {
        static string filename = "input.txt";
        static List<string> instructions = new List<string>();
        static long a, b;
        static void Main(string[] args)
        {
            ReadData(filename);
            foreach (var item in instructions)
                Console.WriteLine(item);
            Solve(0, 0);
            Solve(1, 0);
        }

        private static void Solve(long a, long b)
        {
            Execute(instructions, a, ref b);
            Console.WriteLine(b);
        }

        private static void Execute(List<string> instructions, long a, ref long b)
        {
            int PC = 0; // Program Counter
            bool a_one = a == 1;
            bool a_even = a % 2 == 0;
            bool b_one = b == 1;
            bool b_even = b % 2 == 0;
            int offset;
            while(PC >= 0 && PC < instructions.Count)
            {
                //Console.WriteLine(instructions[PC]);
                string[] tokens = instructions[PC].Split(" ,".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                switch (tokens[0])
                {
                    case "hlf":
                        if (tokens[1] == "a")
                        {
                            a = a / 2;
                            a_one = a == 1;
                            a_even = a % 2 == 0;
                        }
                        else if (tokens[1] == "b")
                            b = b / 2;
                        PC++;
                        break;
                    case "tpl":
                        if (tokens[1] == "a")
                        {
                            a = a * 3;
                            a_one = a == 1;
                            a_even = a % 2 == 0;
                        }
                        else if (tokens[1] == "b")
                            b = b * 3;
                        PC++;
                        break;
                    case "inc":
                        if (tokens[1] == "a")
                        {
                            a++;
                            a_one = a == 1;
                            a_even = a % 2 == 0;
                        }
                        else if (tokens[1] == "b")
                            b++;
                        PC++;
                        break;
                    case "jmp":
                        offset = int.Parse(tokens[1]);
                        PC = PC + offset;
                        break;
                    case "jie":
                        offset = int.Parse(tokens[2]);
                        if (tokens[1] == "a")
                            if (a_even)
                                PC = PC + offset;
                            else
                                PC++;
                        break;
                    case "jio":
                        offset = int.Parse(tokens[2]);
                        if (tokens[1] == "a")
                            if (a_one)
                                PC = PC + offset;
                            else
                                PC++;
                        break;
                    default:
                        break;
                }
            }
        }

        private static void ReadData(string filename)
        {
            StreamReader sr = new StreamReader(filename);
            string line;
            while (true)
            {
                line = sr.ReadLine();
                if (line == null)
                    break;
                instructions.Add(line);
            }
        }
    }
}
