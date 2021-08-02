using System;
using System.Globalization;

namespace tentativa_2
{
    class Program
    {
        static void Main(string[] args)
        {
           Retangulo a = new Retangulo();
            Console.WriteLine("Entre a largura e altura do retângulo:");
            a.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            a.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double areaA = a.Area();
            double perimetroA = a.Perimetro();
            Console.Write("Area " + areaA, CultureInfo.InvariantCulture);
            Console.WriteLine();
            Console.Write("Perimetro " + perimetroA, CultureInfo.InvariantCulture);
        }
    }
}
