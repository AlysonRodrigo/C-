using System;

namespace classe_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Cadastro x, y;
            x = new Cadastro();
            y = new Cadastro();
            Console.WriteLine("Dados da primeira pessoa");
            Console.Write("Nome: ");
            x.A = Console.ReadLine();
            Console.Write("Idade: ");
            x.B = int.Parse(Console.ReadLine());
            Console.WriteLine("Dados da segunda pessoa");
            Console.Write("Nome: ");
            y.A = Console.ReadLine();
            Console.Write("Idade: ");
            y.B = int.Parse(Console.ReadLine());
            if (x.B > y.B)
            {
                Console.WriteLine(" Pessoa mais velha: " + x.A);
            }
            else {
                Console.WriteLine("Pessoa mais velha: " + y.A);
            }




        }
    }
}
