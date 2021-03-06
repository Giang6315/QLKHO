USE [QLKHO]
GO
/****** Object:  StoredProcedure [dbo].[SANPHAM_SUA]    Script Date: 08/10/2016 18:04:20 ******/
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
