using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank.Modelos;
using ByteBank.Modelos.Funcionarios;
using ByteBank.SistemaAgencia.Comparadores;
using ByteBank.SistemaAgencia.Extensoes;
using Humanizer;

namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {
            var contas = new List<ContaCorrente>()
            {
                new ContaCorrente("Mateus", 865, 876543),
                null,
                new ContaCorrente("Mateus", 864, 766543),
                new ContaCorrente("Mateus", 867, 996543),
                null,
                new ContaCorrente("Mateus", 864, 506543),
                new ContaCorrente("Mateus", 862, 236543)
            };

            //Método onde Contacorrente implementa a Interface IComparable
            //contas.Sort();

            //Método que utiliza um objeto da classe que definimos que implementa a Interface IComparer
            //contas.Sort(new ComparadorContaCorrentePorAgencia());

            //Usando o método Where para selecionar as contas que não são nulas
            //var contasNaoNulas = contas.Where(conta => conta != null);

            //Usando o OrderBy
            //var contasOrdenadas = contasNaoNulas.OrderBy(conta => conta.Numero);

            //Podemos encadear o uso do where e do OrderBy
            var contasOrdenadas = contas.Where(conta => conta != null).OrderBy(conta => conta.Numero);

            foreach(var conta in contasOrdenadas)
            {
                Console.WriteLine($"Número: {conta.Numero} \nAgência: {conta.Agencia}\n");
            }

            Console.WriteLine("\nPressione enter para sair...");
            Console.ReadLine();
        }

        public static void TestaSort()
        {
            List<int> listaIdades = new List<int>();

            listaIdades.Add(50);
            listaIdades.Add(2);
            listaIdades.Add(5);
            listaIdades.Add(8);
            //ListExtensoes.AdicionarVarios(listaIdades, 45, 83647, 893475);

            //Usando métodos de extensão genéricos
            listaIdades.AdicionarVarios(8, 7, 14, 73);
            listaIdades.Sort();

            for (int i = 0; i < listaIdades.Count; i++)
            {
                Console.WriteLine(listaIdades[i]);
            }
        }

        public static void TestaListaDeContasCorrentes()
        {
            ListaDeContaCorrente lista = new ListaDeContaCorrente(3);

            ContaCorrente contaJoao = new ContaCorrente("Joao", 876, 756473);

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
                                                            