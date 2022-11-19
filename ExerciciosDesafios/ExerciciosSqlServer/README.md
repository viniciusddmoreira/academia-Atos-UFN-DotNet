
Crie o banco de dados empresa_db por meio do SQL Server Management Studio.

Nele, crie também as tabelas:

        departamento(idDepartamento,nome,localizacao,orcamento)
        idDepartamento chave primária

        empregado(idEmpregado,nome,idGerente,funcao,idDepartamento,dataAdmissao,salario,comissao)
        idEmpregado chave primária 
        idDepartamento referencia departamento 
        idGerente referencia empregado

Após, insere nas tabelas os seguintes valores:

        --inserindo dados nas tabelas
        INSERT INTO Departamento VALUES('1','Banco de Dados','Porto Alegre','2346');
        INSERT INTO Departamento VALUES('2','Balconistas','Pelotas','10000');
        INSERT INTO Departamento VALUES('3','Inteligência Artific','Pelotas','333');
        INSERT INTO Departamento VALUES('4','Compiladores','Novo Hamburgo','5050');
        INSERT INTO Departamento VALUES('5','Redes','Taquara','12122');

        INSERT INTO Empregado VALUES('1','Mariewa',NULL,'Gerente','1','2000-04-05','2300','0');
        INSERT INTO Empregado VALUES('2','Zico','1','Operário','1','1999-08-13','100','0');
        INSERT INTO Empregado VALUES('3','Lula',NULL,'Presidente','5','1950-01-01','10000','0');
        INSERT INTO Empregado VALUES('5','Luana Pyovany',NULL,'Gerente','2','1998-06-23','2300','0');
        INSERT INTO Empregado VALUES('4','Vera Fixer','5','Balconista','2','1999-05-05','3300','0');
        INSERT INTO Empregado VALUES('6','Daniela Schicarelli',NULL,'Gerente','3','1999-10-10','2300','0');
        INSERT INTO Empregado VALUES('7','Luize Altenhofen',NULL,'Gerente','4','1999-04-26','2300','0');
        INSERT INTO Empregado VALUES('8','Helo Pinheiro',NULL,'Gerente','5','1997-09-25','2300','0');
        INSERT INTO Empregado VALUES('9','Pelé','1','Operário','1','2000-09-09','100',NULL);
        INSERT INTO Empregado VALUES('10','Romário','1','Operário','5','2001-12-25','100','0');
        INSERT INTO Empregado VALUES('11','Malu Mader','5','Balconista','2','2001-10-20','3400','0');
        INSERT INTO Empregado VALUES('12','Antônio Fagundes','7','Vendedor','3','2002-12-22','5000','10');


Finalmente, execute os comandos no shell do Management Studio:

-- Seleção de todos os campos (ou colunas) da tabela de Departamentos.<br/>
select * from departamento;

            -- where
            --
            -- Operadores lógicos
            --
            -- operador significado
            -- =  igual a
            -- >  maior que
            -- >= maior que ou igual a
            -- <  menor que
            -- <= menor que ou igual a


-- Selecione todos os departamentos cujo orçamento mensal<br/>
--seja maior que 10000. Apresente o Nome de tal departamento<br/>
--e seu orçamento anual, que será obtido multiplicando-se o<br/>
--orçamento mensal por 12.


-- Apresente a instrução anterior porém ao invés dos<br/>
--'feios' DepNome e DepOrca, os Títulos Departamento e Orçamento.


-- Apresente todos os cargos existentes na empresa,<br/>
-- porém omita eventuais duplicidades.


-- Apresente os nomes e funções da cada funcionário contidos<br/>
--na tabela empregado, porém classificados alfabeticamente (A..Z)<br/>
--e depois alfabeticamente invertido (Z..A).

        -- Demais Operadores
        --
        --Operador                  significado
        --between  ...  and ...     entre dois valores ( inclusive )
        --in ( .... )               lista de valores
        --like                      com um padrao de caracteres
        --is null                   é um valor nulo


        -- Operadores Negativos
        --
        --operador               descrição
        --<>                     diferente
        --not nome_coluna =      diferente da coluna
        --not nome_coluna >      não maior que
        --not between            não entre dois valores informados
        --not in                 não existente numa dada lista de valores
        --not like               diferente do padrao de caracteres informado
        --is not null            não é um valor nulo

-- Selecione os Empregados cujos salários sejam<br/>
--menores que 1000 ou maiores que 3500.

-- Apresente todos os funcionários com salários<br/>
--entre 3400 e 4000 e que sejam balconistas.

    -- Operadores  'AND' (E) e  'OR' (OU).


-- Apresente todos os funcionários com salários<br/>
--entre 3400 e 4000 ou que sejam balconistas.

-- Apresente o nome de todos os empregados em letras minúsculas.

        --Funções de Caracteres
        --Lower - 		força caracteres maiúsculos aparecerem em minúsculos.
        --Upper - 		força caracteres minúsculos aparecerem em maiúsculos.
        --Concat(x,y)- 		concatena a string 'x' com a string 'y'.
        --Substring(x,y,str)- 	extrai um substring da string 'str', começando em 'x', e termina em 'y'.
        --To_Char(num)- 	converte um valor numérico para  uma string de caracteres.
        --To_Date(char,fmt)- 	converte uma string caracter em uma data.


-- Apresente o nome de todos os empregados (somente as 5 primeiras letras).

-- Apresente a Média, o Maior, o Menor e também a Somatória<br/>
--dos Salários pagos aos empregados.

        -- Funções Agregadas (ou de Agrupamento)
        --
        --função        retorno
        --avg(n)        média do valor n, ignorando nulos
        --count(expr)   vezes que o número da expr avalia para algo nao nulo
        --max(expr)     maior valor da expr
        --min(expr)     menor valor da expr
        --sum(n)	       soma dos valores de n, ignorando nulos


-- Apresente a média de comissão pagos por departamento.


--  Retome o problema anterior, porém apresente resposta<br/>
--apenas para departamentos com mais de 2 empregados.


-- Listar Nomes de Empregados, Cargos e<br/>
--Nome do Departamento onde o empregado trabalha.


--neste caso, o uso de ALIAS é desnecessário


-- Liste os Códigos de Cada Funcionário, seus Nomes, seus Cargos<br/>
--e o nome do Gerente ao qual este se relaciona.

-- neste caso, o uso de ALIAS é fundamental




-- execute e avalie os comandos<br/>
-- INSERT<br/>
INSERT INTO Departamento (idDepartamento, nome, localizacao, orcamento) VALUES ('70','PRODUCAO','RIO DE JANEIRO','1200');

-- UPDATE<br/>
UPDATE Empregado <br/>
SET Empregado.salario = Empregado.salario* 1.2 <br/>
WHERE Empregado.salario< 1000;

-- DELETE<br/>
DELETE FROM Empregado<br/>
WHERE Empregado.salario > 5000;


-- Relacione todos os nomes de funcionários e seus respectivos<br/>
--cargos, desde que o orçamento do departamento seja igual a 10000.


-- Relacione todos os departamentos que possuem<br/>
--empregados com remuneração maior que 3000.
