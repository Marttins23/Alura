using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_ByteBank
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

            ContaCorrente conta2 = new ContaCorrente();
            conta2.titular = "Gabriela";
            conta2.agencia = 863;
            conta2.numero = 863456;
            conta2.saldo = 100;

            Console.WriteLine("Igualdade de objetos (referência): " +
                (conta1 == conta2)
            );

            int idade = 27;
            int outraIdade = 27;

            Console.WriteLine("Igualdade de tipos primitivos (valor): " +
                (idade == outraIdade)
            );

            conta2 = conta1;

            Console.WriteLine("Igualdade de objetos: " +
                (conta1 == conta2)
            );

            conta2.saldo = 300;
            Console.WriteLine("Saldo da conta 2: " + conta2.saldo);
            Console.WriteLine("Saldo da conta 1: " + conta1.saldo);

            Console.WriteLine("Pressione enter para sair...");
            Console.ReadLine();

        }
    }
}
