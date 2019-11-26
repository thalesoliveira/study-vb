CREATE PROCEDURE [dbo].[spIncluirEquipe]
	@nome varchar(50),
	@endereco varchar(50)
AS
	INSERT INTO Equipe (txt_nome, txt_endereco) VALUES (@nome, @endereco)