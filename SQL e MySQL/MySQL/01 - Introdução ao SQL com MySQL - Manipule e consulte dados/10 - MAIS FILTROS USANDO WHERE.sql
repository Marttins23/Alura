USE sucos;

SELECT * FROM tbproduto WHERE PRODUTO = '544931';

SELECT * FROM tbcliente WHERE CIDADE = 'Rio de Janeiro';

SELECT * FROM tbproduto WHERE SABOR = 'Limão';

UPDATE tbproduto SET SABOR = 'Limão' WHERE SABOR = 'Citrus';

SELECT * FROM tabela_de_vendedores WHERE NOME = 'Claudia Morais';

SELECT * FROM tbcliente WHERE IDADE = 22;

/* <> Significa DIFERENTE */
SELECT * FROM tbcliente WHERE IDADE <> 22;

SELECT * FROM tbcliente WHERE IDADE > 22;

SELECT * FROM tbcliente WHERE IDADE < 22;

SELECT * FROM tbcliente WHERE IDADE >= 22;

SELECT * FROM tbcliente WHERE NOME = 'Fernando Cavalcante';

/* Seleciona os maiores (alfabeticamente) */
SELECT * FROM tbcliente WHERE NOME > 'Fernando Cavalcante';

SELECT * FROM tbcliente WHERE NOME >= 'Fernando Cavalcante';

SELECT * FROM tbcliente WHERE NOME < 'Fernando Cavalcante';

/* Não vai encontrar o item, pois float não pode ser pesquisado
	utilizando os operadores = ou >= ou <= ou <>*/
SELECT * FROM tbproduto WHERE PRECO_LISTA = 7.004;

SELECT * FROM tbproduto WHERE PRECO_LISTA <> 7.004;

/* Para pesquisar um float pelo valor exato, devemos usar o 
	BETWEEN */
SELECT * FROM tbproduto WHERE PRECO_LISTA BETWEEN 7.003 AND 7.005;

SELECT * FROM tbproduto WHERE PRECO_LISTA > 7.004;

SELECT * FROM tbproduto WHERE PRECO_LISTA < 7.004;

SELECT * FROM tabela_de_vendedores WHERE PERCENTUAL_COMISSAO > 0.10;
