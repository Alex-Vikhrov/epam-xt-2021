SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE dbo.SearchAuthData
@login nvarchar
AS
BEGIN
 SET NOCOUNT OFF;

 SELECT TOP 1
   id,Login,Password,Email
   FROM Users
   WHERE Login = @login

   END
   GO
