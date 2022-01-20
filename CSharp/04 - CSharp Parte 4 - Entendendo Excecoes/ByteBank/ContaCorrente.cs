// using _05_ByteBank;

using System;

namespace ByteBank
{
    public class ContaCorrente
    {
        public static double TaxaOperacao { get; private set; }
        public Cliente Titular { get; set; }

        public static int TotalDeContasCriadas { get; private set; }

        public int Agencia { get; }
        public int Numero { get; }

        private double _saldo = 100;

        public double Saldo
        {
            get
            {
                return _saldo;
            }
            set
            {
                if (value < 0)
                {
                    return;
                }

                _saldo = value;
            }
        }

        public int ContadorDeSaquesNaoPermitidos { get; private set; }

        public int ContadorDeTransferenciasNaoPermitidas { get; private set; }


        public ContaCorrente(int agencia, int numero)
        {
            if(agencia <= 0 )
            {
                throw new ArgumentException("O argumento 'agencia' deve ser maior que 0.", nameof(Agencia));
            }

            if(numero <= 0 )
            {
                throw new ArgumentException("O argumento 'numero' deve ser maior que 0.", nameof(Numero));
            }

            Agencia = agencia;
            Numero = numero;

            //TaxaOperacao = 30 / TotalDeContasCriadas;

            TotalDeContasCriadas++;
        }


        public void Sacar(double valor)
        {
            if(valor < 0)
            {
                throw new ArgumentException("O valor do saque não pode ser menor que 0.", nameof(valor));
            }
            if (_saldo < valor)
            {
                ContadorDeSaquesNaoPermitidos++;
                throw new SaldoInsuficienteException(Saldo, valor);
            }

            _saldo -= valor;
        }

        public void Depositar(double valor)
        {
            if (valor < 0)
            {
                throw new ArgumentException("O valor do depósito não pode ser menor que 0.", nameof(valor));
            }

            Saldo += valor;
        }


        public void Transferir(double valor, ContaCorrente contaDestino)
        {
            if (valor < 0)
            {
                throw new ArgumentException("O valor da transferência não pode ser menor que 0.", nameof(valor));
            }

            try
            {
                Sacar(valor);
            }
            catch (SaldoInsuficienteException ex)
            {
                ContadorDeTransferenciasNaoPermitidas++;
                throw new OperacaoFinanceiraException("A transferência não pode ser realizada. ", ex);
            }
            contaDestino.Depositar(valor);
        }
    }
}
