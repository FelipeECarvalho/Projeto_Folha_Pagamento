CREATE DATABASE recursos_humanos_db;

USE recursos_humanos_db;

create TABLE empresa (
	id int PRIMARY KEY IDENTITY,
  	cnpj varchar(20) not null unique,
  	nome_fantasia varchar(50) not null,
  	razao_social varchar(50) not null unique,
	ativo BIT not null
);

CREATE TABLE colaborador (
	id int PRIMARY KEY IDENTITY,
    nome_completo varchar(50) not null,
  	sexo char(1) not null check (sexo in ('M', 'F', '-')),
	cargo int not null,
	salario decimal(8, 2) not null,
	data_admissao datetime not null,
	ativo BIT not null,
  	id_empresa int not null,
  	FOREIGN KEY (id_empresa) REFERENCES empresa(id)
);

CREATE TABLE acesso (
	id int PRIMARY KEY IDENTITY,
	usuario varchar(50) not null unique,
	senha varchar(50) not null,
	ativo BIT not null,
	id_colaborador int not null unique,
	FOREIGN KEY (id_colaborador) REFERENCES colaborador(id)
);

CREATE TABLE folha_pagamento (
	id int PRIMARY KEY IDENTITY,
    inss decimal(8,2) null,
	irrf decimal(8,2) null,
	horas_extras int null,
	valor_horas_extras decimal(8,2) null,
  	valor_liquido decimal(8,2) not null,
	descontos_totais decimal(8,2) null,
	vencimentos_totais decimal(8,2) not null,
	aliquota_inss decimal(8,2) null,
	aliquota_irrf decimal(8,2) null,
	data_criacao datetime not null,
	ativo BIT not null,
	id_colaborador int not null,
	FOREIGN KEY (id_colaborador) REFERENCES colaborador(id)
);

INSERT INTO empresa (cnpj, nome_fantasia, razao_social, ativo) VALUES ('65.509.378/0001-60', 'Unip', 'Unip', 1);
INSERT INTO colaborador (nome_completo, sexo, cargo, salario, data_admissao, ativo, id_empresa) VALUES ('Admin 1', 'M', 0, 2000, '2023-10-17', 1, 1);
INSERT INTO acesso (usuario, senha, ativo, id_colaborador) VALUES ('admin1', 'fd74d745ead59ab6a9117c2141ae1964', 1, 1);

-- Login: admin1
-- Senha: 563224