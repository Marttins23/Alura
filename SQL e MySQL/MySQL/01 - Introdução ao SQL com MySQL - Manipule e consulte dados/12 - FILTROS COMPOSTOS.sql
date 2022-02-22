USE sucos;

SELECT * FROM tbproduto;

SELECT * FROM tbproduto WHERE PRECO_LISTA BETWEEN 7.003 AND 7.005;
SELECT * FROM tbproduto WHERE PRECO_LISTA >= 7.003 AND PRECO_LISTA <= 7.005;

SELECT * FROM tbcliente;

SELECT * FROM tbcliente WHERE IDADE >= 18 AND IDADE <= 22;

SELECT * FROM tbcliente WHERE IDADE >= 18 AND IDADE <= 22 AND SEXO = 'M';

SELECT * FROM tbcliente WHERE CIDADE = 'Rio de Janeiro' OR BAIRRO = 'Jardins';

SELECT * FROM tbcliente WHERE (IDADE >= 18 AND IDADE <= 22 AND SEXO = 'M') 
OR ('Rio de Janeiro' OR BAIRRO = 'Jardins');

SELECT * FROM tabela_de_vendedores WHERE DE_FERIAS = 1 AND YEAR (DATA_ADMISSAO) < 2016;