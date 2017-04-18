USE [QuanLySV]
GO

/****** Object:  StoredProcedure [dbo].[laydiemhocki]    Script Date: 04/18/2017 09:54:43 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE proc [dbo].[laydiemhocki]
(@Malop int,@TenMH nvarchar(50),@DiemGK float , @DiemCK float)
as
begin
select SV_LH.MaLop,TenMH,DiemGK,DiemCK
  from SV_LH,MonHoc,LopHoc
  where SV_LH.MaLop=LopHoc.MaLop and LopHoc.MaMH= MonHoc.MaMH and MaSV='1002'
 end

GO

