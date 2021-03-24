using System;

namespace Soma_de_numeros
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite dois números!");

            int N1 = int.Parse(Console.ReadLine());
            int N2 = int.Parse(Console.ReadLine());

            int soma = N1 + N2;

            Console.WriteLine("A soma dos numeros é: " + soma);
        }
    }
}
