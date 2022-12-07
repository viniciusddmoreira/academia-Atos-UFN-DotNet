create database crud_db;

use crud_db;

create login usuario with password='senha';
create user usuario from login usuario;
exec sp_addrolemember 'DB_DATAREADER', 'usuario';
exec sp_addrolemember 'DB_DATAWRITER', 'usuario';

create table programadores  (
id INT NOT NULL IDENTITY,
nome VARCHAR(45) NOT NULL,
linguagem VARCHAR(45) NOT NULL,
banco VARCHAR(45) NOT NULL,

  PRIMARY KEY (id)
);