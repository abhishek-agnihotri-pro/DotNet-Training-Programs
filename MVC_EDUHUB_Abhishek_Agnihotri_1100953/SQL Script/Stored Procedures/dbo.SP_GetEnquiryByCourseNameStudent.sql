USE [EDUHUBBB]
GO
/****** Object:  StoredProcedure [dbo].[SP_GetEnquiryByCourseNameStudent]    Script Date: 10/20/2024 4:56:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
Create PROCEDURE [dbo].[SP_GetEnquiryByCourseNameStudent]
(@id int)
AS
BEGIN
SELECT 
    e.EnquiryId,
    e.CourseId,
    e.UserId,
    e.EnquiryDate,
    e.Subject,
    e.Message,
    e.Status,
    e.Response,
    u.UserName,
    c.title AS CourseName
FROM 
    Enquiries e
INNER JOIN 
    Users u ON e.UserId = u.UserId
INNER JOIN 
    Courses c ON e.CourseId = c.courseId
	where u.userId = @id
END
