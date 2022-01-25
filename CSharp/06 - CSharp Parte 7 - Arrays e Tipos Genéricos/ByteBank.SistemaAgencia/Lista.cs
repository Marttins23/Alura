using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.SistemaAgencia
{
    public class Lista<T>
    {
        private T[] _itens;
        public T[] Itens
        {
            get
            {
                T[] arrayCopia = new T[_itens.Length];
                for (int i = 0; i < _itens.Length; i++)
                {
                    arrayCopia[i] = _itens[i];
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
        public Lista(int tamanho = 3)
        {
            _itens = new T[tamanho];
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
            if (_itens.Length >= tamanhoNecessario)
            {
                return;
            }

            int novoTamanho = _itens.Length * 2;
            if (novoTamanho < tamanhoNecessario)
            {
                novoTamanho = tamanhoNecessario;
            }

            T[] novoArray = new T[novoTamanho];

            for (int i = 0; i < _itens.Length; i++)
            {
                novoArray[i] = _itens[i];
            }

            _itens = novoArray;
        }

        public void ImprimeItens()
        {
            for (int i = 0; i < _proximaPosicao; i++)
            {
                Console.WriteLine($"Item no índice {i}: " + _itens[i].ToString());
            }
        }

        public void Adicionar(T item)
        {
            VerificarCapacidade(_proximaPosicao + 1);

            _itens[_proximaPosicao] = item;
            _proximaPosicao++;
        }

        public void Remover(T item)
        {
            int posicaoDoItem = -1;

            for (int i = 0; i < _proximaPosicao; i++)
            {
                if (_itens[i].Equals(item))
                {
                    posicaoDoItem = i;
                    break;
                }
            }

            for (int i = posicaoDoItem; i < _proximaPosicao - 1; i++)
            {
                _itens[i] = _itens[i + 1];
            }

            _proximaPosicao--;
            //_contas[_proximaPosicao] = null;
        }

        public T GetItem(int indice)
        {
            if (indice >= _proximaPosicao || indice < 0)
            {
                throw new ArgumentException($"Valor incorreto. ", nameof(indice));
            }
            return _itens[indice];
        }

        //Criando Indexadores
        public T this[int indice]
        {
            get
            {
                return GetItem(indice);
            }
        }

        public void AdicionarVarios(params T[] itens)
        {
            foreach (T item in itens)
            {
                Adicionar(item);
            }
        }
    }
}
