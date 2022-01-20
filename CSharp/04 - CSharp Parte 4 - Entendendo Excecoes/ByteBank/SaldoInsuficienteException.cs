using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    internal class SaldoInsuficienteException : OperacaoFinanceiraException
    {

        public double Saldo { get; }
        public double ValorSaque { get; }

        public SaldoInsuficienteException()
        {

        }

        public SaldoInsuficienteException(string mensagem) : base(mensagem)
        {
           
        }

        public SaldoInsuficienteException(string mensagem, Exception excecaoInterna) 
            : base(mensagem, excecaoInterna)
        {

        }

        public SaldoInsuficienteException(double saldo, double valorSaque) :
            this("Não foi possível realizar a operação de saque no valor de R$" + valorSaque + "." +
                " Esta conta possui R$" + saldo + " disponíveis.")
        {
            Saldo = saldo;
            ValorSaque = valorSaque;
        }

    }
}
