using System;

namespace matriz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ordem: ");
            int n = int.Parse(Console.ReadLine());
            int[,] mat = new int[n, n];

            for (int i = 0; i < n; i++)
            {
                string[] values = Console.ReadLine().Split(" ");
                for (int j = 0; j < n; j++)
                {
                    mat[i, j] = int.Parse(values[j]);
                }
            }
            Console.WriteLine("Main diagonal");
            for (int i = 0; i < n; i++)
            {
                Console.Write(mat[i, i] + " ");

            }
            Console.WriteLine();

            int cout = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (mat[i, j] < 0)
                    {
                        cout++;
                    }
                    Console.WriteLine("negative numbers: " + cout);

                }
            }
        }
    }
}
