using System;
using System.Globalization;

namespace Calculando_todas_areas_do_triangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            double A, B, C;
            double Pi = 3.14;

            string[] valor = Console.ReadLine().Split(' ');

            A = double.Parse(valor[0],CultureInfo.InvariantCulture);
            B = double.Parse(valor[1], CultureInfo.InvariantCulture);
            C = double.Parse(valor[2], CultureInfo.InvariantCulture);

            double Area = (A * C) / 2; // Para calcular área do triângulo retângulo
            double Circ = C * C * Pi; // Para calcular V=a área do círculo de raio
            double Trape = (A + B) * C / 2; // Para calcular a área do trapézio
            double Quad = B * B; // Para calcular  a área do quadrado
            double Retan = A * B; // Para calcular  a área do retângulo
            Console.WriteLine("TRIANGULO: " + Area.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("CIRCULO: " + Circ.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("TRAPEZIO: " + Trape.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("QUADRADO: " + Quad.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("RETANGULO: " + Retan.ToString("F3", CultureInfo.InvariantCulture));


        }
    }
}
