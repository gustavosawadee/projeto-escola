use master;

drop database BDEscola;

create database BDEscola;




use BDEscola;

create table disciplina(
	id int not null primary,
	disciplina varchar,
	sigla varchar
);

select * from disciplina;