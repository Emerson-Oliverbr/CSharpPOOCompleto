using System;
using System.Globalization;

namespace VetoresParte1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double[] height = new double[n];
           
            for(int i=0; i<n; i++)
            {
                height[i] = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                
            }

            double sum = 0.0;
            for(int i=0; i<n; i++)
            {
                sum += height[i];
            }

            double averageHeight = sum / n;

            Console.WriteLine($"Altura media = {averageHeight.ToString("F2",CultureInfo.InvariantCulture)}");
        }
    }
}