ALTER PROC [dbo].[SP_NGUOIDUNG_THEM] @TENDN VARCHAR(32), @MATKHAU VARCHAR(32), @ADMIN BIT, @THEM BIT, @XOA BIT, @SUA BIT
	BEGIN
		IF EXISTS (SELECT TENDANGNHAP FROM NGUOIDUNG WHERE TENDANGNHAP=@TENDN)
			BEGIN
				RAISERROR(N'Tên đăng nhập đã tồn tại', 16, 1)
				RETURN
			END
		ELSE
			INSERT INTO NGUOIDUNG VALUES(@TENDN, @MATKHAU, @ADMIN, @THEM, @XOA, @SUA)		
	END
	
alter PROC [dbo].[SP_NGUOIDUNG_XOA] @TENDN VARCHAR(32)
AS
	BEGIN
	
			DELETE FROM NGUOIDUNG WHERE TENDANGNHAP=@TENDN	
	END
	
alter PROC [dbo].[SP_NGUOIDUNG_SUA] @TENDN VARCHAR(32), @MATKHAU VARCHAR(32), @ADMIN BIT,
 @THEM BIT, @XOA BIT, @SUA BIT
AS
	BEGIN
		IF NOT EXISTS(SELECT TENDANGNHAP FROM NGUOIDUNG WHERE TENDANGNHAP=@TENDN)
			BEGIN
				RAISERROR(N'Tên đăng nhập không tồn tại!', 16, 1)
				RETURN
			END
		ELSE
			UPDATE NGUOIDUNG SET TENDANGNHAP=@TENDN, MATKHAU=@MATKHAU, QUYENADMIN=@ADMIN,
			 QUYENTHEM=@THEM, QUYENXOA=@XOA, QUYENSUA=@SUA
			WHERE TENDANGNHAP=@TENDN
	END
	
	insert into NGUOIDUNG VALUES('admin','giang6315', 1,1,1,1)
	
	select * from NGUOIDUNG