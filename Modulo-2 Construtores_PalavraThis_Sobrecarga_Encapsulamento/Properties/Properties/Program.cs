using System;
using System.Globalization;

namespace Properties
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Produto produto = new Produto("TV", 500.00, 10);

            produto.Nome = "TV-4K";

            Console.WriteLine($"Nome: {produto.Nome}");
            Console.WriteLine($"Preço: {produto.Preco}");

            Console.ReadKey();
        }
    }
}