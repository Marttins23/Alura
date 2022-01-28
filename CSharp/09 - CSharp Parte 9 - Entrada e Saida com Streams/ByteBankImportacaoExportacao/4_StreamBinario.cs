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
        public static void EscritaBinaria()
        {
            using (var fs = new FileStream("contaCorrenteBinaria.txt", FileMode.Create)) 
            using (var escritor = new BinaryWriter(fs))
            {
                escritor.Write(865);
                escritor.Write(865756);
                escritor.Write(430.54);
                escritor.Write("Mateus Ferreira");
            }
        }

        public static void LeituraBinaria()
        {
            using (var fs = new FileStream("contaCorrenteBinaria.txt", FileMode.Open))
            using (var leitor = new BinaryReader(fs))
            {
                var agencia = leitor.ReadInt32();
                var numero = leitor.ReadInt32();
                var saldo = leitor.ReadDouble();
                var titular = leitor.ReadString();

                Console.WriteLine($"Titular: {titular} - Agência: {agencia} - Número: {numero} - Saldo: R${saldo}");
            }
        }
    }
}
