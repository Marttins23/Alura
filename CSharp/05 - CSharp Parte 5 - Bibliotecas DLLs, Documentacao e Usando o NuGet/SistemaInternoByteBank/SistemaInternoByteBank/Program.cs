using ByteBank.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaInternoByteBank
{
    internal class Program
    {
        static void Main(string[] args)
        {

            ContaCorrente conta = new ContaCorrente(865, 865748);
            Console.WriteLine(conta.Saldo);

            Console.WriteLine("\nPressione enter para sair...");
            Console.ReadLine();

        }
    }
}
