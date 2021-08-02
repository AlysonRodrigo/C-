using System;
using System.Globalization;
namespace exercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionário A = new Funcionário();
            double falta;

            Console.Write("Nome do aluno: ");
            A.Nome = Console.ReadLine();

            Console.WriteLine("Digite as três notas do aluno: ");
            A.NotaA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            A.NotaB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            A.NotaC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Double nota = A.Nota_Final();

            Console.WriteLine(" NOTA FINAL = " + nota);
            falta = nota < 0;
            if (nota > 60)
            {
                Console.WriteLine("APROVADO");
            }
            else
            {
                Console.WriteLine(" REPROVADO " + falta, " pontos ");
            }

           

        }
    }
}
