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
        public static void CriarArquivoUsandoFileStream()
        {
            var caminhoDoArquivo = "contasExportadas.csv";

            using(var fluxoDeArquivo = new FileStream(caminhoDoArquivo, FileMode.Create))
            {
                string contaComoString = "865,76854,3500.86,Mateus Ferreira";
                var encoding = Encoding.UTF8;
                var bytes = encoding.GetBytes(contaComoString);
                
                fluxoDeArquivo.Write(bytes, 0, bytes.Length);
            }
        }

        public static void CriarArquivoUsandoStreamWriter()
        {
            var caminhoDoArquivo = "contasExportadas.csv";

            using (var fluxoDeArquivo = new FileStream(caminhoDoArquivo, FileMode.Create))
            using (var escritor = new StreamWriter(fluxoDeArquivo, Encoding.UTF8))
            {
                escritor.Write("834,34526,500.90,João Moreira");
            }
        }

        public static void TestaFlush()
        {
            using (var fs = new FileStream("teste_flush.txt", FileMode.Create))
            using (var escritor  = new StreamWriter(fs))
            {
                for(int i = 0; i < 10; i++)
                {
                    escritor.WriteLine($"Linha {i}");
                    //O flush descarrega o buffer para oStream, gravando no arquivo imediatamente.
                    escritor.Flush();
                    Console.WriteLine($"A linha {i} foi gravada. Tecle enter para gravar mais uma!");
                    Console.ReadLine();
                }
            }
        }


    }
}