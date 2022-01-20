using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_ByteBank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Cliente gabriela = new Cliente();

            // gabriela.nome = "Gabriela";
            // gabriela.cpf = "123.456.789-10";
            // gabriela.profissao = "Desenvolvedora C#";

            ContaCorrente conta = new ContaCorrente();
            // conta.titular = gabriela;
            // conta.titular.nome = "Gabriela";
            // conta.titular.cpf = "123.456.789-10";
            // conta.titular.profissao = "Desenvolvedora C#";
            conta.saldo = 500;
            conta.agencia = 864;
            conta.numero = 864586;

            // conta.titular.nome = "Gabriela Costa";

            // Console.WriteLine(gabriela.nome);
            
            if(conta.titular == null)
            {
                Console.WriteLine("A referência para conta,titular é nula (null)!");
            }
            Console.WriteLine(conta.titular);

            Console.WriteLine("\nPressione enter para sair...");
            Console.ReadLine();

        }
    }
}
