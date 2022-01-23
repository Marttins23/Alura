using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank.Modelos;
using ByteBank.Modelos.Funcionarios;
using Humanizer;

namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {
            /*string url = "https://www.bytebank.com.br/cambio?moedaOrigem=real&moedaDestino=dolar&valor=1500";

            ExtratorValorDeArgumentosURL extratorDeURL = new ExtratorValorDeArgumentosURL(url);
            Console.WriteLine("Moeda de Origem: " + extratorDeURL.GetValor("moedaOrigem"));
            Console.WriteLine("Moeda de Destino: " + extratorDeURL.GetValor("moedaDestino"));
            Console.WriteLine("Valor: " + extratorDeURL.GetValor("valor"));*/

            string padrao = ExpressaoRegular.RetornaPadrao("[0-9]{4,5}-?[0-9]{4}", "Dentre deste texto, desejamos achar o padrão 97895-3452");
            Console.WriteLine("O padrão encontrado foi " + padrao);

            ContaCorrente conta = new ContaCorrente("Mateus", 865, 865473);
            Console.WriteLine(conta.ToString());

            Cliente mateus = new Cliente();
            mateus.Nome = "Mateus";
            mateus.CPF = "104.488.306-55";
            mateus.Profissao = "Desenvolvedor";

            Cliente mateus2 = new Cliente();
            mateus2.Nome = "Mateus";
            mateus2.CPF = "104.488.306-55";
            mateus2.Profissao = "Desenvolvedor";

            Console.WriteLine("Os clientes são iguais? " + mateus.Equals(mateus2));

            Console.WriteLine("\nPressione enter para sair...");
            Console.ReadLine();
        }
    }
}
                                                            