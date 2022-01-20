using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_ByteBank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta1 = new ContaCorrente();

            conta1.titular = "Gabriela";
            conta1.agencia = 863;
            conta1.numero = 863456;
            conta1.saldo = 100;

            Console.WriteLine("Titular: " + conta1.titular);
            Console.WriteLine("Agência: " + conta1.agencia);
            Console.WriteLine("Número: " + conta1.numero);
            Console.WriteLine("Saldo: R$" + conta1.saldo);

            conta1.saldo += 200;
            Console.WriteLine("Saldo: R$" + conta1.saldo);

            Console.ReadLine();
        }
    }
}
