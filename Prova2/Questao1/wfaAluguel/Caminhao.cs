using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wfaAluguel
{
    internal class Caminhao : Veiculo
    {
        private int eixos;

        public Caminhao() : base()
        {
            this.placa=null;
            this.ano = 0; 
            this.eixos=0;
        }

        public Caminhao(string _placa, int _ano, int _eixos) : base(_placa, _ano)
        {
            this.placa = _placa;
            this.ano = _ano;
            this.eixos = _eixos;
        }

        public int Eixos { get => eixos; set => eixos = value; }

        public override double Alugar()
        {
            return (300 * eixos) - (DateTime.Now.Year - this.Ano) * 50;
        }
    }
}
