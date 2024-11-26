USE [EDUHUBBB]
GO
/****** Object:  StoredProcedure [dbo].[SP_GetFeedbackByName]    Script Date: 10/20/2024 4:57:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
Create PROCEDURE [dbo].[SP_GetFeedbackByName] 
AS
BEGIN
	SELECT 
    f.FeedbackId as FeedbackId,
    f.UserId as UserId,
    f.Date as Date,
    f.feedback as feedback,
    u.UserName as UserName
FROM 
    Feedbacks f
INNER JOIN 
    Users u ON f.UserId = u.UserId;
END
