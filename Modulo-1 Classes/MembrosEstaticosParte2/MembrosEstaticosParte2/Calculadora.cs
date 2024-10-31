namespace MembrosEstaticosParte2
{
    internal class Calculadora
    {
        public double pi = 3.14;
        public double Circuferencia(double raio)
        {
            return 2.0 * pi * raio;
        }
        public double Volume(double raio)
        {
            return 4.0 / 3.0 * pi * Math.Pow(raio, 3);
        }
    }
}
