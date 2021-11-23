﻿CREATE TABLE [dbo].[Utilisateur]
(
	[Id_utilisateur] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Nom] NVARCHAR(80) NOT NULL, 
    [Prenom] NVARCHAR(80) NOT NULL, 
    [Email] NVARCHAR(100) NOT NULL, 
    [DateNaissance] DATE NOT NULL, 
    [PasswordHash] BINARY(64) NULL, 
    [SecurityStamp] UNIQUEIDENTIFIER NULL,
    [IsAdmin] BIT NOT NULL DEFAULT 0

)