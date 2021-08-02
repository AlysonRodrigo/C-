using System;
using System.Collections.Generic;
using System.Text;

namespace tentativa_2
{
    class Retangulo
    {
        public double Largura;
        public double Altura;

        public double Area()
        {
            return Largura * Altura;
        }
        public double Perimetro()
        {
            return (Largura * 2.0) + (Altura * 2.0);
        }
       
    }
}
