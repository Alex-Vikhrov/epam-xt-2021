SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE dbo.AddUser
	@Id uniqueidentifier,
	@Login nvarchar(MAX),
	@Password nvarchar(MAX),
	@Email nvarchar(MAX)
AS
BEGIN
	SET NOCOUNT OFF;

    INSERT INTO dbo.Users (Id,Login,Password,Email) VALUES(@Id,@Login,@Password,@Email)
END
GO
