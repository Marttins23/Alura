using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ByteBank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente(865, 865748);
            ContaCorrente conta2 = new ContaCorrente(756, 756835);

            Console.WriteLine(conta.Agencia);
            Console.WriteLine(conta.Numero);
            Console.WriteLine(ContaCorrente.TotalDeContasCriadas);

            Console.WriteLine("\nPressione enter para sair...");
            Console.ReadLine();
        }
    }
}
