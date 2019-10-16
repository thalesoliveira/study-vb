CREATE PROCEDURE [dbo].[spAtualizarEquipe]
	@id int,
	@nome varchar(50),
	@cidade varchar(50)
AS
	UPDATE Equipe set txt_nome = @nome, txt_cidade = @cidade WHERE id = @id  

