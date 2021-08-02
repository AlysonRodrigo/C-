using System.Globalization;

namespace exrcicio_de_fixaçao
{
    class Conta
    {
        public int Numero { get; private set; }
        public string Nome { get; set; }
        public double Saldo { get; private set; }


        public Conta (int numero, string nome)
        {
            Numero = numero;
            Nome = nome;
        }

        public Conta(int numero, string nome, double depositoInicial) : this(numero, nome)
        {
            Deposito(depositoInicial);
        }
           public void Deposito(double quantia) {
            Saldo += quantia;
        }

        public void Saque(double quantia) {
            Saldo -= quantia;
            Saldo -= 5.00;
        }

        public override string ToString()
        {
            return " Conta "
                +Numero 
                +", Titular: "
                + Nome 
                + " , Saldo R$ "
                + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
