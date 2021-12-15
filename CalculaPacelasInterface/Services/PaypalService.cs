using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculaPacelasInterface.Services
{
    class PaypalService : IOnlineServicoPagamento
    {
        private const double Taxa = 0.02;
        private const double JurosMensal = 0.01;

        public double CaclulaParcela(double mont, int qtdParcelas)
        {
            return mont * JurosMensal * qtdParcelas;
        }

        public double PagamentoBasico(double mont)
        {
            return mont * Taxa;
        }
    }
}
