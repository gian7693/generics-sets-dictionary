using System;
using Course.Models;

namespace Course // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintService<String> printService = new PrintService<String>();

            Console.Write("How many values? ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 0; i < n; i++)
            {
                string value = Console.ReadLine();
                printService.AddValue(value);
            }

            printService.Print();
            Console.WriteLine("First: " + printService.First());
            
        }
    }
}