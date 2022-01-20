using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P11_CalculaPoupanca2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o Projeto 11:");

            double valorInvestido = 1000;

            for (int i = 0; i < 12; i++)
            {
                valorInvestido += valorInvestido * 0.0036;
                Console.WriteLine("Ápós " + i + " meses, você terá R$" + valorInvestido);
            }

            Console.WriteLine("Pressione enter para sair...");
            Console.ReadLine();
        }
    }
}
