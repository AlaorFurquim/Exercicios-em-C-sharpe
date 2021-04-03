using System;
using System.Globalization;


namespace Salario_Imposto
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario Func = new Funcionario();
            Console.WriteLine("Entre com os dados do funcionário ");
            Console.Write("Nome: ");
            Func.Nome = Console.ReadLine();
            Console.Write("Salario bruto: ");
            Func.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Imposto: ");
            Func.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine();
            Console.WriteLine("Funcionário " + Func);

            Console.WriteLine();
            Console.Write("Deseja aumentar o salario em qual porcentagem? ");
            double porcent = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Func.AumentarSalario(porcent);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + Func);

        }
    }
}
