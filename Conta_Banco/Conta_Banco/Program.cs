using System;
using System.Globalization;

namespace Conta_Banco
{
    class Program
    {
        static void Main(string[] args)
            
        {
            ContaBancaria conta;
            
            Console.Write("Digite o Número da conta: ");
            int numero = int.Parse(Console.ReadLine());
            Console.Write("Digite o titular da conta: ");
            string titular = Console.ReadLine();
            Console.Write("Haverá depósito inicial? (s/n): ");
            char resp = char.Parse(Console.ReadLine());
            if(resp =='s' || resp == 'S')
            {
                Console.Write("Entre com o depsito inicial: ");
                double Deposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                conta = new ContaBancaria(numero, titular, Deposito);
            }
            else 
            {
                conta = new ContaBancaria(numero, titular);
            }

            Console.WriteLine();
            Console.WriteLine("Dados da conta:");
            Console.WriteLine(conta);

            Console.WriteLine();
            Console.Write("Entre um valor para depÓsito: ");
            double quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Deposito(quantia);
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(conta);

            
            

             
        }
    }
}
