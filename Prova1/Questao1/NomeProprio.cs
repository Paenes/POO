using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Questao1
{
    internal class NomeProprio
    {
        public string nome_completo, nome_paper;

        public NomeProprio()
        {
            nome_completo = null;
            nome_paper = null; 
        }

        public NomeProprio(string _nome_completo) //instancia o nome_paper
        {
            bool temSobrenome = false; // usado adiante para registrar sobrenome ou não
            int i = 0, j = 0, k = 0;
            char[] nome1 = new char[100];
            char[] nome2 = new char[100];
            char[] nome3 = new char[100];

            nome_completo = _nome_completo;
            while (i < nome_completo.Length) {
                while (nome_completo[i] != ' ')
                {
                    nome1[i] = nome_completo[i];
                    nome1[i + 1] = '\0';
                    i++;
                }
                i++; // pula o caractere SPACE
                while (nome_completo[i] != ' ')
                {
                    nome2[j] = nome_completo[i];
                    nome2[j + 1] = '\0';
                    i++;j++;
                }
                i++; // pula o caractere SPACE
                while (i < nome_completo.Length)
                {
                    nome3[k] = nome_completo[i];
                    nome3[k+1] = '\0';
                    i++; k++;
                }
                 temSobrenome = true; // completou 3 nomes
            }
            if (temSobrenome)
            {
                nome2[1] = '.';
                nome2[2] = '\0';
                NomeProprio Sobrenome = new NomeProprio(nome3.ToString());
                NomeProprio PrimeiroNome = new NomeProprio(nome1.ToString());
                NomeProprio NomeMeio = new NomeProprio(nome2.ToString());

                nome_paper = Sobrenome.nome_completo + ", " + PrimeiroNome.nome_completo + NomeMeio.nome_completo;
            }
            else
            {
                NomeProprio Sobrenome = new NomeProprio(nome2.ToString());
                NomeProprio PrimeiroNome = new NomeProprio(nome1.ToString());

                nome_paper = Sobrenome.nome_completo + ", " + PrimeiroNome.nome_completo;
            }
            
            
        }

        public void ImprimeNomePaper()
        {
            Console.WriteLine(nome_paper);
            Console.ReadLine();
        }
    }
}
