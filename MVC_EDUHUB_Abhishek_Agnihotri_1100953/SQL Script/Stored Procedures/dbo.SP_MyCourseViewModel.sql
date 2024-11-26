USE [EDUHUBBB]
GO
/****** Object:  StoredProcedure [dbo].[SP_MyCourseViewModel]    Script Date: 10/20/2024 5:08:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
Create PROCEDURE [dbo].[SP_MyCourseViewModel]
(@id int)
AS
BEGIN
SELECT 
    c.courseId,
    c.title,
    c.description,
    c.courseStartDate,
    c.courseEndDate,
    c.userId,
    c.category,
    c.level,
    u.UserName,
    c.title AS CourseName
FROM 
    Courses c
INNER JOIN 
    Users u ON c.userId = u.UserId
	where u.UserId = @id
END
