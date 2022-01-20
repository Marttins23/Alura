using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_AtribuicoesDeVariaveis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 6:");

            int idade = 26;

            //Atribuição é feita por valor (cópia), e não por referência.
            int idadeGustavo = idade;

            idade = 21;
            Console.WriteLine(idade);
            Console.WriteLine(idadeGustavo);

            Console.WriteLine("Pressione enter para sair...");
            Console.ReadLine();
        }
    }
}
