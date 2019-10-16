CREATE PROCEDURE [dbo].[spPesquisaEquipe]
(
	@id int
)
AS
	SELECT * FROM Equipe WHERE id = @id

