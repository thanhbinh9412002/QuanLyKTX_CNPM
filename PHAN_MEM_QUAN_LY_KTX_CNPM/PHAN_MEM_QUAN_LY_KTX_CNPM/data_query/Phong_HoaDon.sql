create database KTX
GO
use KTX
GO

create table DangNhap (
	TenDangNhap char(15) ,
	MatKhau char(20) NOT NULL,
	VaiTro nvarchar(10),
	Constraint PK_TaiKhoan Primary Key (TenDangNhap)
)
GO

CREATE TABLE SinhVien(
    MaSinhVien char(10) NOT NULL,
    HoTen nvarchar(50) NOT NULL,
    SoDienThoai nchar(50) NOT NULL,
    GioiTinh nvarchar(10) NOT NULL,
    NamHoc int NOT NULL,
    TonGiao nvarchar(10) NOT NULL,
    QuocTich nvarchar(10) NOT NULL,
    CMND_CCCD char(15) NOT NULL,
    MaPhong char(10) NOT NULL,
	SoKy int ,
    Constraint PK_SinhVien Primary Key (MaSinhVien)
)
GO

create table TaiKhoanSV (
	MaTK char(10),
	TinhTrang bit ,
	NgayCap Date,
	NgayHetHan Date,
	TenChuTK nvarchar(50),
	Constraint PK_TaiKhoanSV Primary Key (MaTK)
)
GO

create table Phong (
	MaPhong char(10) primary key ,
	GiaPhong int,
	SoLuongSinhVienHienTai int,
	SoLuongSinhVienToiDa int ,
	TinhTrang bit
)
GO

create table TrangThietBi (
	MaThietBi char(10),
	MaPhong char(10),
	TenThietBi nvarchar(20) NOT NULL,
	SoLuongHong int NOT NULL,
	SoLuongTot int NOT NULL,
	Constraint PK_PhongThietBi Primary Key (MaThietBi,MaPhong)
)
GO


create table HoaDon (
	MAHD char(10),
	MaPhong char(10), 
	NgayLapHD Date,
	Constraint PK_HoaDon Primary Key (MAHD)
)
GO


create table ChiTietHoaDon(
	MAHD char(10),
	SoDien int,
	SoNuoc int,
	GiaDien float,
	GiaNuoc float,
	Constraint PK_ChiTietHD Primary Key (MAHD)
)
GO

create table ThongBao (
	Id int IDENTITY(1,1) PRIMARY KEY,
	TieuDe nvarchar(100),
	NoiDung nvarchar(1000),
	NgayDang Date,
)
GO

create table SuaChua(
	Id int IDENTITY(1,1) PRIMARY KEY, 
	TenThietBi nvarchar(20) NOT NULL,
	SoLuong int,
	ChiTiet nvarchar(50)
)
GO

create table GiaHan (
	Id int IDENTITY(1,1) PRIMARY KEY,
	MaSinhVien char(10),
	SoKy int
)
GO

create table TraPhong(
	Id int IDENTITY(1,1) PRIMARY KEY,
	MaPhong char(10),
	MaSinhVien char(10),
	NgayTra Date
)
GO

ALTER TABLE GiaHan  
ADD FOREIGN KEY (MaSinhVien) REFERENCES SinhVien(MaSinhVien)
GO

ALTER TABLE TraPhong
ADD FOREIGN KEY (MaSinhVien) REFERENCES SinhVien(MaSinhVien),
	FOREIGN KEY (MaPhong) REFERENCES Phong(MaPhong);
GO

ALTER TABLE SinhVien WITH CHECK ADD CONSTRAINT 
FK_SinhVien_Phong 
FOREIGN KEY (MaPhong) REFERENCES Phong(MaPhong)
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE SinhVien CHECK CONSTRAINT FK_SinhVien_Phong
GO

ALTER TABLE TaiKhoanSV WITH CHECK ADD CONSTRAINT 
FK_SinhVien_TaiKhoan 
FOREIGN KEY (MaTK) REFERENCES SinhVien(MaSinhVien)
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE TaiKhoanSV CHECK CONSTRAINT FK_SinhVien_TaiKhoan
GO

