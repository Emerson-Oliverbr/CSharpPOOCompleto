using System;
using System.Globalization;

namespace Encapsulamento
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Produto produto = new Produto("TV", 500.00, 10);

            Console.WriteLine($"Nome = {produto.GetNome()}");
            produto.SetNome("Notebook");
            Console.WriteLine($"Nome = {produto.GetNome()}");
            Console.WriteLine($"Preco = {produto.GetPreco()}");
            Console.WriteLine($"Quantidade = {produto.GetQuantidade()}");

            Console.ReadKey();
        }
    }
}