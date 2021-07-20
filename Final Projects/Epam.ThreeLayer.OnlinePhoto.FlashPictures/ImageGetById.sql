SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE ImageGetById 
@Id uniqueidentifier
AS
BEGIN

	SET NOCOUNT ON;

    SELECT Id,CreationId,CreationDate,ContentType,Date FROM dbo.Image WHERE [Id]=@id
END
GO
