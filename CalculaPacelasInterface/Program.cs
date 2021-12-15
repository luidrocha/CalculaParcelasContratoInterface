using System;
using System.Collections.Generic;
using System.Globalization;
using CalculaPacelasInterface.Entites;
using CalculaPacelasInterface.Services;

namespace CalculaPacelasInterface
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine( "Entre com os dados do Contrato");
            Console.WriteLine();

            Console.Write("Numero do Contrato: ");
            int numero = int.Parse(Console.ReadLine());

            Console.Write("Data do Contrato: ");
            DateTime data = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);

             Console.Write("Valor do Contrato: ");
            double valor = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            Console.Write("Quantidade de Parcelas: ");
            int parcelas = int.Parse(Console.ReadLine());

            Contrato contrato = new Contrato(numero, data, valor);

            Console.WriteLine(contrato);


            ContractService contratoService = new ContractService(new PaypalService());
            contratoService.ProcessaContrato(contrato, parcelas);

            foreach (Prestacoes  parcela in contrato.Prestacoes)
            {

                Console.WriteLine(parcela);
            }


        }

        



    }
}
