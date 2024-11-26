USE [EDUHUBBB]
GO
/****** Object:  StoredProcedure [dbo].[SP_GetAllCourses]    Script Date: 10/20/2024 4:55:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
Create PROCEDURE [dbo].[SP_GetAllCourses] 
AS
BEGIN
	SELECT * from Courses;
END
