use master;

drop database BDEscola;

create database BDEscola;

use BDEscola;

drop table disciplinas;

go

create table disciplinas(
	id int not null primary key identity(1,1),
	disciplina varchar(50),
	sigla varchar(50)
);

create table alunos(
	id int not null primary key identity(1,1),
	nome varchar(100),
	nascimento varchar(100),
	endereco varchar(100),
	numero varchar(100),
	bairro varchar(100),
	cidade varchar(100),
	cep varchar(100),
	rg varchar(100),
	telefone varchar(100)
);
drop table alunos;
select * from alunos;

