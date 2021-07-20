USE [Epam.FlaschPictures.Users]
GO
/****** Object:  StoredProcedure [dbo].[SearchAuthData]    Script Date: 20.07.2021 14:37:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [dbo].[SearchAuthData]
@Login nvarchar(MAX),
@Email nvarchar(MAX)
AS
BEGIN
 SET NOCOUNT OFF;

 SELECT
   Login,Email
   FROM dbo.Users
   WHERE Login = @login OR Email = @email

   END
   GO
