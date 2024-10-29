using System;
using System.Globalization;

namespace CalculadoraSalario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Funcionario funcionario = new Funcionario();

            Console.Write("Nome: ");
            funcionario.Nome = Console.ReadLine();
            Console.Write("Salario Bruto: ");
            funcionario.SalarioBruto = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.Write("Imposto: ");
            funcionario.imposto = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.WriteLine($"Funcionario: {funcionario}");
            Console.Write("Digite a porcentagem para aumentar o salário: ");
            double reajusteSalarial = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            funcionario.AumentarSalario(reajusteSalarial);
            Console.WriteLine($"Dados Atualizados: {funcionario}");

        }
    }
}