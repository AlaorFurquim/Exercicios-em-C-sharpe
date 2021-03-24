using System;

namespace Negativo_ou_positivo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número!");
            int Numero = int.Parse(Console.ReadLine());
            

            if (Numero >= 0)
            {
                Console.WriteLine("O número digitado é positivo!");
            } else
            {
                Console.WriteLine("O número digitado é negatio!");
            }
        }
    }
}
