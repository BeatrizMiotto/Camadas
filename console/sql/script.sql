CREATE DATABASE persistencia;

CREATE TABLE cliente(
	id INTEGER NOT NULL AUTO_INCREMENT PRIMARY KEY, 
	nome VARCHAR(100) NOT NULL, 
	email VARCHAR(70) NOT NULL UNIQUE 
);


CREATE TABLE produtos(
	id INTEGER NOT NULL AUTO_INCREMENT PRIMARY KEY, 
	nome VARCHAR(100) NOT NULL, 
	descricao TEXT,  
	data_criacao DATE,
	data_validade DATE,
	quantidade_estoque INTEGER 
);

insert into produtos(nome, descricao, data_criacao, data_validade, quantidade_estoque )values('Maçã', 'Maçã Argentina', '2022-11-12', '2022-11-26', '30');
insert into produtos(nome, descricao, data_criacao, data_validade, quantidade_estoque )values('Banana', 'Banana Prata', '2022-12-25', '2022-12-30', '40');
insert into produtos(nome, descricao, data_criacao, data_validade, quantidade_estoque )values('Uva', 'Uva Verde', '2022-10-30', '2022-11-05', '10');
insert into produtos(nome, descricao, data_criacao, data_validade, quantidade_estoque )values('Goiaba', 'Goiaba vermelha', '2022-12-26', '2022-12-30', '50');
insert into produtos(nome, descricao, data_criacao, data_validade, quantidade_estoque )values('Manga', 'Manga Rosa', '2022-12-05', '2022-12-26', '20');

select * from cliente;
select * from produtos;

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
mysqldump -u root -p persistencia > sql/backup.sql;


