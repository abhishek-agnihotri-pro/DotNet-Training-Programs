USE [EDUHUBBB]
GO
/****** Object:  StoredProcedure [dbo].[GetAcceptedEnrollmentByName]    Script Date: 10/20/2024 4:52:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
Create PROCEDURE [dbo].[GetAcceptedEnrollmentByName]
(@id int)
AS
BEGIN
  SELECT 
    e.EnrollmentId as EnrollmentId,
    e.UserId as UserId,
    e.CourseId as CourseId,
    e.EnrollmentDate as EnrollmentDate,
    e.Status as Status,
    u.UserName as UserName,
    c.title AS CourseName
FROM 
    Enrollments e
INNER JOIN 
    [Users] u ON e.UserId = u.UserId
INNER JOIN 
    Courses c ON e.CourseId = c.courseId
	where c.userId = @id and e.status='Accepted';
END
