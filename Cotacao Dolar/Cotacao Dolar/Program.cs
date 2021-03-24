using System;
using System.Globalization;

namespace Cotacao_Dolar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qual é a cotação do dólar?");
            double cotacao = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            Console.Write("Quantos dólares você irá coprar?");
            double quantia = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            double result = Conversor.DolarParaReal (quantia,  cotacao);

            Console.WriteLine("Valor a  ser pago em reais = " + result.ToString("f2", CultureInfo.InvariantCulture));
        }
    }
}
