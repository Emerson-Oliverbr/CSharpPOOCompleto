using System;
using System.Globalization;
using System.Xml;

namespace MediaAluno
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Aluno aluno = new Aluno();

            Console.Write("Nome do aluno: ");
            aluno.Nome = Console.ReadLine();
            Console.WriteLine("Digite as três notas do aluno: ");
            aluno.NotaTrimestre1 = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            aluno.NotaTrimentre2 = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            aluno.NotaTrimestre3 = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.WriteLine("NOTA FINAL = " + aluno.notaFinal().ToString("F2",CultureInfo.InvariantCulture));

            if(aluno.Aprovado())
            {
                Console.WriteLine("APROVADO");
            } else
            {
                Console.WriteLine("REPROVADO");
                Console.WriteLine($"FALTARAM {aluno.NotaRestante().ToString("F2",CultureInfo.InvariantCulture)}");
            }
            
        }
    }
}