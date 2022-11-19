-- script para o banco de dados glicemia_db

--criando base de dados
CREATE DATABASE glicemia_db;

--mostrando todos os nomes dos bancos de dados existentes
SELECT name FROM sys.databases;  

--usando a base de dados empresa_db
USE glicemia_db;

-- criando a tabela Paciente
CREATE TABLE pacientes (
  id_paciente int IDENTITY PRIMARY KEY,
  nome varchar(45) NOT NULL,
  email varchar(45) NOT NULL,
);

-- inserindo pacientes
INSERT INTO pacientes VALUES('Alexandre Zamberlan','alexz@ufn.edu.br');
INSERT INTO pacientes VALUES('Eduardo Palharini','eduardo@ufn.edu.br');
INSERT INTO pacientes VALUES('Flavia Falotico','flavinha@ufn.edu.br');

-- exibindo pacientes
SELECT * FROM pacientes;

-- criando a tabela Medidas de Glicemia
CREATE TABLE medidas_glicemia (
  id_medida_glicemia INT NOT NULL IDENTITY PRIMARY KEY,
  valor_glicemia INT NOT NULL,
  data_medida DATE NOT NULL,
  id_paciente INT NOT NULL,
FOREIGN KEY (id_paciente) REFERENCES pacientes (id_paciente)
);

-- inserindo medidas de glicemia
INSERT INTO medidas_glicemia VALUES('159','2022-06-10','1');
INSERT INTO medidas_glicemia VALUES('121','2022-06-11','1');
INSERT INTO medidas_glicemia VALUES('98','2022-06-12','1');
INSERT INTO medidas_glicemia VALUES('119','2022-06-13','1');
INSERT INTO medidas_glicemia VALUES('109','2022-06-14','1');
INSERT INTO medidas_glicemia VALUES('89','2022-06-10','2');
INSERT INTO medidas_glicemia VALUES('91','2022-06-11','2');
INSERT INTO medidas_glicemia VALUES('98','2022-06-12','2');
INSERT INTO medidas_glicemia VALUES('83','2022-06-13','2');
INSERT INTO medidas_glicemia VALUES('100','2022-06-14','2');

-- exibindo toda tabela de medidas de glicemia
SELECT * FROM medidas_glicemia;