CREATE DATABASE estoque;

CREATE TABLE cliente(
	id INTEGER NOT NULL AUTO_INCREMENT PRIMARY KEY, 
	nome VARCHAR(100) NOT NULL, 
	email VARCHAR(70) NOT NULL UNIQUE 
);

select * from cliente;

insert into cliente(nome, email)values('Jasmine', 'jas@gmail.com');
insert into cliente(nome, email)values('Eduardo', 'edu@gmail.com');
insert into cliente(nome, email)values('Beatriz', 'bia@gmail.com');
insert into cliente(nome, email)values('Regina', 're@gmail.com');

select * from cliente where id = 1; --filtra por id
select * from cliente where id in (1,2); --filtra por varios ids
select * from cliente where nome = 'Jasmine'; --filtra por nome de forma exata
select * from cliente where nome like 'Jas%'; --filtra por parte do nome no inicio
select * from cliente where nome like '%mine'; --filtra por parte do nome no inicio
select * from cliente where nome like '%mine%'; --filtra por parte do texto

update cliente set nome ='Miotto', email ='miotto@gmail.com' where id =3;

insert into cliente(nome, email)values('sera excluido', 'excluido@gmail.com');

delete from cliente where id =5;

START TRANSACTION; --starta uma transação segura

COMMIT; --confirma a transação
ROLLBACK; --desfaz a transação

--DUMP DO BANCO DE DADOS SQL
mysqldump -u root -p estoque> camadas/sql/backup.sql;



