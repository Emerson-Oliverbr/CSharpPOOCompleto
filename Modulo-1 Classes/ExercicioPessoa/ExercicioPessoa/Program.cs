using System;

namespace ExercicioPessoa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoa = new Pessoa();

            Console.WriteLine("Dados da primeira pessoa: ");
            Console.Write("Mome: ");
            pessoa.Nome = Console.ReadLine();
            Console.Write("Idade: " );
            pessoa.Idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados da segunda pessoa: ");
            Pessoa pessoa2 = new Pessoa();
            Console.Write("Mome: ");
            pessoa2.Nome = Console.ReadLine();
            Console.Write("Idade: ");
            pessoa2.Idade = int.Parse(Console.ReadLine());

            if(pessoa.Idade > pessoa2.Idade)
            {
                Console.WriteLine($"Pessoa mais velha: {pessoa.Nome}");
            } else
            {
                Console.WriteLine($"Pessoa mais velha: {pessoa2.Nome}");
            }
        }
    }
}