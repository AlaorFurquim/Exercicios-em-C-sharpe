using System;

namespace Diferenca_dos_produtos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite 4 produtos!");

            double A = double.Parse(Console.ReadLine());
            double B = double.Parse(Console.ReadLine());
            double C = double.Parse(Console.ReadLine());
            double D = double.Parse(Console.ReadLine());

            double Dif = (A * B - C * D);

            Console.WriteLine("A diferença dos produtos é: " + Dif);



        }
    }
}
