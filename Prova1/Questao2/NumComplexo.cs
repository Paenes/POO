using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questao2
{
    internal class NumComplexo
    {
        double Re, Im;

        public NumComplexo()
        {
            Re = 0.0;
            Im = 0.0;
        }

        public NumComplexo(double _Re, double _Im)
        {
            Re = _Re;
            Im = _Im;
        }

        public NumComplexo soma(NumComplexo a, NumComplexo b)
        {
            double soma_re = a.Re+b.Re;
            double soma_im = a.Im+b.Im;

            NumComplexo C = new NumComplexo(soma_re,soma_im);

            return C;
        }

        public NumComplexo vezes(NumComplexo d, NumComplexo e) 
        {
            double vezes_re = d.Re * e.Re;
            double vezes_im = d.Im * e.Im;

            NumComplexo f = new NumComplexo(vezes_re,vezes_im);

            return f;
        }

        public double Modulo()
        {
            double p = Math.Pow((Math.Pow(Re,2)+Math.Pow(Im,2)),0.5);
            return p;
        }

        public double Argumento()
        {
            return Math.Atan(Im/Re);
        }

        public void ImprimeFormaPolar()
        {
            Console.WriteLine(Modulo()+ "ang" + Argumento() + "º");
        }
    }
}
