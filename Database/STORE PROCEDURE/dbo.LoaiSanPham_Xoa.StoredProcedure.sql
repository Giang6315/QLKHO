USE [QLKHO]
GO
/****** Object:  StoredProcedure [dbo].[LoaiSanPham_Xoa]    Script Date: 08/10/2016 18:04:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[LoaiSanPham_Xoa] @maloai char(12)
as
begin
	if not exists (select MALOAI from LOAISANPHAM where MALOAI=@maloai)
	begin
		raiserror(N'Sản phẩm này không có!', 16, 1)
		return -1 
	end
	else
	begin
		delete from LOAISANPHAM where MALOAI=@maloai
	end
end
GO
