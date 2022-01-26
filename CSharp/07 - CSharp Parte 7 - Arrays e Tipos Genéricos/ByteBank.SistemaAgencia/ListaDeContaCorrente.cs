using ByteBank.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.SistemaAgencia
{
    public class ListaDeContaCorrente
    {
        private ContaCorrente[] _contas;
        public ContaCorrente[] Contas 
        { 
            get
            {
                ContaCorrente[] arrayCopia = new ContaCorrente[_contas.Length];
                for(int i = 0; i < _contas.Length; i++)
                {
                    arrayCopia[i] = _contas[i];
                }

                return arrayCopia;
            }
        }
        
        private int _proximaPosicao;

        public int Tamanho 
        { 
            get 
            { 
                return _proximaPosicao; 
            }
        }

        //Argumento opcional (valor padrão de 'tamanho' será 3).
        public ListaDeContaCorrente(int tamanho = 3)
        {
            _contas = new ContaCorrente[tamanho];
            _proximaPosicao = 0;
        }

        //Se quisermos chamar esse método e manter o valor padrão de apenas
        //Um dos argumentos, mas mudando o valor do outro, basta usar
        //Argumentos nomeados.
        //lista.MeuMetodo(item: 10); ou
        //lista.MeuMetodo(texto: "jhftry");
        //Podemos também usar os Argumentos Nomeados para qualquer método.
        public void MeuMetodo(string texto = "abcde", int numero = 5)
        {

        }

        public void VerificarCapacidade(int tamanhoNecessario)
        {
            if(_contas.Length >= tamanhoNecessario)
            {
                return;
            }

            int novoTamanho = _contas.Length * 2;
            if(novoTamanho < tamanhoNecessario)
            {
                novoTamanho = tamanhoNecessario;
            }

            ContaCorrente[] novoArray = new ContaCorrente[novoTamanho];

            for(int i = 0; i < _contas.Length; i++)
            {
                novoArray[i] = _contas[i];
            }

            _contas = novoArray;
        }

        public void ImprimeContas()
        {
            for (int i = 0; i < _proximaPosicao; i++)
            {
                Console.WriteLine($"Conta no índice {i}: " + _contas[i].ToString());
            }
        }

        public void Adicionar(ContaCorrente conta)
        {
            VerificarCapacidade(_proximaPosicao + 1);            
            
            _contas[_proximaPosicao] = conta;
            _proximaPosicao++;
        }

        public void Remover(ContaCorrente conta)
        {
            int posicaoDoItem = -1;

            for(int i = 0; i < _proximaPosicao; i++)
            {
                if(_contas[i].Equals(conta))
                {
                    posicaoDoItem = i;
                    break;
                }
            }

            for (int i = posicaoDoItem; i < _proximaPosicao - 1; i++)
            {
                _contas[i] = _contas[i + 1];
            }

            _proximaPosicao--;
            _contas[_proximaPosicao] = null;
        }

        public ContaCorrente GetConta(int indice)
        {
            if(indice >= _proximaPosicao || indice < 0)
            {
                throw new ArgumentException($"Valor incorreto. ", nameof(indice));
            }
            return _contas[indice];
        }

        //Criando Indexadores
        public ContaCorrente this[int indice]
        {
            get
            {
                return GetConta(indice);
            }
        }

        public void AdicionarVarios(params ContaCorrente[] contas)
        {
            foreach (ContaCorrente conta in contas)
            {
                Adicionar(conta);
            }
        }
    }
}
