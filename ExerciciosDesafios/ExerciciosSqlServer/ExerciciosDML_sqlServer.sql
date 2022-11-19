--criando base de dados
CREATE DATABASE empresa_db;

--usando a base de dados empresa_db
USE empresa_db;

--criando tabela Departamento
CREATE TABLE departamentos (
	idDepartamento int NOT NULL PRIMARY KEY,
	nome varchar(50) NOT NULL,
	localizacao varchar(50) NOT NULL,
	orcamento varchar(50) NOT NULL
);

--criando tabela Empregado
CREATE TABLE empregados (
	idEmpregado int NOT NULL PRIMARY KEY,
	nome varchar(50) NOT NULL,
	idGerente int NULL,
	funcao varchar(50) NULL,
	idDepartamento int,
	dataAdmissao date NOT NULL,
	salario int NULL,
	comissao int NULL
	FOREIGN KEY (idDepartamento) REFERENCES departamentos(idDepartamento),
	FOREIGN KEY (idGerente) REFERENCES empregados(idEmpregado)
);

--inserindo dados nas tabelas
INSERT INTO departamentos VALUES('1','Banco de Dados','Porto Alegre','2346');
INSERT INTO departamentos VALUES('2','Balconistas','Pelotas','10000');
INSERT INTO departamentos VALUES('3','Intelig�ncia Artific','Pelotas','333');
INSERT INTO departamentos VALUES('4','Compiladores','Novo Hamburgo','5050');
INSERT INTO departamentos VALUES('5','Redes','Taquara','12122');
INSERT INTO empregados VALUES('1','Mariewa',NULL,'Gerente','1','2000-04-05','2300','0');
INSERT INTO empregados VALUES('2','Zico','1','Oper�rio','1','1999-08-13','100','0');
INSERT INTO empregados VALUES('3','Lula',NULL,'Presidente','5','1950-01-01','10000','0');
INSERT INTO empregados VALUES('5','Luana Pyovany',NULL,'Gerente','2','1998-06-23','2300','0');
INSERT INTO empregados VALUES('4','Vera Fixer','5','Balconista','2','1999-05-05','3300','0');
INSERT INTO empregados VALUES('6','Daniela Schicarelli',NULL,'Gerente','3','1999-10-10','2300','0');
INSERT INTO empregados VALUES('7','Luize Altenhofen',NULL,'Gerente','4','1999-04-26','2300','0');
INSERT INTO empregados VALUES('8','Helo Pinheiro',NULL,'Gerente','5','1997-09-25','2300','0');
INSERT INTO empregados VALUES('9','Pel�','1','Oper�rio','1','2000-09-09','100',NULL);
INSERT INTO empregados VALUES('10','Rom�rio','1','Oper�rio','5','2001-12-25','100','0');
INSERT INTO empregados VALUES('11','Malu Mader','5','Balconista','2','2001-10-20','3400','0');
INSERT INTO empregados VALUES('12','Ant�nio Fagundes','7','Vendedor','3','2002-12-22','5000','10');

-- Sele��o de todos os campos (ou colunas) da tabela de Departamentos.
SELECT * FROM departamentos;

-- where
--
-- Operadores l�gicos
--
-- operador significado
-- =  igual a
-- >  maior que
-- >= maior que ou igual a
-- <  menor que
-- <= menor que ou igual a

--Exemplo Operadores l�gicos
SELECT  empregados.nome, empregados.funcao FROM  empregados WHERE  empregados.idDepartamento > 3;

--Exemplo Operadores l�gicos
SELECT  empregados.nome, empregados.funcao FROM  empregados WHERE empregados.funcao = 'GERENTE';

-- Selecione todos os departamentos cujo or�amento mensal
--seja maior que 10000. Apresente o Nome de tal departamento
--e seu or�amento anual, que ser� obtido multiplicando-se o
--or�amento mensal por 12.
SELECT departamentos.nome, departamentos.orcamento * 12 FROM departamentos WHERE departamentos.orcamento > 10000;


-- Apresente a instru��o anterior por�m ao inv�s dos
--'feios' DepNome e DepOrca, os T�tulos Departamento e Or�amento.
SELECT departamentos.nome AS Departamento, departamentos.orcamento * 12 AS Or�amento FROM departamentos WHERE departamentos.orcamento > 10000;

-- Apresente todos os cargos existentes na empresa,
-- por�m omita eventuais duplicidades.
SELECT DISTINCT empregados.funcao 'Cargos Existentes' FROM empregados;

-- Apresente os nomes e fun��es da cada funcion�rio contidos
--na tabela empregado, por�m classificados alfabeticamente (A..Z)
--e depois alfabeticamente invertido (Z..A).
SELECT empregados.nome 'Nome do Empregado', empregados.funcao 'Cargo' FROM empregados Order By empregados.nome;
SELECT empregados.nome 'Nome do Empregado', empregados.funcao 'Cargo' FROM empregados Order By empregados.nome desc;

-- Demais Operadores
--
--Operador                  significado
--between  ...  and ...     entre dois valores ( inclusive )
--in ( .... )               lista de valores
--like                      com um padrao de caracteres
--is null                   � um valor nulo

--Exemplo Demais Operadores:
SELECT  empregados.nome, empregados.salario FROM  empregados WHERE  empregados.salario BETWEEN  100  AND  500;

--Exemplo Demais Operadores:
SELECT  empregados.nome,  empregados.idDepartamento FROM  empregados WHERE  empregados.idDepartamento  IN  (3,5);


--Exemplo Demais Operadores:
SELECT  empregados.nome, empregados.funcao FROM  empregados WHERE   empregados.nome  LIKE  'L%';

