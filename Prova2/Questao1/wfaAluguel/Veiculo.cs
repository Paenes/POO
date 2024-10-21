using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wfaAluguel
{
    internal abstract class Veiculo
    {
        protected string placa;
        protected int ano;

        public Veiculo()
        {
            this.placa = null; this.ano = 0;
        }

        public Veiculo(string _placa, int _ano)
        {
            this.placa = _placa;
            this.ano = _ano;
        }
        public string Placa { get => placa; set => placa = value; }
        public int Ano { get => ano; set => ano = value; }

        public abstract double Alugar();
    }
}
