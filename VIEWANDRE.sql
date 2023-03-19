 CREATE VIEW [RESULTADO] AS  
 SELECT P.Id, P.Nome,P.SobreNome,P.Sexo,P.DataNascimento,C.PessoaId,C.Saldo,C.TipoContaId
 FROM TB_PESSOA P 
 INNER JOIN TB_CONTA C ON  P.Id = C.PessoaId
 INNER JOIN TB_TIPO_CONTA T ON T.Id= C.TipoContaId;


 SELECT *
 FROM RESULTADO