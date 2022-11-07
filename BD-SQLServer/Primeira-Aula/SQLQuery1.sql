

-- SQL

--DML e DDL 

--DDL - Data definition Language{
-- Definição de dados, estrutura que vai receber os dados.

-- CREATE
-- ALTER
-- DROP

--DATABASES OU Tables
--}


--DML - Data Manipulation Language
--INSERT UPDATE DELETE

--Criar um banco de dados
-- se tem um código selecionado ele ignora todo o resto.

--CRIAR UM BANCO DE DADOS

CREATE DATABASE atosUfn

--CRIANDO UMA TABELA
CREATE TABLE ALUNOS
(
  MATRICULA VARCHAR(12) PRIMARY KEY,
  NOME VARCHAR(50) not null, -- not null, valor é obrigado a ser inserido
  CURSO VARCHAR(8) not null,
  TURNO VARCHAR(25),
  IDADE INTEGER, --INTEGER GARANTIA QUE FUNCIONA EM QUALQUER BANCO DE DADOS
  ESTADO VARCHAR(2) --VARCHAR É A STRING NO BANCO DE DADOS -- LIMITADO A 2 CARACTERES
)

--remover uma table 
-- drop serve tanto para tabela quanto para database
DROP table ALUNOS;


--alter
ALTER TABLE ALUNOS ADD ALTURA INTEGER
ALTER TABLE ALUNOS DROP COLUMN IDADE;

---------------------------------------------------------------------

CREATE TABLE AUTORES
(
   id INTEGER PRIMARY KEY IDENTITY, -- identity auto-incremente
	nome VARCHAR(50) not null,
	nacionaldiade VARCHAR(30)
)

CREATE TABLE LIVROS
(
  id INTEGER PRIMARY KEY IDENTITY,
  titulo VARCHAR(100) not null,
  paginas INTEGER,
  fk_autor INTEGER,
  FOREIGN KEY (fk_autor) references AUTORES(id)
)

--não posso dropar uma tabela que outra dependa dela, primeiro dropo a que tem a referencia e depois a tabela em questao