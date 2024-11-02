using System;
using System.Globalization;

namespace ProdutosEmEstoque
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com os dados do produto: ");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            Produto produto = new Produto(nome, preco);
            //Produto produto2 = new Produto();

            Produto produto3 = new Produto() { Nome = "TV", Preco = 500.00, Quantidade = 5 };

            Console.WriteLine($"Dados do Produto: {produto3}");
            Console.Write("Informe a quantidade de Produtos a serem adicionadas ao estoque: ");
            int qtde = int.Parse(Console.ReadLine());
            produto3.AdicionarProdutos(qtde);
            Console.WriteLine($"Dados Atualizados: {produto3}");
            Console.Write("Informe a quantidade de Produtos a serem removidas ao estoque: ");
            qtde = int.Parse(Console.ReadLine());
            produto3.RemoverProdutos(qtde);
            Console.WriteLine($"Dados Atualizados: {produto3}");

            Console.ReadKey();
        }
    }
}