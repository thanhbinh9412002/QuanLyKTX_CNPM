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

-- Tạo bảng trang thiết bị
create table TrangThietBi (
	MaThietBi char(10),
	TenThietBi nvarchar(20) NOT NULL,
	TongSoLuong int NOT NULL,
	Constraint PK_TrangThietBi Primary Key (MaThietBi)
)
GO
-- Tạo bảng thiết bị trong phòng
create table ThietBiTrongPhong (
	MaThietBiTrongPhong char(10),
	MaPhong char(10),
	SoLuongHong int NOT NULL,
	SoLuongTot int NOT NULL,
	SoLuongToiDa int NOT NULL
	Constraint PK_PhongThietBi Primary Key (MaThietBiTrongPhong,MaPhong)
)
GO



create table HoaDon (
	MAHD char(10),
	MaPhong char(10), 
	NgayLapHD Date,
	TrangThai bit,
	TongTien float,
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
	ChiTiet nvarchar(1000),
	TrangThai bit
)
GO

create table GiaHan (
	Id int IDENTITY(1,1) PRIMARY KEY,
	MaSinhVien char(10),
	SoKy int,
	TrangThai bit
)
GO

create table TraPhong(
	Id int IDENTITY(1,1) PRIMARY KEY,
	MaPhong char(10),
	MaSinhVien char(10),
	NgayTra Date,
	TrangThai bit
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

ALTER TABLE ThietBiTrongPhong
ADD CONSTRAINT FK_ThietBiPhong_Phong
FOREIGN KEY (MaPhong) REFERENCES Phong(MaPhong)
ON DELETE CASCADE;
GO
ALTER TABLE ThietBiTrongPhong CHECK CONSTRAINT FK_ThietBiPhong_Phong
GO
--Done
ALTER TABLE ThietBiTrongPhong
WITH CHECK ADD CONSTRAINT FK_TrangThietBi_ThietBi
FOREIGN KEY (MaThietBiTrongPhong) REFERENCES TrangThietBi(MaThietBi)
ON DELETE CASCADE;
GO
--Done
ALTER TABLE ThietBiTrongPhong CHECK CONSTRAINT FK_TrangThietBi_ThietBi
GO
--Done
ALTER TABLE ThietBiTrongPhong
ADD CONSTRAINT FK_ThietBiTrongPhong_Phong
FOREIGN KEY (MaPhong) REFERENCES Phong(MaPhong)
ON DELETE CASCADE;
GO
--Done
ALTER TABLE ThietBiTrongPhong CHECK CONSTRAINT FK_ThietBiTrongPhong_Phong
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
		INSERT INTO DangNhap(
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
			'Sinh Viên'
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


insert into Phong values ('P101',200000, 0 , 6 , 1)
insert into Phong values ('P102',200000, 0 , 6 , 1)
insert into Phong Values ('P203',500000, 0 , 4 , 1)
insert into Phong Values ('P301',150000, 0 , 8 , 1)
insert into Phong Values ('P505',150000, 0 , 4 , 1)
insert into Phong Values ('P406',150000, 0 , 8 , 1)
insert into Phong Values ('P307',500000, 0 , 4 , 1)
insert into Phong Values ('P602',500000, 0 , 4 , 1)
insert into Phong Values ('P709',200000, 0 , 6 , 1)


insert into SinhVien Values('20133104',N'Nguyễn Văn Thanh','0367064834', N'Nam',3,N'Không',N'Việt Nam','221502781','P101',1)
insert into SinhVien Values('20133105',N'Nguyễn Văn Thanh','0367064834', N'Nam',3,N'Không',N'Việt Nam','221502782','P101',1)

insert into SinhVien Values('20133104',N'Nguyễn Văn Thanh','0367064834', N'Nam',3,N'Không',N'Việt Nam','221502781','P102',2)
insert into SinhVien Values('22133102',N'Lương Sĩ Hoàng','0312452123', N'Nam',1,N'Không',N'Việt Nam','221531232','P102',2)
insert into SinhVien Values('21133101',N'Trần Thái Tú','0364412341', N'Nam',2,N'Không',N'Việt Nam','221512453','P102',1)

insert into SinhVien Values('22133133',N'Cao Tuấn Tú','0367125212', N'Nam',3,N'Không',N'Việt Nam','221512654','P203',2)

insert into SinhVien Values('21133122',N'Nguyễn Phước Ninh','0367784321', N'Nam',2,N'Không',N'Việt Nam','221586215','P301',2)
insert into SinhVien Values('22412122',N'Nguyễn Thanh Tuấn ','0367095412', N'Nam',1,N'Không',N'Việt Nam','221587656','P301',2)

insert into SinhVien Values('21133166',N'Huỳnh Công Hậu','0367987431', N'Nam',2,N'Không',N'Việt Nam','221574767','P505',1)
insert into SinhVien Values('20133123',N'Nguyễn Sĩ','0367053412', N'Nam',3,N'Không',N'Việt Nam','221534548','P505',1)
insert into SinhVien Values('20133111',N'Nguyễn Tuyên','0322234123', N'Nam',3,N'Không',N'Việt Nam','221521239','P505',2)
insert into SinhVien Values('21147523',N'Nguyễn Phước Minh','0367784375', N'Nam',2,N'Không',N'Việt Nam','221586215','P505',1)

insert into SinhVien Values('22133752',N'Nguyễn Thị Thanh ','0372403491', N'Nữ',1,N'Không',N'Việt Nam','221543157','P406',2)

insert into SinhVien Values('21241242',N'Huỳnh Lê Vân','0367784295', N'Nữ',2,N'Không',N'Việt Nam','221521232','P709',1)
insert into SinhVien Values('20196542',N'Nguyễn Thị Thùy','0367823472', N'Nữ',3,N'Không',N'Việt Nam','221551921','P709',2)


insert into HoaDon values('HD1','A102','2022-12-12',0,300000)
insert into HoaDon values('HD2','A101','2022-12-12',0,200000)


insert into ChiTietHoaDon values('HD1',100,100,3.2,15000)
insert into ChiTietHoaDon values('HD2',100,100,3.2,15000)


insert into ThongBao values(N'Nghỉ học','Các em nghỉ học nhé','2022-12-12')


--insert into TrangThietBi Values('TB1','A101', 'Giường' , 0,4 )
insert into TrangThietBi Values('TB1', N'Bóng đèn',50)
insert into TrangThietBi Values('TB2', N'Giường' ,80)
insert into TrangThietBi Values('TB3', N'Tủ' ,90)
insert into TrangThietBi Values('TB4', N'Quạt' ,45)
insert into TrangThietBi Values('TB5', N'Sào phơi đồ',60)
GO



GO
create function [dbo].[func_DanhSachPhong] ()
returns table
	as
	return 
		select p.MaPhong, p.GiaPhong, p.SoLuongSinhVienHienTai, p.SoLuongSinhVienToiDa, p.TinhTrang
		From Phong as p

GO
create function [dbo].[func_HoaDonPhong]( @MaPhong char(10))
returns table
	as
		return select HD.MAHD as [Mã Hóa Đơn],
					HD.MaPhong as [Mã phòng],
					HD.NgayLapHD as [Ngày lập],
					HD.TrangThai as [Trạng thái],
					HD.TongTien as [Tổng tiền]
				from  HoaDon as HD 
				where HD.MaPhong = @MaPhong

GO
create procedure [dbo].[proc_ThemHoaDon]
(	@MAHD char(10),
	@MaPhong char(10),
	@NgayLapHD Date,
	@TrangThai bit,
	@TongTien float
)
as insert into HoaDon Values(@MAHD, @MaPhong, @NgayLapHD, @TrangThai, @TongTien);

GO
create procedure [dbo].[proc_ThemChitietHoaDon]
(	@MAHD char(10),
	@SoDien int,
	@SoNuoc int,
	@GiaDien float,
	@GiaNuoc float
)
as insert into ChiTietHoaDon Values(@MAHD, @SoDien, @SoNuoc, @GiaDien, @GiaNuoc);

GO
create function [dbo].[func_ChitietHD]( @MaHD char(10))
returns table
	as
		return select ctHD.MAHD as [Mã Hóa Đơn],
					ctHD.SoDien as [Số điện],
					ctHD.SoNuoc as [Số nước],
					ctHD.GiaDien as [Giá điện],
					ctHD.GiaNuoc as [Giá nước]
				from  ChiTietHoaDon as ctHD 
				where ctHD.MAHD = @MaHD

GO
create function [dbo].[func_HoaDonChuaThanhToan] (@MaPhong char(10))
returns table
	as
		return select HD.MAHD as [Mã Hóa Đơn],
					HD.MaPhong as [Mã phòng],
					HD.NgayLapHD as [Ngày lập],
					HD.TrangThai as [Trạng thái],
					HD.TongTien as [Tổng tiền]
				from  HoaDon as HD 
				where HD.TrangThai = 0 and HD.MaPhong = @MaPhong

GO
create procedure [dbo].[proc_SuaHoaDon] (@mahd char(10), @maphong char(10),  @ngaytao Date, @TrangThai bit, @TongTien float)
as 
update HoaDon set MAHD = @mahd,
				  MaPhong = @maphong,
				  NgayLapHD = @ngaytao,
				  TrangThai = @TrangThai,
				  TongTien = @TongTien
where MAHD = @mahd
go

-- Kiem tra dang nhap
create function [dbo].[func_KiemTraDangNhap] (@TenTK char(15), @MK char(20), @Vaitro nvarchar(10))
returns int
	as
		begin
			declare @check int
			if exists (select * from DangNhap
						where @TenTK=DangNhap.TenDangNhap and @MK=DangNhap.MatKhau and
							@Vaitro=VaiTro)
						set @check=1
			else	
					set @check=0
			return @check
		end
GO
-- Doi mat khau

create procedure [dbo].[proc_DoiMatKhau] (@tentk char(15), @mk char(20) )
as update DangNhap
	set MatKhau = @mk
	where TenDangNhap = @tentk
go
 