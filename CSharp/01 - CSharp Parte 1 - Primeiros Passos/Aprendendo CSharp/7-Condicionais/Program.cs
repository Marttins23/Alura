using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_Condicionais
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o Projeto 7:");

            int idadeJoao = 16;
            int quantidadePessoas = 2;

            if(idadeJoao >= 18)
            {
                Console.WriteLine("João é maior de idade. Pode entrar.");
            } 
            else
            {
                if(quantidadePessoas > 1)
                {
                    Console.WriteLine("João tem menos de 18 anos mas está acompanhado. Pode entrar.");
                }
                else
                {
                    Console.WriteLine("João tem menos de 18 anos e não está acompanhado. Entrada não permitida.");
                }
                
            }


            Console.WriteLine("Presisone enter para sair...");
            Console.ReadLine(); 
        }
    }
}
