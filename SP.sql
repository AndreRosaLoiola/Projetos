CREATE PROCEDURE Inserir
@Nome VARCHAR(20),
@SobreNome VARCHAR(20),
@Sexo VARCHAR (20),
@DataNascimento DATETIME

AS 
	
BEGIN

INSERT INTO TB_PESSOA( Nome,SobreNome,Sexo,DataNascimento)

VALUES(@Nome,@SobreNome,@Sexo,@DataNascimento)
END

