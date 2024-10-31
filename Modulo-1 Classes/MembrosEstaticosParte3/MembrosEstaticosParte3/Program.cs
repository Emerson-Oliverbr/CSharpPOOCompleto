using System;
using System.Globalization;

namespace MembrosEstaticosParte3;

internal class Program
{

    static void Main(string[] args)
    {
        Console.Write("Entre com o valor do raio: ");
        double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        double circ = Calculadora.Circuferencia(raio);
        double volume = Calculadora.Volume(raio);

        Console.WriteLine($"Circuferência = {circ.ToString("F2", CultureInfo.InvariantCulture)}");
        Console.WriteLine($"Volume =  {volume.ToString("F2", CultureInfo.InvariantCulture)}");
        Console.WriteLine($"Valor de pi =  {Calculadora.pi.ToString("F2", CultureInfo.InvariantCulture)}");
    }
}