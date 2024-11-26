USE [EDUHUBBB]
GO
/****** Object:  StoredProcedure [dbo].[GetCoursesByUserId]    Script Date: 10/20/2024 4:53:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
Create PROCEDURE [dbo].[GetCoursesByUserId] 
(@id int)
AS
BEGIN
	select * from courses where courseId = @id;
END
