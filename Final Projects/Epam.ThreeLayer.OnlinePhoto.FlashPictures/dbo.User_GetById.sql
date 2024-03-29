USE [Epam.FlaschPictures.Users]
GO
/****** Object:  StoredProcedure [dbo].[User_GetById]    Script Date: 20.07.2021 15:01:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [dbo].[User_GetById]
	@id uniqueidentifier
AS
BEGIN
	SET NOCOUNT ON;
	SELECT TOP 1
	Id, Login, Password, Email
	FROM Users
	WHERE Id = @id
END
