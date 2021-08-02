using System;
namespace exercicio_de_fixacao2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantos quartos serão alugados? ");
            int N = int.Parse(Console.ReadLine());
            Pensionato[] vect = new Pensionato[N];
           

            for (int i = 1; i <= N; i++)
            {
                Console.WriteLine();
                Console.Write($"Aluguel # "[i]);
                Console.Write(" Nome: ");
                string nome = Console.ReadLine();
                Console.Write(" E-mail: ");
                string email = Console.ReadLine();
                Console.Write("Quarto: ");
                int quarto = int.Parse(Console.ReadLine());
                vect[quarto] = new Pensionato { Nome = nome, Email = email };
            }
            Console.WriteLine();

        }
    }
}
