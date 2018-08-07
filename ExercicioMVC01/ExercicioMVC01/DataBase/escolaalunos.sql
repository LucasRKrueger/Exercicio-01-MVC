DROP TABLE escolaalunos;
CREATE TABLE escolaalunos(
	id INT IDENTITY(1,1) PRIMARY KEY,
	nome VARCHAR(100) NOT NULL,
	codigo_matricula VARCHAR(20) NOT NULL,
	nota_1 FLOAT,
	nota_2 FLOAT,
	nota_3 FLOAT,
	frequencia TINYINT
	
);

INSERT INTO escolaalunos (nome, codigo_matricula, nota_1,nota_2,nota_3, frequencia) VALUES
('Lucas', '123456789', 9, 8, 10, 90);