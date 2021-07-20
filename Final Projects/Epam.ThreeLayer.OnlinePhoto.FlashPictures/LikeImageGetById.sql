SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE LikeImageGetById
    @UserId uniqueidentifier,
	@ImageId uniqueidentifier
AS
BEGIN

	SET NOCOUNT ON;

    SELECT [UserId],[ImageId] FROM dbo.LikeImage WHERE ([UserId]=@UserId AND [ImageId] = @ImageId)
END
GO
