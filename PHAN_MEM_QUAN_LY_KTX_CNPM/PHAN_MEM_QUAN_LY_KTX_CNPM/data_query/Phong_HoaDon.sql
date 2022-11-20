create database KTX
GO
use KTX
GO

create table TaiKhoan (
	TenTaiKhoan char(15) ,
	MatKhau char(20) NOT NULL,
	VaiTro nvarchar(10) NOT NULL,
	Constraint PK_TaiKhoan Primary Key (TenTaiKhoan)
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
    Constraint PK_SinhVien Primary Key (MaSinhVien)
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
--	SoLuongToiDa int NOT NULL
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

/*create table YeuCau(
	Id int IDENTITY(1,1) PRIMARY KEY,

)*/

ALTER TABLE SinhVien WITH CHECK ADD CONSTRAINT 
FK_SinhVien_Phong 
FOREIGN KEY (MaPhong) REFERENCES Phong(MaPhong)
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE SinhVien CHECK CONSTRAINT FK_SinhVien_Phong
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

/*insert into Phong values ('P101',2000000,5,8,1)
insert into Phong values ('P102',1000000,2,5,0)
insert into Phong values ('P103',2500000,3,8,1)
insert into Phong values ('P104',1000000,4,8,0)
insert into Phong values ('P105',2000000,3,5,0)
insert into Phong values ('P106',3000000,5,8,1)
insert into Phong values ('P107',1500000,7,8,0)


insert into HoaDon values('HD1',200000,100000,'P102','7-11-2021',1)
insert into HoaDon values('HD2',250000,110000,'P102','7-11-2021',0)
insert into HoaDon values('HD3',240000,190000,'P102','7-11-2021',0)
insert into HoaDon values('HD4',230000,160000,'P102','7-11-2021',1)

insert into HoaDon values('HD5',240000,190000,'P103','7-11-2021',0)
create table NoPhi(
	id int identity(1,1) primary key,
	MaPhong char(10) references  Phong(MaPhong),
	MAHD char(10) references HoaDon(MAHD)
)

select * from HoaDon
group by(MaHD)

alter function [dbo].[Thongtinnophi](@maphong char(10))
returns int
as
begin
	declare @check int
	if exists (select * from HoaDon
						where MaPhong=@maphong and
							TrangThai=1)
		set @check=1
	else 
		set @check=0
	return @check
end

SELECT dbo.Thongtinnophi('P103');*/


	

 