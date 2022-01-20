using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P13_ForEncadeado
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Projeto 13:");

            for (int contadorLinhas = 0; contadorLinhas < 10; contadorLinhas++)
            {
                for (int contadorColunas = 0; contadorColunas < 10; contadorColunas++)
                {
                    if(contadorColunas > contadorLinhas)
                    {
                        break;
                    }   
                    Console.Write("*");

                }
                Console.WriteLine();
            }

            //Outra forma de fazer
            for (int contadorLinhas = 0; contadorLinhas < 10; contadorLinhas++)
            {
                for (int contadorColunas = 0; contadorColunas <= contadorLinhas; contadorColunas++)
                {
                    Console.Write("*");

                }
                Console.WriteLine();
            }

            Console.WriteLine("Pressione enter para sair...");
            Console.ReadLine();
        }
    }
}
