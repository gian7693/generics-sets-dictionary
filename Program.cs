using System;
using System.Globalization;
using Course.Entities;
using Course.Services;

namespace Course // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();

            Console.Write("Enter N: ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                double price = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                list.Add(new Product(name, price));

            }

            CalculationService calculationService = new CalculationService();

            Product max = calculationService.Max(list);

            Console.WriteLine($"Max: {max}");
        }
    }
}