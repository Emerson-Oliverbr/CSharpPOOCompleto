using System;
using System.Globalization;
using VetoresParte2;

namespace VetoresParte1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Product[] products = new Product[n];

            for(int index=0; index<n; index+=1)
            {
                string name = Console.ReadLine();
                double price = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                products[index] = new Product { Name = name, Price = price };
            }

            double sum = 0.0;

            for (int index = 0; index < n; index += 1)
            {
                sum += products[index].Price; 
            }

            double avg = sum / n;
            Console.WriteLine($"Preço medio = {avg.ToString("F2",CultureInfo.InvariantCulture)}");
        }
    }
}