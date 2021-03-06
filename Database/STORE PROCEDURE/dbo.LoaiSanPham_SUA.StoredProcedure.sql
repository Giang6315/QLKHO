USE [QLKHO]
GO
/****** Object:  StoredProcedure [dbo].[LoaiSanPham_SUA]    Script Date: 08/10/2016 18:04:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[LoaiSanPham_SUA] @maloai char(12), @tenloai nvarchar(40)
as
	begin
		if not exists (select MALOAI from LOAISANPHAM where MALOAI=@maloai)
		begin
			print N'Loại sản phẩm không tồn tại'
			return -1 
		end
		if exists(select * from LOAISANPHAM where TENLOAI=@tenloai)
		begin
			print N'Sản phẩm sửa đổi có giá trị như cũ'
			return -1 
		end
		update LOAISANPHAM 
		set TENLOAI=@tenloai 
		where MALOAI=@maloai
		return 0
	end
GO
