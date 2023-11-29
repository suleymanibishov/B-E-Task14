using System;
using System.Threading;

namespace B_E_Task14
{
    class Program
    {
        static void Main(string[] args)
        {
            //PrintText(Console.ReadLine());
            PrintText("Salam");
        }

        static void PrintText(string text)
        {
            foreach (var letter in text)
            {
                Thread.Sleep(222);
                Console.Write(letter);
            }
            Console.WriteLine();
        }
    }
}
