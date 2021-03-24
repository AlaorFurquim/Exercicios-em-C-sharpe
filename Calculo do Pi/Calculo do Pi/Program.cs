using System;
using System.Globalization;

namespace Calculo_do_Pi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o valor do raio!");

            double Raio = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            double Pi = 3.14;

            double area = Pi * (Raio * Raio);

            Console.WriteLine("Valor da area é: " + area.ToString("f4"),CultureInfo.InvariantCulture);
        }
    }
}
