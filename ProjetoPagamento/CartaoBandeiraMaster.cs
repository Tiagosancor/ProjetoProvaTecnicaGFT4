using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoPagamento
{
    class CartaoBandeiraMaster : PagamentoCartao
    {
        public string pagamentoCredito(double pontos)
        {
            return "Pago com Master Crédito. (Valor: " + pontos.ToString() + " pontos)";
        }
        public string pagamentoDebito(double pontos)
        {
            return "Pago com Master Débito. (Valor: " + pontos.ToString() + " pontos)";
        }
    }
}
