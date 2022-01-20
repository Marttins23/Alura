using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_Escopo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o Projeto 8:");

            int idadeJoao = 16;
            int quantidadePessoas = 2;
            bool acompanhado = quantidadePessoas > 1;

            string mensagemAdicional;

            if (acompanhado == true)
            {
                mensagemAdicional = "João está acompanhado.";
            }
            else
            {
                mensagemAdicional = "João não está acompnhado.";
            }

            if (idadeJoao >= 18 || acompanhado)
            {
                Console.WriteLine("Pode entrar.");
                Console.WriteLine(mensagemAdicional);
            }
            else
            {
                Console.WriteLine("Entrada não permitida.");
                Console.WriteLine(mensagemAdicional);
            }


            Console.WriteLine("Presisone enter para sair...");
            Console.ReadLine();
        }
    }
}
