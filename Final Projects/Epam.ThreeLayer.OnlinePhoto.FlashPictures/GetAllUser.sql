USE [Epam.FlaschPictures.Users]
GO
/****** Object:  StoredProcedure [dbo].[GetAllUser]    Script Date: 20.07.2021 15:34:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[GetAllUser]
@Login nvarchar(MAX)
AS
BEGIN
	SET NOCOUNT ON;

    SELECT Id,Login,Password,Email FROM Users WHERE Login=@Login
END
