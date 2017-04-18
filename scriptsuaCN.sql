USE [QuanLySV]
GO

/****** Object:  StoredProcedure [dbo].[Suachuyennganh]    Script Date: 04/18/2017 09:55:03 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE proc [dbo].[Suachuyennganh](@MaNganh nvarchar(10),@TenNganh nvarchar(50))
as
begin
update ChuyenNganh 
set
TenNganh=@TenNganh
where MaNganh= @MaNganh
end
GO

