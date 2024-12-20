﻿using System;
using System.Globalization;

namespace MembrosEstaticosParte2;

internal class Program
{
    
    static void Main(string[] args)
    {
        Calculadora calc = new Calculadora();

        Console.Write("Entre com o valor do raio: ");
        double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        double circ = calc.Circuferencia(raio);
        double volume = calc.Volume(raio);

        Console.WriteLine($"Circuferência = {circ.ToString("F2", CultureInfo.InvariantCulture)}");
        Console.WriteLine($"Volume =  {volume.ToString("F2", CultureInfo.InvariantCulture)}");
        Console.WriteLine($"Valor de pi =  {calc.pi.ToString("F2", CultureInfo.InvariantCulture)}");
    }       
}