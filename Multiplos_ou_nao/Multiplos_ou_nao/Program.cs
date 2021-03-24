using System;

namespace Multiplos_ou_nao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite os números a serem Comparados!");
            string[] Number = Console.ReadLine().Split(' ');
           

            int Num1 = int.Parse(Number[0]);
            int Num2 = int.Parse(Number[1]);

            if(Num1 % Num2 == 0 || Num2 % Num1 == 0)
            {
                Console.WriteLine("São multiplos");
            }
            else
            {
                Console.WriteLine("Não são multiplos");
            }


        }
    }
}
