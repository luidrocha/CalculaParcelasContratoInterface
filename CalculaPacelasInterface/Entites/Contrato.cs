using System;
using System.Globalization;
using System.Collections;
using System.Collections.Generic;

namespace CalculaPacelasInterface.Entites
{
    class Contrato
    {
        public int ContratoNumero { get;  set; }
        public DateTime DataContrato { get; set; }

        public Double ValorContrato { get; set; }

        
        public List<Prestacoes> Prestacoes = new List<Prestacoes>();

        public Contrato()
        {

        }
        public Contrato(int contratoNumero, DateTime dataContrato, double valorContrato)
        {
            ContratoNumero = contratoNumero;
            DataContrato = dataContrato;
            ValorContrato = valorContrato;
            Prestacoes = new List<Prestacoes>();
            
        }


        public void GravaParcela(Prestacoes parcela)
        {

            Prestacoes.Add(parcela);

        }

        public override string ToString()
        {
            return "Contrato Numero: "
                    + ContratoNumero
                    + " Dada Contrato: "
                    + DataContrato
                    + " Valor do Contrato "
                    + ValorContrato.ToString("F2", CultureInfo.InvariantCulture);
                    
        }

    }
}
