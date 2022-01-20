using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_CaracteresETextos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o Projeto 5:");

            char primeiraLetra = 'a';
            Console.WriteLine(primeiraLetra);

            primeiraLetra = (char)65;
            Console.WriteLine(primeiraLetra);

            primeiraLetra = (char)(primeiraLetra + 1);
            Console.WriteLine(primeiraLetra);

            string texto = "Este é um texto qualquer, escrito em " + 2022;
            string lista = " - Item 1\n - Item 2\n - Item 3";
            Console.WriteLine(texto);
            Console.WriteLine(lista);

            Console.WriteLine("Tecle enter para sair...");
            Console.Read();
        }
    }
}
