

namespace exercicio_de_fixacao2
{
    class Pensionato
    {
        public string Nome { get; set; }
        public string Email { get; set; }

        public override string ToString()
        {
            return Nome + ", " + Email;
        }
    }
}