using System;
using System.Globalization;

namespace Media_Nota
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno aluno = new Aluno();

            Console.WriteLine("Digite o nome do aluno");

            aluno.Nome = Console.ReadLine();

            Console.WriteLine("Digte as três notas do aluno");

            aluno.Nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            aluno.Nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            aluno.Nota3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Nota final = " + aluno.NotaFinal().ToString("f2",CultureInfo.InvariantCulture));

            if (aluno.Aprovado())
            {
                Console.WriteLine("Aprovado");
            }
            else
            {
                Console.WriteLine("Aluno reprovado");
                Console.WriteLine("Faltaram: " + aluno.NotaRestante().ToString("f2",CultureInfo.InvariantCulture) + " Pontos");
            }
            

        }
    }
}
