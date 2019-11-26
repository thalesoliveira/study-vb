CREATE TABLE [dbo].[Clientes]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [txt_nome] NCHAR(30) NULL, 
    [txt_endereco] NCHAR(50) NULL, 
    [txt_cidade] NCHAR(50) NULL
)
