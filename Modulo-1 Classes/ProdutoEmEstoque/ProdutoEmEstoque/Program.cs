using System;
using System.Globalization;

namespace ProdutosEmEstoque
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Produto produto = new Produto();

            Console.WriteLine("Entre com os dados do produto: ");
            Console.Write("Nome: ");
            produto.Nome = Console.ReadLine();
            Console.Write("Preço: ");
            produto.Preco = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.Write("Quantidade: em Estoque: ");
            produto.Quantidade = int.Parse(Console.ReadLine());
            Console.WriteLine($"Dados do Produto: {produto}");
            Console.Write("Informe a quantidade de Produtos a serem adicionadas ao estoque: ");
            int qtde = int.Parse(Console.ReadLine());
            produto.AdicionarProdutos(qtde);
            Console.WriteLine($"Dados Atualizados: {produto}");
            Console.Write("Informe a quantidade de Produtos a serem removidas ao estoque: ");
            qtde = int.Parse(Console.ReadLine());
            produto.RemoverProdutos(qtde);
            Console.WriteLine($"Dados Atualizados: {produto}");
        }
    }
}