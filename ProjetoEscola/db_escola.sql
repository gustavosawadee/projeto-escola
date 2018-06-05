create database db_escola;

use db_escola;

create table tb_alunos (
	id int primary key identity(1,1),
	nome varchar(100),
	nascimento varchar(20),
	endereco varchar(100),
	numero varchar(20),
	bairro varchar(100),
	cidade varchar(100),
	cep varchar(20),
	rg varchar(20),
	telefone varchar(20));
	
select * from tb_alunos;

drop table tb_alunos;

create table tb_disciplinas (
	id int not null primary key,
	descricao varchar(100),
	sigla varchar(10));
	
select * from tb_disciplinas;

create table tb_registrarMencao (
	id_aluno int,
	id_disciplina int,
	mencao varchar (5),
	FOREIGN KEY (id_aluno) REFERENCES tb_alunos (id),
	FOREIGN KEY (id_disciplina) REFERENCES tb_disciplinas(id)
	);
	
	
select 

a.nome,
d.sigla,
d.descricao, 
m.mencao 
from tb_registrarMencao m 
inner join tb_alunos a on a.id = m.id_aluno 
inner join tb_disciplinas d on d.id = m.id_disciplina