-- Criação do banco de dados (se ainda não existir)

CREATE DATABASE "Controle_de_Estoque";

-- Conecte-se ao seu banco de dados antes de executar os comandos abaixo

-- Criação da tabela Categoria
CREATE TABLE Categoria (
    id SERIAL PRIMARY KEY,
    nome_categoria VARCHAR(100) UNIQUE,
    descricao VARCHAR(255)
);

-- Criação da tabela Fornecedor
CREATE TABLE Fornecedor (
    id SERIAL PRIMARY KEY,
    nome_fornecedor VARCHAR(150) UNIQUE,
    contato VARCHAR(150),
    cnpj VARCHAR(18) UNIQUE
);

-- Criação da tabela Produto
CREATE TABLE Produto (
    id SERIAL PRIMARY KEY,
    nome_produto VARCHAR(150) NOT NULL,
    quantidade INTEGER NOT NULL,
    preco_unitario DECIMAL(10, 2),
    id_fornecedor INTEGER REFERENCES Fornecedor(id),
    id_categoria INTEGER REFERENCES Categoria(id)
);