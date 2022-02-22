USE SUCOS;

INSERT INTO tbproduto (
PRODUTO,  NOME, EMBALAGEM, TAMANHO, SABOR,
PRECO_LISTA) VALUES
('544931', 'Frescor do Verão - 350 ml - Limão', 'PET', '350 ml','Limão',3.20);

INSERT INTO tbproduto (
PRODUTO,  NOME, EMBALAGEM, TAMANHO, SABOR,
PRECO_LISTA) VALUES
('1078680', 'Frescor do Verão - 470 ml - Manga', 'Lata', '470 ml','Manga',5.18);

UPDATE tbProduto SET EMBALAGEM = 'Lata', PRECO_LISTA = 2.46
WHERE PRODUTO = '544931';

UPDATE tbProduto SET EMBALAGEM = 'Garrafa' 
WHERE PRODUTO = '1078680';

SELECT * FROM tbProduto;

UPDATE tabela_de_vendedores SET PERCENTUAL_COMISSAO = 0.11
WHERE MATRICULA = '00236';

UPDATE tabela_de_vendedores SET 
NOME = 'José Geraldo da Fonseca Junior', 
PERCENTUAL_COMISSAO = 0.08 WHERE MATRICULA = '00233';

UPDATE tabela_de_vendedores SET PERCENTUAL_COMISSAO = 0.08
WHERE MATRICULA = '00235';

SELECT * FROM tabela_de_vendedores;