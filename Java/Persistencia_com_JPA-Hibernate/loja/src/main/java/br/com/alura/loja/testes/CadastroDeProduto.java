package br.com.alura.loja.testes;

import br.com.alura.loja.dao.CategoriaDao;
import br.com.alura.loja.dao.ProdutoDao;
import br.com.alura.loja.modelo.Categoria;
import br.com.alura.loja.modelo.Produto;
import br.com.alura.loja.util.JPAUtil;

import javax.persistence.EntityManager;
import java.math.BigDecimal;
import java.util.List;

public class CadastroDeProduto {

    private static EntityManager em;
    private static ProdutoDao produtoDao;
    private static CategoriaDao categoriaDao;

    public static void main(String[] args) {
        cadastrarProduto();
        buscarProdutoPorId(1L);
        buscarTodosOsProdutos();
        buscarProdutosPorNome();
        buscarProdutosPorCategoria("CELULARES");
        buscarPrecoProdutoPorNome("Xiaomi Redmi");
    }

    private static void cadastrarProduto() {
        Categoria celulares = new Categoria("CELULARES");
        Produto celular = new Produto(
            "Xiaomi Redmi",
            "Muito legal",
            new BigDecimal("800"),
            celulares
        );

        iniciaEmEDaos();
        JPAUtil.beginTransaction(em);

        categoriaDao.cadastrar(celulares);
        produtoDao.cadastrar(celular);

        JPAUtil.commitAndCloseConnection(em);
    }

    private static void buscarPrecoProdutoPorNome(String nomeProduto) {
        iniciaEmEDaos();
        BigDecimal precoProduto = produtoDao.buscarPrecoProdutoPorNome(nomeProduto);
        System.out.println("Preço do Produto: R$" + precoProduto);
    }

    private static void buscarProdutosPorCategoria(String nomeCategoria) {
        iniciaEmEDaos();
        List<Produto> produtos = produtoDao.buscarPorCategoria(nomeCategoria);
        exibeNomeProdutos(produtos);
    }

    private static void buscarProdutosPorNome() {
        iniciaEmEDaos();
        List<Produto> produtos = produtoDao.buscarPorNome("Xiaomi Redmi");
        exibeNomeProdutos(produtos);
    }

    private static void buscarTodosOsProdutos() {
        iniciaEmEDaos();
        List<Produto> produtos = produtoDao.buscarTodos();
        exibeNomeProdutos(produtos);
    }

    private static void exibeNomeProdutos(List<Produto> produtos) {
        produtos.forEach(p -> System.out.println(p.getNome() + '\n'));
    }

    private static void buscarProdutoPorId(Long id) {
        iniciaEmEDaos();
        Produto p = produtoDao.buscarPorId(1L);
        System.out.println(p.getPreco());
    }

    private static void iniciaEM() {
        em = JPAUtil.getEntityManager();
    }

    private static void iniciaProdutoDao() {
        produtoDao = new ProdutoDao(em);
    }

    private static void iniciaCategoriaDao() {
        categoriaDao = new CategoriaDao(em);
    }

    private static void iniciaEmEDaos() {
        iniciaEM();
        iniciaProdutoDao();
        iniciaCategoriaDao();
    }

}
