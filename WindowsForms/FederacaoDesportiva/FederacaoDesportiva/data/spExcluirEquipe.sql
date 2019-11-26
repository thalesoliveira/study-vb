CREATE PROCEDURE [dbo].[spExcluirEquipe]
	@id	int
AS
	DELETE Equipe WHERE id = @id