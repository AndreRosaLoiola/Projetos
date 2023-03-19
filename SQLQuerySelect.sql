SELECT * FROM TB_PESSOA

SELECT * FROM TB_CONTA

SELECT * FROM TB_TIPO_CONTA

INSERT INTO TB_PESSOA( Nome,SobreNome,Sexo,DataNascimento) values ('Cleidson','viado','feminino','2023-1-01');

INSERT INTO TB_CONTA (PessoaId,TipoContaId,DataCadastro,Saldo) values (5,1,'2023-01-02',55);

DELETE FROM TB_CONTA WHERE PessoaId=3;
DELETE  FROM TB_PESSOA WHERE Id=1;


UPDATE TB_CONTA
SET TipoContaId = 3
WHERE Id =7