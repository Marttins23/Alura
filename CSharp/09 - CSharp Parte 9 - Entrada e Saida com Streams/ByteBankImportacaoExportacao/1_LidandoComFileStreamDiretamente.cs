﻿using ByteBankImportacaoExportacao.Modelos;
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
        public static void TestaFileStream()
        {
            var enderecoDoArquivo = "contas.txt";

            using (var fluxoDoArquivo = new FileStream(enderecoDoArquivo, FileMode.Open))
            {
                var buffer = new byte[1024];

                var numeroDeBytesLidos = -1;

                while (numeroDeBytesLidos != 0)
                {
                    numeroDeBytesLidos = fluxoDoArquivo.Read(buffer, 0, 1024);
                    EscreverBuffer(buffer, numeroDeBytesLidos);
                }
            }
        }

        public static void EscreverBuffer(byte[] buffer, int bytesLidos)
        {
            var utf8 = Encoding.Default;
            var texto = utf8.GetString(buffer, 0, bytesLidos);
            Console.Write(texto);

            /*foreach(var b in buffer)
            {
                Console.Write(b);
                Console.Write(" ");
            }*/
        }
    }
}