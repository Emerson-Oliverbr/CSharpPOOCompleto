using System;
using System.Globalization;

namespace MeuApp
{
    internal class Program
    {
        static double pi = 3.14;
        static void Main(string[] args)
        {
            Console.Write("Entre com o valor do raio: ");
            double raio = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            double circ = Circuferencia(raio);
            double volume = Volume(raio);

            Console.WriteLine($"Circuferência = {circ.ToString("F2",CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Volume =  {volume.ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Valor de pi =  {pi.ToString("F2", CultureInfo.InvariantCulture)}");
        }

        static double Circuferencia(double raio)
        {
            return 2.0 * pi * raio;
        }

        static double Volume(double raio)
        {
            return 4.0 / 3.0 * pi * Math.Pow(raio, 3);
        }
    }
}