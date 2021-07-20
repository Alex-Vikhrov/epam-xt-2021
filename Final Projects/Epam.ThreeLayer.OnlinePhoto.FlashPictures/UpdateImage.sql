SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE dbo.UpdateImage
	@Id uniqueidentifier,
@CreationDate datetime,
@CreationId uniqueidentifier,
@ContentType nvarchar(MAX),
@Date varbinary(MAX)
AS
BEGIN
	SET NOCOUNT OFF;

    UPDATE dbo.Image SET ContentType = @ContentType, Date=@Date WHERE Id=@id
END
GO
