using System;

namespace Soma.Impares
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número ");
            int A = int.Parse(Console.ReadLine());
            int B = int.Parse(Console.ReadLine());

            int soma = (A + B);



            for (int i = 1; i <= soma; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }
            
        }
    }
}
