DROP TABLE comestiveis;
CREATE TABLE comestiveis(
	id INT PRIMARY KEY IDENTITY(1,1),
	nome VARCHAR(100)NOT NULL,
	valor Decimal(3,1),
	data_vencimento DATETIME2,
	quantidade INT,
	marca VARCHAR(100)NOT NULL
);