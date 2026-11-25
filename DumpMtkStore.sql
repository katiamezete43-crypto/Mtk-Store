SHOW DATABASES LIKE 'MTK_Store';

# --- Criando as tabelas: produtos, clientes, vendas e itens venda ---
USE mtk_store;
CREATE TABLE produtos(
id_produto INT AUTO_INCREMENT PRIMARY KEY, 
nome VARCHAR(100) NOT NULL,
categoria VARCHAR(100) NOT NULL,
preco DECIMAL(10,2) NOT NULL,
quantidade INT NOT NULL DEFAULT 0
);

CREATE TABLE clientes(
id_cliente INT AUTO_INCREMENT PRIMARY KEY,
nome VARCHAR(100) NOT NULL,
telefone VARCHAR(100) NOT NULL,
email VARCHAR(100) NOT NULL,
endereco VARCHAR(200) NOT NULL);

CREATE TABLE vendas(
id_venda INT AUTO_INCREMENT PRIMARY KEY,
id_cliente INT NOT NULL,
data_venda DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP,
forma_pagamento VARCHAR(30) NOT NULL, 
valor_total DECIMAL(10,2) NOT NULL DEFAULT 0.00,
CONSTRAINT fk_vendas_clientes
FOREIGN KEY (id_cliente)
REFERENCES clientes(id_cliente));


CREATE TABLE itens_venda (
id_item INT AUTO_INCREMENT PRIMARY KEY,
id_venda INT NOT NULL,
id_produto INT NOT NULL,
quantidade INT NOT NULL,
preco_unitario DECIMAL(10,2) NOT NULL,
subtotal DECIMAL(10,2) NOT NULL,

CONSTRAINT fk_itens_venda_vendas
        FOREIGN KEY (id_venda)
        REFERENCES vendas(id_venda),

    CONSTRAINT fk_itens_venda_produtos
        FOREIGN KEY (id_produto)
        REFERENCES produtos(id_produto)
);

# -- Alterando o tamanho/quantidade de digitos do telefone: 100 -> 20 --
USE mtk_store;
SHOW TABLES;

USE mtk_store;

ALTER TABLE clientes
MODIFY COLUMN telefone VARCHAR(20) NOT NULL;

USE mtk_store;
SHOW CREATE TABLE itens_venda;


#    ----- Criando as Stored Procedures -----
USE mtk_store;

DELIMITER $$

CREATE PROCEDURE sp_insereProduto(
    IN p_nome VARCHAR(100),
    IN p_categoria VARCHAR(100),
    IN p_preco DECIMAL(10,2),
    IN p_quantidade INT
)
BEGIN
    INSERT INTO produtos (nome, categoria, preco, quantidade)
    VALUES (p_nome, p_categoria, p_preco, p_quantidade);
END $$

DELIMITER ;

#  --- Criando a Stored Procedure de listarProdutos ---
USE mtk_store;

DELIMITER $$

CREATE PROCEDURE sp_listaProdutos()
BEGIN
    SELECT id_produto, nome, categoria, preco, quantidade
    FROM produtos
    ORDER BY nome;
END $$

DELIMITER ;

#  --- Criando a Stored Procedure para buscar o cliente pelo telefone ---
USE mtk_store;

DELIMITER $$

CREATE PROCEDURE sp_buscaClienteTelefone(
    IN p_telefone VARCHAR(20)
)
BEGIN
    SELECT id_cliente, nome, telefone, email, endereco
    FROM clientes
    WHERE REPLACE(REPLACE(REPLACE(REPLACE(telefone, '(', ''), ')', ''), '-', ''), ' ', '')
        = REPLACE(REPLACE(REPLACE(REPLACE(p_telefone, '(', ''), ')', ''), '-', ''), ' ', '');
END $$

DELIMITER ;