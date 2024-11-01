﻿using System;
using System.Globalization;

namespace ExercicioRetangulo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Retangulo retangulo = new Retangulo();

            Console.WriteLine("Entre a largura e altura do retângulo: ");
            retangulo.Altura = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            retangulo.Largura = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.WriteLine($"AREA = {retangulo.AreaRetangulo().ToString("F2",CultureInfo.InvariantCulture)}");
            Console.WriteLine($"PERIMETRO = {retangulo.PerimetroRetangulo().ToString("F2",CultureInfo.InvariantCulture)}");
            Console.WriteLine($"DIAGONAL = {retangulo.DiagonalRetangulo().ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}