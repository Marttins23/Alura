using ByteBankImportacaoExportacao.Modelos;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBankImportacaoExportacao
{
    partial class Program
    {
        public static ContaCorrente ConverterStringParaContaCorrente(string texto)
        {
            var campos = texto.Split(',');

            var agencia = int.Parse(campos[0]);
            var numero = int.Parse(campos[1]);
            var saldo = double.Parse(campos[2].Replace('.', ','));
            var titular = new Cliente();
            titular.Nome = campos[3];

            var conta = new ContaCorrente(agencia, numero);
            conta.Depositar(saldo);
            conta.Titular = titular;

            return conta;
        }
    }
}