﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank.Modelos;
using ByteBank.Modelos.Funcionarios;
using Humanizer;

namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {
            Lista<int> listaIdades = new Lista<int>();

            listaIdades.Adicionar(2);
            listaIdades.Adicionar(5);
            listaIdades.Adicionar(8);
            listaIdades.AdicionarVarios(8, 7, 14, 73);

            //listaIdades.ImprimeContas();

            TestaListaDeContasCorrentes();

            Console.WriteLine("\nPressione enter para sair...");
            Console.ReadLine();
        }

        public static void TestaListaDeContasCorrentes()
        {
            ListaDeContaCorrente lista = new ListaDeContaCorrente(3);

            ContaCorrente contaJoao = new ContaCorrente("Joao", 876, 756473);
            Console.WriteLine(contaJoao.GetType() == typeof(ContaCorrente));

            lista.AdicionarVarios(
                contaJoao,
                new ContaCorrente("Mateus", 865, 865748),
                new ContaCorrente("Mateus", 865, 865748),
                new ContaCorrente("Mateus", 865, 865748),
                new ContaCorrente("Mateus", 865, 865748),
                new ContaCorrente("Mateus", 865, 865748),
                new ContaCorrente("Mateus", 865, 865748)
            );
            //lista.ImprimeContas();

            for (int i = 0; i < lista.Tamanho; i++)
            {
                try
                {
                    //Usando Indexadores
                    ContaCorrente contaAtual = lista[i];
                    Console.WriteLine(contaAtual.ToString());
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }

            }

            //lista.Remover(contaJoao);
            //lista.ImprimeContas();
        }

        public static void TestaContaCorrente()
        {
            ContaCorrente[] contas = new ContaCorrente[]
            {
                new ContaCorrente("Mateus", 865, 876543),
                new ContaCorrente("Fernanda", 865, 875674),
                new ContaCorrente("Felipe", 865, 847328)
            };

            for (int i = 0; i < contas.Length; i++)
            {
                Console.WriteLine($"A conta no índice {i} possui o número igual a {contas[i].Numero}");
            }
        }

        public static void TestaArrayInt()
        {
            int[] idades = new int[5];

            idades[0] = 23;
            idades[1] = 28;
            idades[2] = 35;
            idades[3] = 50;
            idades[4] = 28;

            int soma = 0;

            for (int i = 0; i < idades.Length; i++)
            {
                soma += idades[i];
            }

            int media = soma / idades.Length;

            Console.WriteLine($"A média das idades é {media} anos.");
        }
    }
}
                                                            