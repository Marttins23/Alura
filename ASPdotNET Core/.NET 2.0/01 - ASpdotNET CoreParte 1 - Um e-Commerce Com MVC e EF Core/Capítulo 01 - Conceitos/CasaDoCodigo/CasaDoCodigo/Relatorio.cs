namespace CasaDoCodigo
{
    public class Relatorio : IRelatorio
    {
        private ICatalogo Catalogo { get; }

        public Relatorio(ICatalogo catalogo)
        {
            Catalogo = catalogo;
        }

        public async Task Imprimir(HttpContext context)
        {
            foreach (var livro in Catalogo.GetLivros())
            {
                await context.Response.WriteAsync($"{livro.Codigo,-10}{livro.Nome,-40}{livro.Preco,10}\r\n");
            }
        }
    }
}
