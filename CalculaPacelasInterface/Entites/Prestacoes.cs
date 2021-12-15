using System;
using System.Globalization;



namespace CalculaPacelasInterface.Entites
{
    class Prestacoes
    {
        public DateTime Vencimento { get; set; }
        public double Valor { get; set; }

        public Prestacoes(DateTime vencimento, double valor)
        {
            Vencimento = vencimento;
            Valor = valor;
        }

        public override string ToString()
        {
            return Vencimento.ToString("dd/MM/yyyy")
                + " " 
                + "R$" + Valor.ToString("F2", CultureInfo.InvariantCulture);



        }
    }
}
