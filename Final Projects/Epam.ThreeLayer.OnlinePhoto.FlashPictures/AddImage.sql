
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE dbo.AddImage
@Id uniqueidentifier,
@CreationDate datetime,
@CreationId uniqueidentifier,
@ContentType nvarchar(MAX),
@Date varbinary(MAX)
AS
BEGIN
	SET NOCOUNT OFF;

   INSERT INTO dbo.Image VALUES (@Id, @CreationDate, @CreationId, @ContentType, @Date)
END
GO
