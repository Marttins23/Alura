using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_ByteBank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta1 = new ContaCorrente();
            conta1.titular = "Bruno";

            Console.WriteLine("Saldo anterior: R$" + conta1.saldo);
            bool sucessoSaque = conta1.Sacar(500);
            if(sucessoSaque)
            {
                Console.WriteLine("O saque foi realizado com sucesso!");
            }
            else
            {
                Console.WriteLine("O saque não foi realizado. Verifique o valor e tente novamente!");
            }
            Console.WriteLine("Saldo atual: R$" + conta1.saldo);

            conta1.Depositar(500);
            Console.WriteLine("Foram depositados R$500,00 com sucesso!!");
            conta1.Sacar(500);
            Console.WriteLine("Foram sacados R$500,00 com sucesso!!");
            Console.WriteLine("Saldo atual: R$" + conta1.saldo);

            ContaCorrente conta2 = new ContaCorrente();

            Console.WriteLine("\nTransferindo R$100,00 da conta 1 para a conta 2....");
            bool sucessoTransferencia = conta1.Transferir(100, conta2);
            if(sucessoTransferencia)
            {
                Console.WriteLine("Transferência realizada com sucesso!!");
            }
            else
            {
                Console.WriteLine("A transferência não foi realizada. Verifique o valor e tente novamente!");
            }
            Console.WriteLine("Saldo da conta 1: R$" + conta1.saldo);
            Console.WriteLine("Saldo da conta 2: R$" + conta2.saldo);

            Console.WriteLine("Pressione enter para sair...");
            Console.ReadLine();
        }
    }
}
