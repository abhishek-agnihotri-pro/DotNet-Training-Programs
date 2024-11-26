USE [EDUHUBBB]
GO
/****** Object:  StoredProcedure [dbo].[SP_GetMaterialByCourseId]    Script Date: 10/20/2024 5:06:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
Create PROCEDURE [dbo].[SP_GetMaterialByCourseId] 
	(@id int)
AS
BEGIN
	select m.materialId as MaterialId, m.description as description, m.contentType as ContentType, m.title as Title, m.URL as URL, m.uploadDate as UploadDate, c.title as CourseTitle from Materials m inner join courses c on m.courseId = c.courseId where c.courseId = @id;
END
