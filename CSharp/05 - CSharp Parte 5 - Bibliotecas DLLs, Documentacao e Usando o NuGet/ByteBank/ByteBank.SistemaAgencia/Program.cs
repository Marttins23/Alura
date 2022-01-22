using ByteBank.Modelos;
using ByteBank.Modelos.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {

            ContaCorrente conta = new ContaCorrente(865, 865748);

            Console.WriteLine(conta.Numero);

            FuncionarioAutenticavel mateus = new GerenteDeConta("104.488.306-55"); 

            Console.WriteLine("\nPressione enter para sair...");
            Console.ReadLine();
            
        }
    }
}
