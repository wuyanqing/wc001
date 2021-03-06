if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[pro_Bill]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[pro_Bill]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[pro_videoconfig]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[pro_videoconfig]
GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS OFF 
GO

CREATE PROCEDURE pro_Bill
@Code varchar(50)
AS
Declare @DBName varchar(20),@Name varchar(20),@Sql Varchar(8000)

Declare tmpCur Cursor For Select DBName,[Name] From V_C_Bill 
Open tmpCur 
Fetch Next From tmpCur Into @DBName,@Name
While @@Fetch_Status=0 
Begin 
	if @Sql is null
	begin
		set @Sql=','+@DBName+' as '+@Name
	end
	else
	begin
		set @Sql=@Sql+','+@DBName+' as '+@Name
	end
	--select @DBName,@Name
	Fetch Next From tmpCur Into  @DBName,@Name
End 
Close tmpCur 
DealLocate tmpCur 
if   CharIndex(',',@Sql)=1   
    set   @Sql=stuff(@Sql,1,1,'')
select @Sql
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS OFF 
GO

CREATE PROCEDURE pro_videoconfig  
@VIDEOname char(10),@VIDEOtable varchar(50),@VIDEOStandard int,@VIDEOSource int,@VIDEOBrightness int,@VIDEOContrast int ,@VIDEOHue int,
@VIDEOSaturation int, @VIDEOSuality int 
AS 
DECLARE @name char(10) 
select @name=video_name from D_video where video_name=@VIDEOname and video_table=@VIDEOtable 
if @name is null 
	insert into D_video (VIDEO_name,VIDEO_table,VIDEO_Standard,VIDEO_Source,VIDEO_Brightness,VIDEO_Contrast,VIDEO_Hue,VIDEO_Saturation,VIDEO_Suality)
 	values(@VIDEOname,@VIDEOtable,@VIDEOStandard,@VIDEOSource,@VIDEOBrightness,@VIDEOContrast ,@VIDEOHue,@VIDEOSaturation,@VIDEOSuality)
else
 	update D_video set VIDEO_Standard=@VIDEOStandard,VIDEO_Source=@VIDEOSource,VIDEO_Brightness=@VIDEOBrightness,VIDEO_Contrast=@VIDEOContrast, 
	VIDEO_Hue=@VIDEOHue,VIDEO_Saturation=@VIDEOSaturation,VIDEO_Suality=@VIDEOSuality
	where video_name=@VIDEOname and VIDEO_table=@VIDEOtable
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

