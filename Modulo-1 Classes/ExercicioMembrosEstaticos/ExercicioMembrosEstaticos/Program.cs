using System;
using System.Globalization;

namespace ExercicioMembrosEstaticos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qual é a cotação do dólar? ");
            double cotacaoDolar = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            Console.Write("Quantos dolares voce vai comprar? ");
            double quantidadeDeDolar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double resultado = ConversorDeMoeda.ConvertDolarParaReal(quantidadeDeDolar, cotacaoDolar);

            Console.WriteLine($"Valor em R$ {resultado.ToString("F2",CultureInfo.InvariantCulture)}");
        }
    }
}