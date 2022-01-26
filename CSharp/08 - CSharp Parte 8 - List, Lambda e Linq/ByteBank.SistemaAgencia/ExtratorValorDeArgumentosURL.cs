using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.SistemaAgencia
{
    public class ExtratorValorDeArgumentosURL
    {
        private readonly string _argumentos;
        public string URL { get; }  
        public ExtratorValorDeArgumentosURL(string url)
        {
            if(String.IsNullOrEmpty(url))
            {
                throw new ArgumentException("O argumento URL não pode ser nulo ou vazio", nameof(url));
            }

            URL = url;

            int indiceInterrogacao = url.IndexOf('?');
            _argumentos = url.Substring(indiceInterrogacao + 1);
        }

        public string GetValor(string nomeParametro)
        {
            nomeParametro = nomeParametro.ToUpper();
            nomeParametro += "=";
            string argumentoEmCaixaAlta = _argumentos.ToUpper();
            int tamanhoParametro = nomeParametro.Length;
            int indiceParametro = argumentoEmCaixaAlta.IndexOf(nomeParametro);
            string resultado = _argumentos.Substring(indiceParametro + tamanhoParametro);

            if(resultado.Contains("&"))
            {
                int indiceEComercial = resultado.IndexOf("&");
                return resultado.Remove(indiceEComercial);
            }

            return resultado;
        }



    }
}
