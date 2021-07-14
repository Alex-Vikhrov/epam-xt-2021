SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE dbo.User_GetById
	-- Add the parameters for the stored procedure here
	@id uniqueidentifier
AS
BEGIN
	SET NOCOUNT ON;
	SELECT TOP 1
	Id, Login, Password, Email
	FROM Users
	WHERE Id = @id
END
GO
