﻿namespace _07_ByteBank
{
    public class ContaCorrente
    {
        public Cliente Titular { get; set; }

        private int _agencia;
        public static int TotalDeContasCriadas { get; private set; }

        public int Agencia 
        {
            get 
            { 
                return this._agencia;
            }
            set
            {
                if(value <= 0)
                {
                    return;
                }

                this._agencia = value;
            }
        }    
        public int Numero { get; set; }
        private double _saldo = 100;

        public double Saldo
        {
            get
            {
                return this._saldo;
            }

            set
            {
                if (value < 0)
                {
                    return;
                }
                this._saldo = value;
            }
        }

        public ContaCorrente(int agencia, int numero)
        {
            Agencia = agencia;
            Numero = numero;
            TotalDeContasCriadas++;
        } 

        public bool Sacar(double valor)
        {
            if (this._saldo < valor)
            {
                return false;
            }

            this._saldo -= valor;
            return true;

        }
        public void Depositar(double valor)
        {
            this._saldo += valor;
        }

        public bool Transferir(double valor, ContaCorrente contaDestino)
        {
            if (this._saldo < valor)
            {
                return false;
            }

            this._saldo -= valor;
            contaDestino.Depositar(valor);
            return true;

        }
    }
}