ALTER TABLE TrangThietBi
ADD CONSTRAINT FK_ThietBi_Phong
FOREIGN KEY (MaPhong) REFERENCES Phong(MaPhong)
ON DELETE CASCADE;
GO
ALTER TABLE TrangThietBi CHECK CONSTRAINT FK_ThietBi_Phong
GO

ALTER TABLE HoaDon WITH CHECK ADD CONSTRAINT FK_HoaDon_Phong 
FOREIGN KEY (MaPhong) REFERENCES Phong(MaPhong)
ON DELETE CASCADE;
GO
ALTER TABLE HoaDon CHECK CONSTRAINT FK_HoaDon_Phong
GO

ALTER TABLE ChiTietHoaDon WITH CHECK ADD CONSTRAINT FK_ChiTietHoaDon_HoaDon 
FOREIGN KEY (MAHD) REFERENCES HoaDon(MAHD)
ON DELETE CASCADE;
GO
ALTER TABLE ChiTietHoaDon CHECK CONSTRAINT FK_ChiTietHoaDon_HoaDon
GO

-- Ràng buộc điều kiện
ALTER TABLE SinhVien WITH CHECK ADD CONSTRAINT 
CHECK_CMND_CCCD_SV CHECK ((len(CMND_CCCD)=(9)) or (len(CMND_CCCD)=(12)))
GO
--Done
ALTER TABLE SinhVien WITH CHECK ADD CONSTRAINT 
CHECK_SDT_SV CHECK ((len(SoDienThoai)=(10)))
GO

ALTER TABLE ChiTietHoaDon WITH CHECK ADD CONSTRAINT 
CHECK_SoTien_HoaDon CHECK (SoDien > 0 and SoNuoc > 0)
GO

--Alter table HoaDonDienNuoc drop constraint CHECK_SoTien_HoaDonDienNuoc
--Done
ALTER TABLE DangNhap WITH CHECK ADD CONSTRAINT 
CHECK_MatKhau_TaiKhoan CHECK ((len(MatKhau)>=(8)))
GO

--Done
ALTER TABLE Phong WITH CHECK ADD CONSTRAINT
CHECK_SoluongSV CHECK ((SoLuongSinhVienHienTai>=(0) AND
SoLuongSinhVienToiDa<(9)))
GO

ALTER TABLE TrangThietBi WITH CHECK ADD CONSTRAINT 
CHECK_SoThietBiTrongPhong CHECK (SoLuongHong >= (0) and SoLuongTot >= (0))
GO


--																	Trigger
CREATE TRIGGER Tg_ThemTaiKhoan
ON SinhVien
FOR INSERT
AS
BEGIN
		INSERT INTO TaiKhoanSV(
			MaTK ,
			TinhTrang ,
			NgayCap,
			NgayHetHan,
			TenChuTK
		)
		SELECT
			i.MaSinhVien,
			1,
			CAST( GETDATE() AS Date ),
			DATEADD(year,5, CAST( GETDATE() AS Date )),
			i.HoTen
			FROM inserted i
END
GO
--Done
CREATE TRIGGER Tg_ThemThongTinDangNhap
ON SinhVien
FOR INSERT
AS
BEGIN
	INSERT INTO DangNhap(
			TenDangNhap,
			MatKhau,
			VaiTro
		)
		SELECT
			i.CMND_CCCD,
			i.CMND_CCCD,
			null
			FROM inserted i
END
GO
-- Done
CREATE TRIGGER tg_XoaThongTinDangNhapSinhVien
ON SinhVien
FOR DELETE
AS
	BEGIN
		DELETE FROM TaiKhoanSV
		FROM deleted i
		WHERE MaTK = i.MaSinhVien
	END
GO
-- Done
CREATE TRIGGER tg_Phong 
ON Phong
AFTER INSERT, UPDATE
AS
	BEGIN
		if (select count(*) as Count 
				from (select MaPhong from inserted where MaPhong is not null and MaPhong like'%[a-zA-Z][0-9]%') as q) = 0
					ROLLBACK TRANSACTION
	END
