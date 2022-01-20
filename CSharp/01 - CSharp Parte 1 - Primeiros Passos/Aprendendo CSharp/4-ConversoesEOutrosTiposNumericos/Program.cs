using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_ConversoesEOutrosTiposNumericos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 4:");

            double salario = 1200.50;

            int salarioEmInteiro = (int)salario;

            Console.WriteLine("Salário em Inteiro = " + salarioEmInteiro);

            //O long tem 64 bits
            long idade = 13000000000;

            short quantidadeProdutos = 150;

            float altura = 1.75f;

            Console.WriteLine("Tecle enter para sair...");
            Console.ReadLine();
        }
    }
}
