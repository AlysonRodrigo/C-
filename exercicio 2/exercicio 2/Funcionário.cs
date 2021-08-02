using System;
using System.Collections.Generic;
using System.Text;

namespace exercicio_2
{
    class Funcionário
    {
        public String Nome;
        public double NotaA;
        public double NotaB;
        public double NotaC;

        public double Nota_Final()
        {
            return NotaA + NotaB + NotaC;
        }

    }
}