GO
--Done
CREATE TRIGGER tg_SoLuongSinhVienTrongPhongKhiThem
ON SinhVien
AFTER INSERT
AS
BEGIN
	SET NOCOUNT ON;
	DECLARE @SoLuongSinhVien int, @SoLuongSinhVienToiDa int
	SELECT @SoLuongSinhVien = Phong.SoLuongSinhVienHienTai,@SoLuongSinhVienToiDa = Phong.SoLuongSinhVienToiDa
	FROM inserted, Phong
	WHERE inserted.MaPhong= Phong.MaPhong
	IF(@SoLuongSinhVien >= @SoLuongSinhVienToiDa)
		BEGIN
			RAISERROR(N'Phòng đã đủ sinh viên', 16,1)
			ROLLBACK
		END
	ELSE
		BEGIN 
			UPDATE Phong SET SoLuongSinhVienHienTai = SoLuongSinhVienHienTai + 1
			FROM inserted, Phong
			WHERE Phong.MaPhong = inserted.MaPhong
		END
END
GO
--one
CREATE TRIGGER tg_SoLuongSinhVienTrongPhongKhiSua
ON SinhVien
AFTER UPDATE
AS
BEGIN
	SET NOCOUNT ON;
	DECLARE @SoLuongSinhVien int, @SoLuongSinhVienToiDa int, @SoPhongCu nchar(10), @SoPhongMoi nchar(10)
	SELECT @SoLuongSinhVien = Phong.SoLuongSinhVienHienTai, @SoLuongSinhVienToiDa = Phong.SoLuongSinhVienToiDa,@SoPhongMoi = updated.MaPhong,@SoPhongCu = deleted.MaPhong
	FROM inserted updated,deleted, Phong
	WHERE updated.MaPhong = Phong.MaPhong
	IF(@SoPhongCu != @SoPhongMoi)
	BEGIN
		IF(@SoLuongSinhVien >= @SoLuongSinhVienToiDa)
		BEGIN
			RAISERROR(N'Phòng đã đủ sinh viên', 16,1)
			ROLLBACK TRANSACTION
		END
		ELSE
		BEGIN 
			UPDATE Phong SET SoLuongSinhVienHienTai = SoLuongSinhVienHienTai - 1
			FROM deleted, Phong
			WHERE Phong.MaPhong = deleted.MaPhong
			UPDATE Phong SET SoLuongSinhVienHienTai = SoLuongSinhVienHienTai + 1
			FROM inserted updated, Phong
			WHERE Phong.MaPhong = updated.MaPhong
		END
	END
END
GO
-- Done
CREATE TRIGGER tg_GiamSoLuongSinhVien
ON SinhVien
FOR DELETE
AS
BEGIN
	SET NOCOUNT ON;
	DECLARE @SoLuongSinhVien int
	SELECT @SoLuongSinhVien = Phong.SoLuongSinhVienHienTai
	FROM deleted , Phong
	WHERE deleted.MaPhong = Phong.MaPhong

	UPDATE Phong SET SoLuongSinhVienHienTai = SoLuongSinhVienHienTai - 1
	FROM deleted, Phong
	WHERE Phong.MaPhong = deleted.MaPhong
END
GO
--Done
CREATE TRIGGER tg_ThemHoaDon
ON HoaDon
AFTER INSERT, UPDATE
AS 
BEGIN
	SET NOCOUNT ON;
	DECLARE @SoSinhVien int
	SELECT @SoSinhVien = Phong.SoLuongSinhVienHienTai
	FROM inserted, Phong 
	WHERE inserted.MaPhong = Phong.MaPhong
	IF (@SoSinhVien = 0)
	BEGIN
		RAISERROR(N'Phòng trống', 16,1)
		ROLLBACK TRANSACTION
	END
END
GO

insert into Phong values ('A101',2000000,5,8,1)

insert into SinhVien Values('20133104',N'Nguyễn Văn Thanh','0367064834', N'Nam',3,N'Không',N'Việt Nam','221502781','A101',1)
insert into SinhVien Values('20133105',N'Nguyễn Văn Thanh','0367064834', N'Nam',3,N'Không',N'Việt Nam','221502782','A101',1)

insert into HoaDon values('HD1','A101','2022-12-12')

insert into ChiTietHoaDon values('HD1',100,100,3.2,15000)

insert into ThongBao values(N'Nghỉ học','Các em nghỉ học nhé','2022-12-12')

insert into TrangThietBi Values('TB1','A101', 'Giường' , 0,4 )



	

 