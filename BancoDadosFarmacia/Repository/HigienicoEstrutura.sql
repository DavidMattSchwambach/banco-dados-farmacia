DROP TABLE higienicos;
CREATE TABLE higienicos(
	id INT PRIMARY KEY IDENTITY(1,1),
	nome VARCHAR(100),
	categoria VARCHAR(100),
	preco DECIMAL
);