--Exemplo Demais Operadores:
SELECT empregados.nome, empregados.funcao FROM  empregados WHERE  empregados.comissao  IS  NULL;

-- Operadores Negativos
--
--operador               descri��o
--<>                     diferente
--not nome_coluna =      diferente da coluna
--not nome_coluna >      n�o maior que
--not between            n�o entre dois valores informados
--not in                 n�o existente numa dada lista de valores
--not like               diferente do padrao de caracteres informado
--is not null            n�o � um valor nulo

-- Selecione os Empregados cujos sal�rios sejam
--menores que 1000 ou maiores que 3500.
SELECT empregados.nome, empregados.salario FROM empregados WHERE empregados.salario > 1000 AND empregados.salario < 3500;
SELECT  empregados.nome, empregados.salario FROM  empregados WHERE  empregados.salario BETWEEN  1000  AND  3500;

-- Apresente todos os funcion�rios com sal�rios
--entre 3400 e 4000 e que sejam balconistas.
-- Operadores  'AND' (E) e  'OR' (OU).
SELECT empregados.nome, empregados.salario, empregados.funcao FROM empregados WHERE empregados.salario BETWEEN 3400 AND 4000 AND empregados.funcao = 'Balconista';

-- Apresente todos os funcion�rios com sal�rios
--entre 3400 e 4000 ou que sejam balconistas.
SELECT empregados.nome, empregados.salario, empregados.funcao FROM empregados WHERE empregados.salario BETWEEN 3400 AND 4000 OR empregados.funcao = 'Balconista';

-- Apresente o nome de todos os empregados em letras min�sculas.

        --Fun��es de Caracteres
        --Lower - 		for�a caracteres mai�sculos aparecerem em min�sculos.
        --Upper - 		for�a caracteres min�sculos aparecerem em mai�sculos.
        --Concat(x,y)- 		concatena a string 'x' com a string 'y'.
        --Substring(str,x,y) - 	extrai um substring da string 'str', come�ando em 'x', e termina em 'y'.
        --To_Char(num)- 	converte um valor num�rico para  uma string de caracteres.
        --To_Date(char,fmt)- 	converte uma string caracter em uma data.

SELECT LOWER(empregados.nome) 'Nome em Letra Min�scula' FROM empregados; 

-- Apresente o nome de todos os empregados (somente as 5 primeiras letras).
SELECT SUBSTRING(empregados.nome, 1, 5) 'Cinco Primeiras Letras' FROM empregados;

-- Fun��es Agregadas (ou de Agrupamento)
--
--fun��o        retorno
--avg(n)        m�dia do valor n, ignorando nulos
--count(expr)   vezes que o n�mero da expr avalia para algo nao nulo
--max(expr)     maior valor da expr
--min(expr)     menor valor da expr
--sum(n)	       soma dos valores de n, ignorando nulos

-- Apresente a M�dia, o Maior, o Menor e tamb�m a Somat�ria
--dos Sal�rios pagos aos empregados.
SELECT AVG(empregados.salario) 'M�dia Salarial', MAX(empregados.salario) 'Maior Sal�rio', MIN(empregados.salario) 'Menor Sal�rio', SUM(empregados.salario) 'Somat�ria dos Sal�rios'  FROM empregados;

-- Apresente a m�dia de comiss�o pagos por departamento.
SELECT empregados.idDepartamento, AVG(empregados.comissao) 'M�dia da Comiss�o' FROM empregados GROUP BY empregados.idDepartamento;

--  Retome o problema anterior, por�m apresente resposta
--apenas para departamentos com mais de 2 empregados.
SELECT  empregados.idDepartamento, AVG(empregados.comissao) 'M�dia da Comiss�o' FROM  empregados GROUP BY empregados.idDepartamento HAVING COUNT(*) > 2;

-- Listar Nomes de Empregados, Cargos e
--Nome do Departamento onde o empregado trabalha.

--neste caso, o uso de ALIAS � desnecess�rio
SELECT A.nome, A.funcao, B.nome FROM empregados AS A, departamentos AS B WHERE B.idDepartamento = A.idDepartamento;

-- Liste os C�digos de Cada Funcion�rio, seus Nomes, seus Cargos
--e o nome do Gerente ao qual este se relaciona.

-- neste caso, o uso de ALIAS � fundamental
SELECT  A.idEmpregado, A.nome, A.funcao, B.nome 'Gerente' FROM  empregados A, empregados B WHERE  A.idGerente  = B.idEmpregado;

-- execute e avalie os comandos
-- INSERT
INSERT INTO departamentos (idDepartamento, nome, localizacao, orcamento) VALUES ('6','Produ��o','Rio de Janeiro','1200');

-- UPDATE
UPDATE empregados SET empregados.salario = empregados.salario * 1.2 WHERE empregados.salario < 1000;
select empregados.salario from empregados;

-- DELETE
DELETE FROM empregados WHERE empregados.salario > 5000;

-- Relacione todos os nomes de funcion�rios e seus respectivos
--cargos, desde que o or�amento do departamento seja igual a 10000.
SELECT  A.nome, A.funcao FROM empregados A
WHERE  10000 IN (SELECT departamentos.orcamento
                  FROM departamentos
                  WHERE departamentos.idDepartamento = A.idDepartamento);

-- Relacione todos os departamentos que possuem
--empregados com remunera��o maior que 3000.
SELECT A.nome FROM departamentos A
WHERE EXISTS (SELECT * FROM empregados
              WHERE empregados.salario > 3000 AND empregados.idDepartamento = A.idDepartamento);