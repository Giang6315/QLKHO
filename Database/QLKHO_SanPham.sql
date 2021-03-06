USE [QLKHO]
GO
/****** Object:  StoredProcedure [dbo].[LoaiSanPham_Xoa]    Script Date: 08/10/2016 18:00:37 ******/
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
/****** Object:  StoredProcedure [dbo].[LoaiSanPham_SUA]    Script Date: 08/10/2016 18:00:37 ******/
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
/****** Object:  StoredProcedure [dbo].[SanPham_Xoa]    Script Date: 08/10/2016 18:00:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SanPham_Xoa] @MASP CHAR(12)
AS
BEGIN
	IF NOT EXISTS (SELECT MASP FROM SANPHAM WHERE MASP=@MASP)
	BEGIN
		RAISERROR(N'Sản phẩm này không tồn tại',16,1)
		RETURN
	END
	ELSE
	BEGIN
		DELETE FROM SANPHAM WHERE MASP=@MASP
	END
END
GO
/****** Object:  StoredProcedure [dbo].[SANPHAM_THEM]    Script Date: 08/10/2016 18:00:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[SANPHAM_THEM] @MASP CHAR(12), @TENSP NVARCHAR(50), @QUICACH NVARCHAR(20),@DONGIA INT, @MALOAI CHAR(6)
AS
begin

		IF EXISTS (SELECT * FROM SANPHAM WHERE MASP=@MASP AND TENSP=@TENSP)
			begin
				RAISERROR(N'Sản phẩm này đã có!',16,1) 
				RETURN -1
			end
		
		else
		
			BEGIN
				INSERT INTO SANPHAM(MASP,TENSP,QUICACH,DONGIA,MALOAI) 
				VALUES(@MASP,@TENSP,@QUICACH, @DONGIA,@MALOAI)	
			END
end
GO
/****** Object:  StoredProcedure [dbo].[SANPHAM_SUA]    Script Date: 08/10/2016 18:00:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SANPHAM_SUA]  @MASP CHAR(12), @TENSP NVARCHAR(50),@QUICACH NVARCHAR(20),@DONGIA INT, @MALOAI CHAR(6)
AS
BEGIN
	IF NOT EXISTS (SELECT MASP FROM SANPHAM WHERE MASP=@MASP)
	BEGIN
		RAISERROR(N'sản phẩm không tồn tại',16,1)
		RETURN -1
	END
	ELSE IF EXISTS (SELECT * FROM SANPHAM WHERE TENSP=@TENSP AND DONGIA=@DONGIA 
					AND QUICACH=@QUICACH AND MALOAI=@MALOAI)
	BEGIN
		RAISERROR(N'Sản phẩm sửa đổi có giá trị như cũ',16,1)
		RETURN -1
		END
	ELSE
		UPDATE SANPHAM 
		SET TENSP=@TENSP, DONGIA=@DONGIA, QUICACH=@QUICACH, MALOAI=@MALOAI
		WHERE MASP=@MASP
RETURN 0
END
GO
