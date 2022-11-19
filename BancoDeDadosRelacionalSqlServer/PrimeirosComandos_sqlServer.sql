--SQL
--DML e DDL

--DDL - Data Definition Language
--CREATE
--ALTER
--DROP

--DATABASES ou TABLE

--Cria um banco de dados
CREATE DATABASE atosUfn_db;

--Seleciona o banco de dados a ser usado
USE atosUfn_db;

--Cria uma tabela
CREATE TABLE alunos 
(
	matricula varchar(12) PRIMARY KEY,
	nome varchar(50) NOT NULL,
	curso varchar(20) NOT NULL,
	turno varchar(25),
	idade int,
	estado varchar(2) --É A STRING NO BANCO DE DADOS -- LIMITADO A 2 CASAS
);

--Remove uma tabela
DROP TABLE alunos;

--Altera uma tabela
ALTER TABLE alunos ADD altura INTEGER;
ALTER TABLE alunos DROP COLUMN idade;

----------------------------------------
CREATE TABLE autores
(
	id int IDENTITY PRIMARY KEY,
	nome varchar(100) NOT NULL,
	nacionalidade varchar(30)
);

CREATE TABLE livros
(
	id int IDENTITY PRIMARY KEY,
	titulo varchar(100) NOT NULL,
	paginas int,
	fk_autor int,
	FOREIGN KEY (fk_autor) REFERENCES autores(id)
);

--Exclui uma tabela
DROP TABLE livros;
DROP TABLE autores;