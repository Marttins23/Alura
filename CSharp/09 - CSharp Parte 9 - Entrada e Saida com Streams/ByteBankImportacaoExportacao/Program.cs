using ByteBankImportacaoExportacao.Modelos;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBankImportacaoExportacao 
{ 
    partial class Program 
    { 
        static void Main(string[] args) 
        {
            File.WriteAllText("escrevendoComAClasseFile.txt", "Testando File.WriteAllText");

            Console.WriteLine("Arquivo escrevendoComAClasseFile criado!");

            var bytesArquivo = File.ReadAllBytes("contas.txt");
            Console.WriteLine($"Arquivo contas.txt possui { bytesArquivo.Length} bytes");

            var linhas = File.ReadAllLines("contas.txt");
            Console.WriteLine(linhas.Length);

            foreach (var linha in linhas)
            {
                Console.WriteLine(linha);
            }

            //StreamDeEntrada();
            //LeituraBinaria();
            //EscritaBinaria();
            //CriarArquivoUsandoStreamWriter();
            //CriarArquivoUsandoFileStream();
            /*var nomeDoArquivo = "contas.txt";

            using(var fluxoDoArquivo = new FileStream(nomeDoArquivo, FileMode.Open))
            {
                using(var leitor = new StreamReader(fluxoDoArquivo))
                {
                    while (!leitor.EndOfStream)
                    {
                        var linha = leitor.ReadLine();
                        var conta = ConverterStringParaContaCorrente(linha);
                        Console.WriteLine($"Titular: {conta.Titular.Nome} - Agência: {conta.Agencia} - Número: {conta.Numero} - Saldo: R${conta.Saldo}");
                    }
                }
            }*/

            Console.WriteLine("\nPressione enter para sair...");
            Console.ReadLine();
        }
    }
} 
 