SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE GetAllLikeImage

AS
BEGIN

	SET NOCOUNT ON;

    SELECT [UserId],[Imageid] FROM [LikeImage]
END
GO
