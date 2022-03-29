using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoPagamento
{
    class CartaoBandeiraVisa : PagamentoCartao
    {
        public string pagamentoCredito(double pontos)
        {
            return "Pago com Visa Crédito. (Valor: " + pontos.ToString() + " pontos)";
        }
        public string pagamentoDebito(double pontos)
        {
            return "Pago com Visa Débito. (Valor: " + pontos.ToString() + " pontos)";
        }
    }
}
