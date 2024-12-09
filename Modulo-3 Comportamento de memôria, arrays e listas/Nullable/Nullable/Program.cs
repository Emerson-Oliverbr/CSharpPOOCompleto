using System;

namespace Nullable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Nullable<double> x = null;
            double? y = null;
            double? z = 10.0;

            Console.WriteLine(x.GetValueOrDefault());
            /*Retorna valor de x caso não exista nesse caso "null"
              retorna o valor padrão so tipo da variavel no caso de double 0 
             */

            Console.WriteLine(x.GetValueOrDefault());
            Console.WriteLine(y.GetValueOrDefault());
            Console.WriteLine(z.GetValueOrDefault());
            Console.WriteLine();
            Console.WriteLine(x.HasValue);
            Console.WriteLine(y.HasValue);
            Console.WriteLine(z.HasValue);
            Console.WriteLine();
            if (x.HasValue)
            {
                Console.WriteLine(x.Value);                
            }
            else
            {
                Console.WriteLine($"X é nulo");
            }
        }
    }
}