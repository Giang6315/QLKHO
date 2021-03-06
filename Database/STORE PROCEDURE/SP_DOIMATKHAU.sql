USE [QLKHO]
GO
/****** Object:  StoredProcedure [dbo].[SP_DOIMATKHAU]    Script Date: 02/24/2018 18:06:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[SP_DOIMATKHAU] (@tendangnhap nvarchar(32), @matkhaucu varchar(32), @matkhaumoi varchar(32))
as
	begin
		if not exists(select tendangnhap from NGUOIDUNG where TenDangNhap=@tendangnhap)
		begin
			raiserror(N'Tên đăng nhập không khớp!', 16, 1)
			return
		end
		ELSE if not exists(select matkhau from NGUOIDUNG where MatKhau=@matkhaucu)
		begin
				raiserror(N'Mật khẩu không khớp!', 16, 1)
			return
		end
		ELSE if exists(select tendangnhap, matkhau from NGUOIDUNG where TenDangNhap=@tendangnhap and matkhau=@matkhaucu)
		begin
			update NGUOIDUNG set MatKhau=@matkhaumoi where TenDangNhap=@tendangnhap and MatKhau=@matkhaucu
		end
	end