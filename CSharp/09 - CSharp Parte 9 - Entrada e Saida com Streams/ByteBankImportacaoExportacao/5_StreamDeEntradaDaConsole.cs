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
        public static void StreamDeEntrada()
        {
            using (var fluxoDeEntrada = Console.OpenStandardInput())
            using (var fs = new FileStream("entradaConsole.txt", FileMode.Create))
            {
                var buffer = new byte[1024];

                while(true)
                {
                    Console.WriteLine("Digite a frase que deseja salvar no arquivo...");
                    var bytesLidos = fluxoDeEntrada.Read(buffer, 0, buffer.Length);
                    fs.Write(buffer, 0, bytesLidos);
                    fs.Flush();
                    Console.WriteLine("Frase gravada com sucesso!");
                }
            }
        }

    }
}
