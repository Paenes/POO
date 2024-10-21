using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wfaAluguel
{
    internal class Onibus : Veiculo
    {
        private int assentos;


        public Onibus() : base()
        {
            this.placa = null;
            this.ano = 0;
            this.assentos = 0;
        }
        public Onibus(string _placa, int _ano, int _assentos) : base(_placa, _ano)
        {
            this.placa = _placa;
            this.ano = _ano;
            this.assentos = _assentos;
        }
        public int Assentos { get => assentos; set => assentos = value; }

        public override double Alugar()
        {
            return (30 * assentos) - (DateTime.Now.Year - this.Ano) * 70;
        }
    }
}
