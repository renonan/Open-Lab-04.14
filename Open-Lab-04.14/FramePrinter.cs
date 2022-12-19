using System;
using System.Linq;

namespace Open_Lab_04._14
{
    public class FramePrinter
    {
        public void Print(string[] strings)
        {
        int max = 0;
        for (int i = 0; i < strings.Length; i++)
            {
                if (max < strings[i].Length)
                {
                    max = strings[i].Length;
                }
            }
            int width = max+4;
            Console.WriteLine(String.Concat(Enumerable.Repeat("*", width)));
            for (int i = 0; i < strings.Length; i++)
            {
                Console.Write("* ");
                Console.Write(strings[i]);
                for (int j = 0; j <max-strings[i].Length; j++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine(" *");
            }
            Console.WriteLine(String.Concat(Enumerable.Repeat("*", width)));

        }
    }
}