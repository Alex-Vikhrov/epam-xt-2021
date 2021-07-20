SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[ValidateAuthData]
	@Login nvarchar(MAX),
	@Password nvarchar(MAX)
AS
BEGIN
	SET NOCOUNT ON;

	SELECT [Login],[Password] FROM dbo.Users WHERE [Login] = @Login AND [Password] = @Password
END
GO
