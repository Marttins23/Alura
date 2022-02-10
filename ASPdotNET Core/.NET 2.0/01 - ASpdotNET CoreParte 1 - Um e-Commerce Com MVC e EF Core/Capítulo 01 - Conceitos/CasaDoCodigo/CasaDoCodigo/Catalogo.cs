namespace CasaDoCodigo
{
    public class Catalogo : ICatalogo
    {
        public List<Livro> GetLivros()
        {
            List<Livro> livros = new List<Livro>();
            livros.Add(new Livro("001", "Quem mexeu na minha Query?", 12.99m));
            livros.Add(new Livro("002", "Ficando rico com C#", 30.99m));
            livros.Add(new Livro("003", "Java Para Baixinhos", 35.99m));

            return livros;
        }
    }
}
