using System;
using System.Globalization;

namespace CalculadoraSalario
{
    internal class Funcionario
    {
        public string Nome;
        public double SalarioBruto;
        public double imposto;

        public double SalarioLiquido()
        {
            return SalarioBruto - imposto;
        }
        public void AumentarSalario(double porcentagem)
        {
            SalarioBruto = SalarioBruto + (SalarioBruto * porcentagem / 100.0);
        }

        public override string ToString()
        {
            return $"Funcionario: {Nome}, R$ {SalarioLiquido().ToString("F2",CultureInfo.InvariantCulture)}";
        }
    }
}
