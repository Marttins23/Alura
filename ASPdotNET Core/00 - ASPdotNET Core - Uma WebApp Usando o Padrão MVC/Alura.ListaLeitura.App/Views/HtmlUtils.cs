using System.IO;

namespace Alura.ListaLeitura.App.HTML
{
    public class HtmlUtils
    {
        public static string CarregaArquivoHTML(string str)
        {
            var caminhoDoArquivo = $"HTML/{str}.html";
            using (var arquivo = File.OpenText(caminhoDoArquivo))
            {
                return arquivo.ReadToEnd();
            }
        }
    }
}
