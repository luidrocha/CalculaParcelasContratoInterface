using System;
using System.Collections.Generic;
using CalculaPacelasInterface.Entites;

namespace CalculaPacelasInterface.Services
{
    class ContractService
    {
        private IOnlineServicoPagamento _onlineServicoPagamento;


        public ContractService(IOnlineServicoPagamento onlineServicoPagamento)
        {
            _onlineServicoPagamento = onlineServicoPagamento;
        }


        public void ProcessaContrato(Contrato contrato, int parcelas)
        {
            double ValorBasico = contrato.ValorContrato / parcelas;

            for (int i = 1; i <= parcelas; i++)
            {
                DateTime data = contrato.DataContrato.AddMonths(i); // AddMonths metodo padrão adiciona mais 1 mes
                double parcelaAtualizada = ValorBasico + _onlineServicoPagamento.CaclulaParcela(ValorBasico, i);
                double parcelaCheia = parcelaAtualizada + _onlineServicoPagamento.PagamentoBasico(parcelaAtualizada);
                contrato.GravaParcela(new Prestacoes(data, parcelaCheia));

            }

        }
    }
}