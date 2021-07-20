SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE dbo.GetAllImage 

AS
BEGIN

	SET NOCOUNT ON;

    SELECT [Id],[CreationId],[CreationDate],[ContentType],[Date] FROM dbo.Image
END
GO
