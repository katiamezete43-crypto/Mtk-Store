
-- ============================================
-- BANCO DE DADOS - MTK STORE
-- ============================================

CREATE DATABASE IF NOT EXISTS mtk_store
CHARACTER SET utf8mb4
COLLATE utf8mb4_unicode_ci;

USE mtk_store;


-- ============================================
-- 1. TABELA DE USUÁRIOS
-- Login e cadastro do sistema
-- ============================================

CREATE TABLE IF NOT EXISTS usuarios (
    id_usuario INT AUTO_INCREMENT PRIMARY KEY,
    nome VARCHAR(100) NOT NULL,
    email VARCHAR(150) NOT NULL UNIQUE,
    usuario VARCHAR(50) NOT NULL UNIQUE,
    senha_hash VARCHAR(255) NOT NULL,
    data_cadastro DATETIME DEFAULT CURRENT_TIMESTAMP
) ENGINE=InnoDB;


-- ============================================
-- 2. TABELA DE PRODUTOS
-- ============================================

CREATE TABLE IF NOT EXISTS produtos (
    id_produto INT AUTO_INCREMENT PRIMARY KEY,
    nome VARCHAR(100) NOT NULL,
    categoria VARCHAR(100) NOT NULL,
    preco DECIMAL(10,2) NOT NULL,
    quantidade INT NOT NULL DEFAULT 0
) ENGINE=InnoDB;


-- ============================================
-- 3. TABELA DE CLIENTES
-- ============================================

CREATE TABLE IF NOT EXISTS clientes (
    id_cliente INT AUTO_INCREMENT PRIMARY KEY,
    nome VARCHAR(100) NOT NULL,
    telefone VARCHAR(20) NOT NULL,
    email VARCHAR(100) NOT NULL,
    endereco VARCHAR(200) NOT NULL
) ENGINE=InnoDB;


-- ============================================
-- 4. TABELA DE VENDAS
-- ============================================

CREATE TABLE IF NOT EXISTS vendas (
    id_venda INT AUTO_INCREMENT PRIMARY KEY,
    id_cliente INT NOT NULL,
    data_venda DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP,
    forma_pagamento VARCHAR(30) NOT NULL,
    valor_total DECIMAL(10,2) NOT NULL DEFAULT 0.00,

    CONSTRAINT fk_vendas_clientes
    FOREIGN KEY (id_cliente)
    REFERENCES clientes(id_cliente)
    ON UPDATE CASCADE
    ON DELETE RESTRICT
) ENGINE=InnoDB;


-- ============================================
-- 5. TABELA DE ITENS DA VENDA
-- ============================================

CREATE TABLE IF NOT EXISTS itens_venda (
    id_item INT AUTO_INCREMENT PRIMARY KEY,
    id_venda INT NOT NULL,
    id_produto INT NOT NULL,
    quantidade INT NOT NULL,
    preco_unitario DECIMAL(10,2) NOT NULL,
    subtotal DECIMAL(10,2) NOT NULL,

    CONSTRAINT fk_itens_venda_vendas
    FOREIGN KEY (id_venda)
    REFERENCES vendas(id_venda)
    ON UPDATE CASCADE
    ON DELETE RESTRICT,

    CONSTRAINT fk_itens_venda_produtos
    FOREIGN KEY (id_produto)
    REFERENCES produtos(id_produto)
    ON UPDATE CASCADE
    ON DELETE RESTRICT
) ENGINE=InnoDB;


-- ============================================
-- 6. PROCEDURE PARA CADASTRAR PRODUTOS
-- ============================================

DROP PROCEDURE IF EXISTS sp_insereProduto;

DELIMITER $$

CREATE PROCEDURE sp_insereProduto(
    IN p_nome VARCHAR(100),
    IN p_categoria VARCHAR(100),
    IN p_preco DECIMAL(10,2),
    IN p_quantidade INT
)
BEGIN
    INSERT INTO produtos (
        nome,
        categoria,
        preco,
        quantidade
    )
    VALUES (
        p_nome,
        p_categoria,
        p_preco,
        p_quantidade
    );
END $$

DELIMITER ;


-- ============================================
-- 7. PROCEDURE PARA LISTAR PRODUTOS
-- ============================================

DROP PROCEDURE IF EXISTS sp_listaProdutos;

DELIMITER $$

CREATE PROCEDURE sp_listaProdutos()
BEGIN
    SELECT
        id_produto,
        nome,
        categoria,
        preco,
        quantidade
    FROM produtos
    ORDER BY nome;
END $$

DELIMITER ;


-- ============================================
-- 8. PROCEDURE PARA BUSCAR CLIENTE PELO TELEFONE
-- ============================================

DROP PROCEDURE IF EXISTS sp_buscaClienteTelefone;

DELIMITER $$

CREATE PROCEDURE sp_buscaClienteTelefone(
    IN p_telefone VARCHAR(30)
)
BEGIN
    SELECT
        id_cliente,
        nome,
        telefone,
        email,
        endereco
    FROM clientes
    WHERE
        REPLACE(
            REPLACE(
                REPLACE(
                    REPLACE(
                        REPLACE(telefone, '(', ''),
                    ')', ''),
                '-', ''),
            ' ', ''),
        '.', '')
        =
        REPLACE(
            REPLACE(
                REPLACE(
                    REPLACE(
                        REPLACE(p_telefone, '(', ''),
                    ')', ''),
                '-', ''),
            ' ', ''),
        '.', '')
    LIMIT 1;
END $$

DELIMITER ;


-- ============================================
-- 9. CONSULTA PARA CONFERIR AS TABELAS
-- ============================================

SHOW TABLES;


-- ============================================
-- 10. CONSULTAS PARA CONFERIR OS DADOS
-- ============================================

SELECT * FROM usuarios;
SELECT * FROM produtos;
SELECT * FROM clientes;
SELECT * FROM vendas;
SELECT * FROM itens_venda;
