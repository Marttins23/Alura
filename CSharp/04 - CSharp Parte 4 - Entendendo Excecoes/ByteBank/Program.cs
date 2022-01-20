using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                CarregarContas();
            }
            catch (Exception ex) 
            {
                Console.WriteLine("Catch capturado na MAIN.");
            }

            Console.WriteLine("\nPressione enter para sair...");
            Console.ReadLine();
        }

        private static void CarregarContas()
        {
            using (LeitorDeArquivo leitor = new LeitorDeArquivo("teste.txt"))
            {
                leitor.LerProximaLinha();
            }

            // -------------------------------------------------------------------------

            //LeitorDeArquivo leitor = null;

            //try
            //{
            //    leitor = new LeitorDeArquivo("contas.txt");

            //    leitor.LerProximaLinha();
            //    leitor.LerProximaLinha();
            //    leitor.LerProximaLinha();
            //    leitor.LerProximaLinha();
            //}
            //catch (IOException ex)
            //{
            //    Console.WriteLine("Exceção do tipo IOException capturada e tratada!");
            //}
            //finally
            //{
            //    if(leitor != null)
            //    {
            //        leitor.Fechar();
            //    }
                
            //}   
        }

        private static void TestaInnerException()
        {
            try
            {
                ContaCorrente conta = new ContaCorrente(865, 865743);
                ContaCorrente conta2 = new ContaCorrente(854, 854643);
                //conta.Transferir(500, conta2);
                conta.Sacar(500);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);

                //Console.WriteLine("\nInformações da Inner Exception: ");
                //Console.WriteLine(ex.InnerException.Message);
                //Console.WriteLine(ex.InnerException.StackTrace);

            }
        }

        private static void Metodo()
        {
            TestaDivisao(0);
        }

        private static void TestaDivisao(int divisor)
        {
            
            int resultado = Dividir(10, divisor);
            Console.WriteLine("Resultado da divisão de 10 por " + divisor + " é " + resultado);
           
        }

        private static int Dividir(int numero, int divisor)
        {
            try
            {
                return numero / divisor;
            }
            catch(DivideByZeroException)
            {
                Console.WriteLine("Exceção com número = " + numero + " e divisor = " + divisor);
                throw;
            }
            
        }
    }
}
