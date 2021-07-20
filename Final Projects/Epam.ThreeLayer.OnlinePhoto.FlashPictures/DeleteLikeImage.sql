SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE dbo.DeleteLikeImage
    @UserId uniqueidentifier,
	@ImageId uniqueidentifier
AS
BEGIN

	SET NOCOUNT ON;

    DELETE FROM dbo.LikeImage WHERE ([UserId]=@UserId AND [ImageId] = @ImageId)
END
GO
