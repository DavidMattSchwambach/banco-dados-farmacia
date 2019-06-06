DROP TABLE remedios;
CREATE TABLE remedios(
	generico BIT,
	nome VARCHAR(100),
	id INT PRIMARY KEY IDENTITY(1,1),
	categoria VARCHAR(100),
	solido BIT,
	contra_indicacoes VARCHAR(100),
	bula VARCHAR(100),
	faixa VARCHAR(100),
	precisa_receita BIT
);