using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoProdutos
{
    public class Produto
    {
        public string descricao { get; set; }
        public double valorReal { get; set; }
        public string operacao { get; set; }
        public double percentual { get; set; }
        public double valorFinal { get; set; }

        public Produto(string Descricao, double ValorReal, string Operacao, double Percentual)
        {
            descricao = Descricao;
            valorReal = ValorReal;
            operacao = Operacao;
            percentual = Percentual;
        }

        public double CalcularOperacao()
        {
            valorFinal = valorReal;

            if (operacao == "desconto")
            {
                valorFinal = valorReal - ((valorReal * percentual) / 100);
            }
            if (operacao == "acrescimo")
            {
                valorFinal = valorReal + ((valorReal * percentual) / 100);
            }
            return valorFinal;


        }
    }
