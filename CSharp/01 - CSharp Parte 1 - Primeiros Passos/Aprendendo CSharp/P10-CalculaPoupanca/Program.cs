using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P10_CalculaPoupanca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o Projeto 10:");

            double valorInvestido = 1000;
            int contadorMes = 1;

            while(contadorMes <= 12)
            {
                valorInvestido = valorInvestido + valorInvestido * 0.0036;
                Console.WriteLine("Ápós " + contadorMes + " meses, você terá R$" + valorInvestido);
                contadorMes++;
            }

            Console.WriteLine("Pressione enter para sair...");
            Console.ReadLine();
        }
    }
}
