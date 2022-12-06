create database KTX
GO
use KTX
GO

create table DangNhap (
	TenDangNhap char(15) ,
	MatKhau char(20) NOT NULL,
	VaiTro nvarchar(10),
	TrangThai bit,
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
	TinhTrang nvarchar(25)
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
	ChiTiet nvarchar(500),
	TrangThai nvarchar(50)
)
GO

create table GiaHan (
	Id int IDENTITY(1,1) PRIMARY KEY,
	MaSinhVien char(10),
	SoKy int,
	TrangThai nvarchar(50)
)
GO

create table TraPhong(
	Id int IDENTITY(1,1) PRIMARY KEY,
	MaPhong char(10),
	MaSinhVien char(10),
	NgayTra Date,
	TrangThai nvarchar(50)
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

/*ALTER TABLE TrangThietBi
ADD CONSTRAINT FK_ThietBi_Phong
FOREIGN KEY (MaPhong) REFERENCES Phong(MaPhong)
ON DELETE CASCADE;
GO
ALTER TABLE TrangThietBi CHECK CONSTRAINT FK_ThietBi_Phong
GO*/
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

ALTER TABLE ThietBiTrongPhong WITH CHECK ADD CONSTRAINT 
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
create TRIGGER Tg_ThemThongTinDangNhap
ON SinhVien
FOR INSERT
AS
BEGIN
	INSERT INTO DangNhap(
			TenDangNhap,
			MatKhau,
			VaiTro,
			TrangThai
		)
		SELECT
			i.CMND_CCCD,
			i.CMND_CCCD,
			'Sinh viên',
			1
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


insert into Phong values ('P101',200000, 0 , 6 , N'Đang sử dụng')
insert into Phong values ('P102',200000, 0 , 6 , N'Đang sử dụng')
insert into Phong Values ('P203',500000, 0 , 4 , N'Đang sử dụng')
insert into Phong Values ('P301',150000, 0 , 8 , N'Đang sử dụng')
insert into Phong Values ('P505',150000, 0 , 4 , N'Đang sử dụng')
insert into Phong Values ('P406',150000, 0 , 8 , N'Đang sử dụng')
insert into Phong Values ('P307',500000, 0 , 4 , N'Đang sử dụng')
insert into Phong Values ('P602',500000, 0 , 4 , N'Đang sử dụng')
insert into Phong Values ('P709',200000, 0 , 6 , N'Đang sử dụng')


insert into SinhVien Values('20133104',N'Nguyễn Văn Thanh','0367064834', N'Nam',3,N'Không',N'Việt Nam','221502781','P101',1)
insert into SinhVien Values('20133105',N'Nguyễn Văn Thanh','0367064834', N'Nam',3,N'Không',N'Việt Nam','221502782','P101',1)

insert into SinhVien Values('20133107',N'Nguyễn Văn Thanh','0367064834', N'Nam',3,N'Không',N'Việt Nam','221502788','P102',2)
insert into SinhVien Values('22133102',N'Lương Sĩ Hoàng','0312452123', N'Nam',1,N'Không',N'Việt Nam','221531232','P102',2)
insert into SinhVien Values('21133101',N'Trần Thái Tú','0364412341', N'Nam',2,N'Không',N'Việt Nam','221512453','P102',1)

insert into SinhVien Values('22133133',N'Cao Tuấn Tú','0367125212', N'Nam',3,N'Không',N'Việt Nam','221512654','P203',2)

insert into SinhVien Values('21133122',N'Nguyễn Phước Ninh','0367784321', N'Nam',2,N'Không',N'Việt Nam','221586219','P301',2)
insert into SinhVien Values('22412122',N'Nguyễn Thanh Tuấn ','0367095412', N'Nam',1,N'Không',N'Việt Nam','221587656','P301',2)

insert into SinhVien Values('21133166',N'Huỳnh Công Hậu','0367987431', N'Nam',2,N'Không',N'Việt Nam','221574767','P505',1)
insert into SinhVien Values('20133123',N'Nguyễn Sĩ','0367053412', N'Nam',3,N'Không',N'Việt Nam','221534548','P505',1)
insert into SinhVien Values('20133111',N'Nguyễn Tuyên','0322234123', N'Nam',3,N'Không',N'Việt Nam','221521239','P505',2)
insert into SinhVien Values('21147523',N'Nguyễn Phước Minh','0367784375', N'Nam',2,N'Không',N'Việt Nam','221586215','P505',1)

insert into SinhVien Values('22133752',N'Nguyễn Thị Thanh ','0372403491', N'Nữ',1,N'Không',N'Việt Nam','221543157','P406',2)

insert into SinhVien Values('21241242',N'Huỳnh Lê Vân','0367784295', N'Nữ',2,N'Không',N'Việt Nam','221521232','P709',1)
insert into SinhVien Values('20196542',N'Nguyễn Thị Thùy','0367823472', N'Nữ',3,N'Không',N'Việt Nam','221551921','P709',2)



insert into ThongBao values(N'Nghỉ học',N'Các em nghỉ học nhé','2022-12-12')


--insert into TrangThietBi Values('TB1','A101', 'Giường' , 0,4 )
insert into TrangThietBi Values('TB1', N'Bóng đèn',50)
insert into TrangThietBi Values('TB2', N'Giường' ,80)
insert into TrangThietBi Values('TB3', N'Tủ' ,90)
insert into TrangThietBi Values('TB4', N'Quạt' ,45)
insert into TrangThietBi Values('TB5', N'Sào phơi đồ',60)
GO

insert into ThietBiTrongPhong Values('TB1','P101', 2 , 2, 4)
insert into ThietBiTrongPhong Values('TB2','P101', 0 , 2, 2)
insert into ThietBiTrongPhong Values('TB3','P101', 0 , 1, 1)
insert into ThietBiTrongPhong Values('TB4','P101', 1 , 1, 2)
insert into ThietBiTrongPhong Values('TB5','P101', 1 , 3, 4)
insert into ThietBiTrongPhong Values('TB1','P102', 2 , 0, 2)
insert into ThietBiTrongPhong Values('TB2','P102', 0 , 1, 1)
insert into ThietBiTrongPhong Values('TB3','P102', 2 , 0, 2)
insert into ThietBiTrongPhong Values('TB4','P102', 0 , 1, 1)
insert into ThietBiTrongPhong Values('TB5','P102', 1 , 1, 2)
GO

create procedure [dbo].[proc_ThemThietBiTrongPhong]
(	@matb char(10),
	@maphong char(10),
	@soluonghong int,
	@soluongtot int,
	@soluongtoida int
	)
as insert into ThietBiTrongPhong Values(@matb, @maphong, @soluonghong, @soluongtot, @soluongtoida);
GO
create procedure [dbo].[proc_SuaThietBiTrongPhong]
(	@matb char(10),
	@maphong char(10),
	@soluonghong int,
	@soluongtot int,
	@soluongtoida int
	)
as update ThietBiTrongPhong
set MaThietBiTrongPhong = @matb,
	MaPhong = @maphong,
	SoLuongHong = @soluonghong,
	SoLuongTot = @soluongtot,
	SoLuongToiDa = @soluongtoida
where MaThietBiTrongPhong = @matb and MaPhong = @maphong;
GO
create procedure [dbo].[proc_XoaThietBiTrongPhong] (@matb char(10), @maphong char(10))
as delete ThietBiTrongPhong where MaThietBiTrongPhong = @matb and MaPhong = @maphong
GO
create function [dbo].[func_DanhSachPhong] ()
returns table
	as
	return 
		select p.MaPhong as [Mã Phòng], 
		p.GiaPhong as [Giá Phòng], 
		p.SoLuongSinhVienHienTai as [Số Sinh Viên Hiện Tại], 
		p.SoLuongSinhVienToiDa as [Số Sinh Viên Tối Đa], 
		p.TinhTrang as [Tình Trạng]
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
GO
create procedure [dbo].[proc_SuaChiTietHoaDon] (
@MAHD char(10),
	@SoDien int,
	@SoNuoc int,
	@GiaDien float,
	@GiaNuoc float)
as 
update ChiTietHoaDon set MAHD = @MAHD,
				  SoDien = @SoDien,
				  SoNuoc = @SoNuoc,
				  GiaDien = @GiaDien,
				  GiaNuoc = @GiaNuoc
where MAHD = @MAHD

/*create function [dbo].[func_LaySoDien](@MAHD char(10)) 
returns int
AS 
BEGIN 
    DECLARE @sodien int 
    SELECT @sodien=ChiTietHoaDon.SoDien
	from ChiTietHoaDon
	where ChiTietHoaDon.MAHD = @MAHD
    RETURN @sodien
END
create function [dbo].[func_LaySoNuoc](@MAHD char(10)) 
returns int
AS 
BEGIN 
    DECLARE @sonuoc int 
    SELECT @sonuoc=ChiTietHoaDon.SoNuoc
	from ChiTietHoaDon
	where ChiTietHoaDon.MAHD = @MAHD
    RETURN @sonuoc
END
create function [dbo].[func_LayGiaDien](@MAHD char(10)) 
returns float
AS 
BEGIN 
    DECLARE @giadien float 
    SELECT @giadien=ChiTietHoaDon.GiaDien
	from ChiTietHoaDon
	where ChiTietHoaDon.MAHD = @MAHD
    RETURN @giadien
END
create function [dbo].[func_LayGiaNuoc](@MAHD char(10)) 
returns float
AS 
BEGIN 
    DECLARE @gianuoc float 
    SELECT @gianuoc=ChiTietHoaDon.GiaNuoc
	from ChiTietHoaDon
	where ChiTietHoaDon.MAHD = @MAHD
    RETURN @gianuoc
END*/
GO
create function [dbo].[func_KiemtraTaoHD](@MaPhong char(10)) 
returns int
AS 
BEGIN 
	DECLARE @check int
    IF EXISTS (SELECT hd.TrangThai FROM HoaDon as hd WHERE hd.TrangThai=0 and hd.MaPhong = @MaPhong ) 
	BEGIN
		set  @check=0
	END
	ELSE
	BEGIN
		set  @check=1
	END
	return @check
END
GO
create function [dbo].[func_LayTKSV] (@MaSinhVien char(10))
returns table
	as
		return select tk.MaTK as [Mã tài],
					tk.TinhTrang as [Tình trạng],
					tk.NgayCap as [Ngày cấp],
					tk.NgayHetHan as [Ngày hết hạn],
					tk.TenChuTK as [Tên chủ tk]
				from  TaiKhoanSV as tk
				where tk.MaTK = @MaSinhVien

GO
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

-- Lấy mã phòng

create function [dbo].[func_LayMaPhong](@cmnd char(15)) 
returns char(15)
AS 
BEGIN 
    DECLARE @maphong char(15) 
    SELECT @maphong = MaPhong  
	from SinhVien
	where CMND_CCCD = @cmnd
    RETURN @maphong
END
GO

-- Lấy sinh viên

create function [dbo].[func_LayMaSinhVien](@cmnd char(15)) 
returns char(10)
AS 
BEGIN 
    DECLARE @masv char(10) 
    SELECT @masv = MaSinhVien  
	from SinhVien
	where CMND_CCCD = @cmnd
    RETURN  @masv
END
GO

insert into DangNhap values ('215536972','215536972',N'Quản Lý',1)
go
--Danh sách sinh viên theo phòng
Create function [dbo].[func_DanhSachSinhVienTheoPhong] (@MaPhong char(10))
returns table
as
	return
		select  SV.MaSinhVien as [Mã Sinh Viên],
		SV.HoTen as [Họ Tên],
		SV.SoDienThoai as [Số Điện Thoại],
		SV.GioiTinh as [Giới Tính],
		SV.NamHoc as [Năm Học],
		SV.TonGiao as [Tôn Giáo],
		SV.QuocTich as [Quốc Tịch],
		SV.CMND_CCCD as [CMND/CCCD],
		SV.SoKy as [Số Kỳ]
		FROM SinhVien as SV inner join Phong on SV.MaPhong=Phong.MaPhong
			Where Phong.MaPhong=@MaPhong
go
--Danh sách thông báo 
Create function [dbo].[func_DanhsachThongBao]() 
returns table
as
	return select TieuDe,NoiDung,NgayDang
				from ThongBao
go
--Xóa phòng
Create procedure [dbo].[proc_XoaPhong](@MaPhong char(10))
as delete Phong Where MaPhong = @MaPhong;
go
--Thêm Phòng
Create procedure [dbo].[proc_ThemPhong]
(@MaPhong char(10),@GiaPhong int,@SoLuongSinhVienHienTai int , @SoLuongSinhVienToiDa int, @TinhTrang nvarchar(25))
as
insert into Phong values(@MaPhong,@GiaPhong,@SoLuongSinhVienHienTai,@SoLuongSinhVienToiDa,@TinhTrang);
go
--Sửa phòng
Create procedure [dbo].[proc_SuaPhong] (@MaPhong char(10),@GiaPhong int, @SoLuongSinhVienHienTai int,@SoLuongSinhVienToiDa int,@TinhTrang nvarchar(25))
as update Phong
set MaPhong = @MaPhong,
	GiaPhong = @GiaPhong,
	SoLuongSinhVienHienTai = @SoLuongSinhVienHienTai,
	SoLuongSinhVienToiDa = @SoLuongSinhVienToiDa,
	TinhTrang = @TinhTrang
where MaPhong = @MaPhong;
go
--Gửi thông báo 
Create procedure [dbo].[proc_GuiThongBao](@tieude nvarchar(100), @noidung nvarchar(1000),@ngaydang date)
as
insert into ThongBao Values(@tieude, @noidung, @ngaydang);
go
--Danh sách Phòng Đầy
Create procedure [dbo].[pro_DanhSachPhongDay]
as
SELECT MaPhong,GiaPhong,SoLuongSinhVienHienTai, SoLuongSinhVienToiDa,TinhTrang
  FROM Phong
  WHERE SoLuongSinhVienHienTai = SoLuongSinhVienToiDa
 go
--Danh sách phòng Còn Chỗ
Create procedure [dbo].[pro_DanhSachPhongConCho]
as
SELECT MaPhong,GiaPhong,SoLuongSinhVienHienTai, SoLuongSinhVienToiDa,TinhTrang
  FROM Phong
  WHERE SoLuongSinhVienHienTai < SoLuongSinhVienToiDa
 go
--Lấy Mã phòng
Create procedure [dbo].[pro_DanhSachPhong_MaPhong]
as
SELECT MaPhong 
	FROM Phong
go
create view view_DanhsachSinhvien
as(
	select MaSinhVien as [MSSV],
			HoTen as [Họ tên],
			SoDienThoai as [Số điện thoại],
			GioiTinh [Giới tính],
			NamHoc as [Nam học],
			TonGiao as [Tôn giáo],
			QuocTich as [Quốc tịch],
			CMND_CCCD as [CMND/CCCD],
			MaPhong as [Mã Phòng],
			SoKy as [Số Kỳ]
	from SinhVien
)
go
create procedure proc_Themsinhvien
(
	@MaSinhVien char(10),
    @HoTen nvarchar(50) ,
    @SoDienThoai nvarchar(50) ,
    @GioiTinh nvarchar(10) ,
    @NamHoc int ,
    @TonGiao nvarchar(10) ,
    @QuocTich nvarchar(10) ,
    @CMND_CCCD char(15),
    @MaPhong char(10),
	@SoKy int 
)
as insert SinhVien values (@MaSinhVien, @HoTen, @SoDienThoai, @GioiTinh, @NamHoc, @TonGiao, @QuocTich, @CMND_CCCD, @MaPhong,@SoKy)
go
create procedure proc_Suasinhvien
(
	@MaSinhVien char(10),
    @HoTen nvarchar(50) ,
    @SoDienThoai nvarchar(50) ,
    @GioiTinh nvarchar(10) ,
    @NamHoc int ,
    @TonGiao nvarchar(10) ,
    @QuocTich nvarchar(10) ,
    @CMND_CCCD char(15),
    @MaPhong char(10),
	@SoKy int 
)
as update SinhVien 
set MaSinhVien=@MaSinhVien,
	HoTen=@HoTen,
	SoDienThoai=@SoDienThoai,
	GioiTinh=@GioiTinh,
	NamHoc=@NamHoc,
	TonGiao=@TonGiao,
	QuocTich=@QuocTich,
	CMND_CCCD=@CMND_CCCD,
	MaPhong=@MaPhong,
	SoKy=@SoKy
where MaSinhVien = @MaSinhVien
go

create procedure proc_xoasinhvien(@MaSinhVien char(10))
as delete SinhVien where MaSinhVien=@MaSinhVien
go


create procedure [dbo].[CapnhattrangThaiSuaChua](@id int, @trangthai nvarchar(50))
as update SuaChua
set TrangThai = @trangthai
where Id = @id
go

create procedure [dbo].[CapnhattrangThaiTraPhong](@id int, @trangthai nvarchar(50))
as update TraPhong
set TrangThai = @trangthai
where Id = @id
go

create procedure [dbo].[CapnhattrangThaiGiaHan](@id int, @trangthai nvarchar(50))
as update GiaHan
set TrangThai = @trangthai
where Id = @id
go

create procedure [dbo].[ThemYeuCauSuaChua](@tenthietbi nvarchar(20), @soluong int, @chitiet nvarchar(500), @trangthai nvarchar(50))
as
insert into SuaChua Values(@tenthietbi, @soluong, @chitiet, @trangthai)
go

create procedure [dbo].[ThemYeuCauTraPhong](@maphong char(10), @masinhvien char(10), @ngaytra date, @trangthai nvarchar(50))
as
insert into TraPhong Values(@maphong, @masinhvien, @ngaytra, @trangthai)
go

create procedure [dbo].[ThemYeuCauGiaHan](@masinhvien char(10), @soky int, @trangthai nvarchar(50))
as
insert into GiaHan Values(@masinhvien, @soky, @trangthai)
go

create procedure [dbo].[proc_DanhSachGiaHan]
as 
select Id, MaSinhVien as [Mã sinh viên], SoKy as[Số kỳ], TrangThai as [Trạng thái]
from GiaHan
GO

create procedure [dbo].[proc_DanhSachTraPhong]
as 
select Id, MaPhong as [Mã phòng], MaSinhVien as [Mã sinh viên], NgayTra as [Ngày trả], TrangThai as [Trạng thái]
from TraPhong
GO

create procedure [dbo].[proc_DanhSachSuaChua]
as 
select Id, TenThietBi as [Tên thiết bị], SoLuong as [Số lượng], ChiTiet as [Chi tiết]
from SuaChua
GO

create procedure [dbo].[proc_XoaYeuCauGiaHan] (@id int)
as delete GiaHan where Id = @id
GO

create procedure [dbo].[proc_XoaYeuCauTraPhong] (@id int)
as delete GiaHan where Id = @id
GO

create procedure [dbo].[proc_XoaYeuCauSuaChua] (@id int)
as delete GiaHan where Id = @id
GO

create procedure [dbo].[proc_TenThietBi]
as
	select distinct TenThietBi from TrangThietBi
GO
CREATE function [dbo].[func_LaySoYeuCauSuaChua]() 
returns int
AS 
BEGIN 
    DECLARE @kq int 
    SELECT @kq = count(Id)  
	from SuaChua
	where TrangThai = 'Chưa xem'
    RETURN  @kq
END
GO

CREATE function [dbo].[func_LaySoYeuCauTraPhong]() 
returns int
AS 
BEGIN 
    DECLARE @kq int 
    SELECT @kq = count(Id)  
	from TraPhong
	where TrangThai = 'Chưa xem'
    RETURN  @kq
END
GO

CREATE function [dbo].[func_LaySoYeuCauGiaHan]() 
returns int
AS 
BEGIN 
    DECLARE @kq int 
    SELECT @kq = count(Id)  
	from GiaHan
	where TrangThai = 'Chưa xem'
    RETURN  @kq
END
GO

CREATE function [dbo].[func_LayTenThietBi]() 
returns table
as
	return select TenThietBi
				from TrangThietBi
go

CREATE function [dbo].[func_LayMaThietBiTheoTen](@TenThietBi nvarchar(20)) 
returns char(10)
as
	BEGIN
		DECLARE @kq char(10) 
		select @kq=MaThietBi
		from TrangThietBi
		where TenThietBi = @TenThietBi
		RETURN  @kq
	END
go
create function [dbo].[func_DanhSachThietBiPhong] (@MaPhong char(10))
returns table
	as
	return 
		select ttb.TenThietBi as [Tên thiết bị], 
		p.SoLuongHong as [Số lượng hỏng], 
		p.SoLuongTot as [Số lượng tốt], 
		p.SoLuongToiDa as [Số lượng tối đa]
		From ThietBiTrongPhong as p, TrangThietBi as ttb
		where p.MaPhong = @MaPhong and p.MaThietBiTrongPhong = ttb.MaThietBi
GO
create function [dbo].[func_TimkiemTBiTheoTen](@tentb nvarchar(50), @MaPhong char(10))
returns table
	as
	return
		select ttb.TenThietBi as [Tên thiết bị], 
		p.SoLuongHong as [Số lượng hỏng], 
		p.SoLuongTot as [Số lượng tốt], 
		p.SoLuongToiDa as [Số lượng tối đa]
		From ThietBiTrongPhong as p, TrangThietBi as ttb
		where p.MaPhong = @MaPhong and p.MaThietBiTrongPhong = ttb.MaThietBi and ttb.TenThietBi = @tentb
GO
create function [dbo].[func_TimkiemTBi](@tentb nvarchar(50))
returns table
	as
	return
		select ttb.MaThietBi as [Mã thiết bị], 
		ttb.TenThietBi as [Tên thiết bị], 
		ttb.TongSoLuong as [Số lượng]
		From TrangThietBi as ttb
		where ttb.TenThietBi = @tentb
GO
create function [dbo].[func_TenTbiTrongPhong](@MaPhong char(10))
returns table
	as
	return
		select ttb.TenThietBi 
		From ThietBiTrongPhong as p, TrangThietBi as ttb
		where p.MaPhong = @MaPhong and p.MaThietBiTrongPhong = ttb.MaThietBi
GO
/*alter TRIGGER [dbo].[tg_ThietBiTrongPhong] 
ON [dbo].[ThietBiTrongPhong]
AFTER INSERT
AS
BEGIN
		SET NOCOUNT ON;
		Declare @sltrangthietbi int,@sltoida int
		select @sltrangthietbi = TrangThietBi.TongSoLuong, @sltoida = inserted.SoLuongToiDa
		from inserted, TrangThietBi
		WHERE inserted.MaThietBiTrongPhong = TrangThietBi.MaThietBi

		UPDATE TrangThietBi SET TongSoLuong = @sltrangthietbi - @sltoida
		FROM inserted, TrangThietBi
		WHERE inserted.MaThietBiTrongPhong = TrangThietBi.MaThietBi
END*/
--GO
create procedure [dbo].[proc_DanhSachTatCaTrangThietBi]
as 
select * from TrangThietBi
GO
create procedure [dbo].[proc_ThemThietBi] (@matb char(10), @tentb nvarchar(20), @tongsl int)
as insert into TrangThietBi values(@matb, @tentb, @tongsl );
GO
create procedure [dbo].[proc_SuaThietBi] (@matb char(10), @tentb nvarchar(50), @tongsl int)
as update TrangThietBi
set MaThietBi = @matb,
	TenThietBi = @tentb,
	TongSoLuong = @tongsl
where MaThietBi = @matb;
GO