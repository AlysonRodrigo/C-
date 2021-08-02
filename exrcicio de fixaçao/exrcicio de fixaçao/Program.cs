using System;
using System.Globalization;
namespace exrcicio_de_fixaçao
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta bancaria;
            Console.Write(" Entre o número da conta: ");
            int numero = int.Parse(Console.ReadLine());
            Console.Write("Entre o titular da conta: ");
            string nome = Console.ReadLine();
            Console.Write("Havera deposito inicial (s/n) ? ");
            char resp = char.Parse(Console.ReadLine());
            if (resp == 's' || resp == 'S')
            {
                Console.Write("Entre o valor de depósito inicial: ");
                double depositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
          
                bancaria = new Conta(numero, nome, depositoInicial);
            }
            else
            {
               bancaria= new Conta (numero , nome);
            }
            Console.WriteLine("Dados da conta :");
            Console.WriteLine(bancaria);
            Console.WriteLine();

            Console.Write("Entre um valor para depósito: ");
            double quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            bancaria.Deposito(quantia);
            Console.WriteLine("Dados da conta Atualizado :");
            Console.WriteLine(bancaria);

            Console.Write("Entre um valor para Saque: ");
            quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            bancaria.Saque(quantia);
            Console.WriteLine("Dados da conta Atualizado :");
            Console.WriteLine(bancaria);
        }
    }
}
