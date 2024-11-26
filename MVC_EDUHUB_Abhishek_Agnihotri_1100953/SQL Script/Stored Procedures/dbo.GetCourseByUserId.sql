USE [EDUHUBBB]
GO
/****** Object:  StoredProcedure [dbo].[SP_GetCoursesByUserId]    Script Date: 10/20/2024 4:56:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
Create PROCEDURE [dbo].[SP_GetCoursesByUserId] 
(@id int)
AS
BEGIN
	select * from courses where userId = @id;
END
