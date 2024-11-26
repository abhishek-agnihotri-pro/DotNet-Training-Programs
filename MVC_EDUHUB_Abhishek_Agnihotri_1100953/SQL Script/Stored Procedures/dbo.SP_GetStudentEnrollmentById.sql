USE [EDUHUBBB]
GO
/****** Object:  StoredProcedure [dbo].[SP_GetStudentEnrollmentById]    Script Date: 10/20/2024 5:07:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
Create PROCEDURE [dbo].[SP_GetStudentEnrollmentById]
(@id int)
AS
BEGIN
	SELECT e.EnrollmentId,c.CourseId, c.title as CourseName,e.EnrollmentDate,e.Status from Enrollments e join Courses c on c.courseId=e.courseId
	where e.userId=@id;
END
