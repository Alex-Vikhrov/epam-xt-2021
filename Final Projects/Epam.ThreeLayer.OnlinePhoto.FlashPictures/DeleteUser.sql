SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE dbo.DeleteUser
	@Login nvarchar(MAX)
AS
BEGIN
	SET NOCOUNT ON;

    DELETE FROM Users WHERE Login=@Login
END
GO
