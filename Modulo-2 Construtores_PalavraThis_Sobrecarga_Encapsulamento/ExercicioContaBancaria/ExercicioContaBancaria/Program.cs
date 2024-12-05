using System;
using System.Globalization;

namespace ExercicioContaBancaria
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria conta;

            Console.Write("Informe o número da conta: ");
            int numero = int.Parse(Console.ReadLine());
            Console.Write("Informe o títular da conta: ");
            string? titular = Console.ReadLine();
            Console.Write("Haverá deposito inicial, (s/n)? ");
            char resposta = char.Parse(Console.ReadLine());
            if(resposta == 's' || resposta == 'S')
            {
                Console.Write("Qual sera o valor do deposito inicial? ");
                double depositoInicial = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

                conta = new ContaBancaria(numero, titular, depositoInicial);
            }
            else
            {
                conta = new ContaBancaria(numero, titular);
            }
            Console.WriteLine($"Dados da Conta:");
            Console.WriteLine($"{conta}");
            Console.WriteLine();
            Console.Write("Informe um valor para deposito: ");
            double quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Deposito(quantia);
            Console.WriteLine($"Dados da Conta atualizados:");
            Console.WriteLine($"{conta}");
            Console.WriteLine();
            Console.Write("Informe um valor para saque: ");
            quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Saque(quantia);
            Console.WriteLine($"Dados da Conta atualizados:");
            Console.WriteLine($"{conta}");
        }
    }
}