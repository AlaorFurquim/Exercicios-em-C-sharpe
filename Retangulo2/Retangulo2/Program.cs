using System;
using System.Globalization;

namespace Retangulo2
{
    class Program
    {
        static void Main(string[] args)

        {
            Retangulo ret = new Retangulo();

            Console.WriteLine("Entre com os valores");
            ret.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            ret.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Area: " + ret.Area().ToString("f2"),CultureInfo.InvariantCulture);
            Console.WriteLine("Perimetro: " + ret.Perimetro().ToString("f2"),CultureInfo.InvariantCulture);
            Console.WriteLine("Diagonal: " + ret.Diagonal().ToString("f2"),CultureInfo.InvariantCulture);


        }
    }
}
