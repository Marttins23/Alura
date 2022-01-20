using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_Condicionais2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o Projeto 8:");

            int idadeJoao = 16;
            int quantidadePessoas = 2;

            bool acompanhado = quantidadePessoas > 1;

            if (idadeJoao >= 18 || acompanhado)
            {
                Console.WriteLine("João é maior de idade ou está acompanhado. Pode entrar.");
            }
            else
            {
                Console.WriteLine("João tem menos de 18 anos e não está acompanhado. Entrada não permitida."); 
            }


            Console.WriteLine("Presisone enter para sair...");
            Console.ReadLine();
        }
    }
}
