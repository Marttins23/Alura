using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ByteBank.SistemaAgencia
{
    public static class ExpressaoRegular
    {
        public static string RetornaPadrao(string padrao, string texto)
        {
            //Para capturar um número de telefone no formato XXXX-XXXX
            //ou XXXXX-XXXX, podemos utilizar os seguintes padrão de
            //Expressões Regulares:
            // "[0123456789][0123456789][0123456789][0123456789][-][0123456789][0123456789][0123456789][0123456789]"
            // "[0-9][0-9][0-9][0-9][-][0-9][0-9][0-9][0-9]"
            // "[0-9]{4,5}[-][0-9]{4}"
            // "[0-9]{4,5}[-]{0,1}[0-9]{4}"
            // "[0-9]{4,5}-{0,1}[0-9]{4}"
            // "[0-9]{4,5}-?[0-9]{4}"

            Match resultado = Regex.Match(texto, padrao);

            return resultado.Value;

        }

    }
}
