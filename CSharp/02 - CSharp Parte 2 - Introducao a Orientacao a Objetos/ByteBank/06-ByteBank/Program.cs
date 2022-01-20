using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_ByteBank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente();
            Cliente cliente = new Cliente();

            cliente.Nome = "Mateus";
            cliente.CPF = "123.456.789-10";
            cliente.Profissao = "Desenvolvedor";

            conta.Saldo = -50;
            conta.Titular = cliente;

            Console.WriteLine(conta.Titular.Nome);
            Console.WriteLine(conta.Saldo);

            Console.WriteLine("\nPressione enter para sair...");
            Console.ReadLine();
        }
    }
}
