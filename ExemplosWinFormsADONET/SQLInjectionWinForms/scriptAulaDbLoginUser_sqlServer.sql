CREATE DATABASE aula_db;

USE aula_db;

create table pessoas
(
    id integer IDENTITY PRIMARY KEY,
    nome varchar(50) not null,
    peso float
);

create login usuarioAtos with password='admin123';
create user usuarioAtos from login usuarioAtos;

exec sp_addrolemember 'DB_DATAREADER', 'usuarioAtos';
exec sp_addrolemember 'DB_DATAWRITER', 'usuarioAtos';