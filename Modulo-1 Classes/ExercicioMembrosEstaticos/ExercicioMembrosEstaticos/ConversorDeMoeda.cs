
namespace ExercicioMembrosEstaticos
{
    internal class ConversorDeMoeda
    {
        public static double iof = 6.0;

        public static double ConvertDolarParaReal(double quantidade, double cotacao)
        {
            double total = quantidade * cotacao;
            return total + total * iof / 100.00;
        }
    }
}
