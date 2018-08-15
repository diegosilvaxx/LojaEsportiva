/*
O banco tem como o server o localhost o usuário como root e a senha é vazia.

"Persist Security Info = False; server = localhost; 
database = loja_esportivo; uid = root; pwd =;SSlmode = none;"
*/

create database loja_esportivo;

use loja_esportivo;

create table usuario (
id_usuario int primary key auto_increment,
nome varchar(150) not null,
usuario varchar(150) not null,
senha varchar(150) not null
);

insert into usuario(nome,usuario,senha) values ('Admin','admin','admin');

CREATE TABLE Cliente(
id_cliente int primary key auto_increment not null,
nome varchar(155) not null,
cpf varchar(14) not null UNIQUE,
email varchar(100) not null UNIQUE,
data_nascimento varchar(30) not null,
sexo enum('M','F') not null,
rua varchar(40),
numero_endereco varchar(9),
bairro varchar(40),
estado varchar(40),
cidade varchar(40),
ddd varchar(2),
numero_telefone varchar(9),
tipo_numero varchar(9)
);

create table fornecedor(
id_fornecedor int primary key auto_increment,
nome varchar(150) not null,
cnpj varchar(20) not null unique,
ddd char(3) not null,
numero char(9) not null,
tipo_numero varchar(15) not null,
email varchar(150) not null unique
);

create table grupo(
id_grupo int primary key auto_increment,
categoria varchar(100) not null,
estado_categoria enum('S','N') not null
);

create table produto(
id_produto int primary key auto_increment,
id_grupo int not null,
id_fornecedor int not null,
nome_fornecedor varchar(150) not null,
categoria varchar(100) not null,
modelo varchar(100) not null,
marca varchar(100) not null,
preco decimal(8,2) not null,
quantidade int not null,
descricao varchar(255) not null,
FOREIGN KEY(id_grupo) REFERENCES grupo(id_grupo),
FOREIGN KEY(id_fornecedor) REFERENCES fornecedor(id_fornecedor)
);

create table compra(
id_compra int primary key auto_increment,
id_cliente int not null,
nome_cliente varchar(150) not null,
valor_total decimal(12,2),
FOREIGN KEY(id_cliente) REFERENCES cliente(id_cliente)
);

create table produto_compra(
id_produto int not null,
id_compra int not null,
modelo varchar(150) not null,
categoria varchar(100) not null,
quantidade int not null,
preco decimal(12,2) not null,
FOREIGN KEY(id_compra) REFERENCES compra(id_compra)
);