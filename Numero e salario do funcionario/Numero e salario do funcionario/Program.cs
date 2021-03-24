using System;
using System.Globalization;

namespace Numero_e_salario_do_funcionario
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o número do funcionário");

            int N = int.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine("Digite as horas trabalhadas");

            double H = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            Console.WriteLine();

            Console.WriteLine("Digite o valor da hora");

            double V = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double R = H * V;

            Console.WriteLine("Funcionario: " + N);

            Console.WriteLine("Salário: " + R.ToString("f2",CultureInfo.InvariantCulture));
        }
    }
}
