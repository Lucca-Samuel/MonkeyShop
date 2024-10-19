create database monkey_shop;

use monkey_shop;

-- Criação de um login no servidor
CREATE LOGIN senac WITH PASSWORD = 'senac';

-- Criação de um usuário de banco de dados associado ao login
USE [monkey_shop]; -- Substitua 'SeuBancoDeDados' pelo nome do seu banco de dados
CREATE USER senac FOR LOGIN senac;

-- Concedendo permissões de administrador
ALTER ROLE db_owner ADD MEMBER senac;


CREATE TABLE permissoes_usuarios(
	id_permissao BIGINT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	permissoes VARCHAR(50),
);

--Criação da tabela de usuarios
CREATE TABLE usuarios(
	id_usuario BIGINT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	nome VARCHAR(100),
	email VARCHAR(100),
	login_user VARCHAR(50),
	senha_user VARCHAR(6),
	fk_id_permissao BIGINT,

	FOREIGN KEY (fk_id_permissao) REFERENCES permissoes_usuarios(id_permissao),
);


create table clientes (
id_cliente bigint primary key identity(1,1),
nome varchar(100),
sobrenome varchar(200),
telefone char(19),
whatsapp char(19),
email varchar(100),
cpf char(15),
data_nascimento date,
rg char(12),
tipo_cliente varchar(30),

cep char(10),
logradouro varchar(150),
numero int,
complemento varchar(50),
bairro varchar(100),
cidade varchar(100),
estado varchar(50),
pais varchar(50),
);

--Criação da tabela de vendas
create table vendas(
id_venda bigint primary key identity(1,1),
data_venda date,
valor_total decimal(8,2),
fk_id_forma_pgto varchar(50),
fk_id_cliente bigint,
fk_id_user bigint,

FOREIGN KEY (fk_id_cliente) REFERENCES clientes(id_cliente),
FOREIGN KEY (fk_id_user) REFERENCES usuarios(id_usuario),
);

--Criação da tabela de categoria dos produtos
create table categorias_produtos(
id_categoria_produto bigint primary key identity(1,1),
nome_categoria varchar(100),
);

--criação da tabela produtos
create table tbl_produtos(
	pro_id int primary key identity(1,1),
	pro_cod int,
	pro_nome varchar(150),
	pro_categoria varchar(100),
	pro_modelo varchar(100),
	pro_tamanho varchar(10),
	pro_cor varchar(50),
	pro_qtd int,
	pro_status varchar(50),
	pro_preco decimal(10,2),
	fk_id_categoria_produto bigint

	FOREIGN KEY (fk_id_categoria_produto) REFERENCES categorias_produtos(id_categoria_produto),
);


--criação da tabela de relacionamento de produtos-vendas
create table rl_produtos_vendas(
fk_id_produto int,
fk_id_venda bigint,
data_venda date,
valor_produto decimal(8,2),
desconto decimal(8,2),
qtde_vendida int,

FOREIGN KEY (fk_id_produto) REFERENCES tbl_produtos(pro_id),
FOREIGN KEY (fk_id_venda) REFERENCES vendas(id_venda),
);


--Ciação da tabela de fornecedores
CREATE TABLE fornecedores(
	id_fornecedor BIGINT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	nome_for VARCHAR (100),
	cnpj CHAR(18),
	pric_prod_for VARCHAR(150),
	telefone CHAR(19),
	whatsapp CHAR(19),
	email_for VARCHAR(100),
	nome_contato varchar(50),
	cep char(10),
	logradouro VARCHAR(150),
	numero INT,
	complemento VARCHAR(200),
	bairro VARCHAR(100),
	cidade VARCHAR(100),
	estado VARCHAR(50),
	important_infos varchar(200),
);

--Criação da tabela de compras
CREATE TABLE compras(
	id_compra BIGINT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	data_compra DATE,
	num_nota_fiscal INT,
	valor_total_compra DECIMAL(10,2),
	fk_id_for BIGINT,
	fk_id_user BIGINT,
	fk_id_forma_pgto varchar(50),

	FOREIGN KEY (fk_id_for) REFERENCES fornecedores(id_fornecedor),
	FOREIGN KEY (fk_id_user) REFERENCES usuarios(id_usuario),
);

--Criação da tabela de relacionamento compra-produtos
CREATE TABLE compra_produtos(
	data_comp date,
	fk_id_compra BIGINT,
	fk_id_prod int,

	FOREIGN KEY (fk_id_compra) REFERENCES compras(id_compra),
	FOREIGN KEY (fk_id_prod) REFERENCES tbl_produtos(pro_id),
);
