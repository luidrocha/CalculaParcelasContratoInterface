using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculaPacelasInterface.Services
{
    interface IOnlineServicoPagamento
    {

        double PagamentoBasico(double mont);
        double CaclulaParcela(double mont, int qtdParcelas);
    }
}
