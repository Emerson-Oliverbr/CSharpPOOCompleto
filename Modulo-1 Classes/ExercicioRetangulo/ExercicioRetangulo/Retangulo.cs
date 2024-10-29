using System;

namespace ExercicioRetangulo
{
    internal class Retangulo
    {
        public double Largura;
        public double Altura;

        public double AreaRetangulo()
        {
            return Largura * Altura;
        }

        public double PerimetroRetangulo()
        {
            return 2 * (Largura + Altura);
        }

        public double DiagonalRetangulo()
        {
            return Math.Sqrt(Largura * Largura + Altura * Altura);
        }
    }
}
