CREATE DATABASE entity_db;

USE entity_db;

create login AtosEntity with password='AtosEntity';
create user AtosEntity from login AtosEntity;

select * from pessoas;

exec sp_addrolemember 'DB_DATAREADER', 'AtosEntity';
exec sp_addrolemember 'DB_DATAWRITER', 'AtosEntity';