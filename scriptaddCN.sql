USE [QuanLySV]
GO

/****** Object:  StoredProcedure [dbo].[addchuyennganh]    Script Date: 04/18/2017 09:54:02 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[addchuyennganh](@MaCN nvarchar(10),@TenCN nvarchar(50))
as
begin
insert into ChuyenNganh
values(@MaCN,@TenCN)
end

GO

