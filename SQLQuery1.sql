create database QuanLyQuanMyCay
create table NhanVien(
	MaNV char(10) primary key,
	TenNV nvarchar(30) not null,
	NgaySinh smalldatetime not null,
	SDT int not null,
	DiaChi nvarchar(30),
	ChucVu nvarchar(20) not null,
	GioiTinh nvarchar(3),
	NgayVaoLam smalldatetime not null
)
create table TaiKhoan(
	MaNV char(10) not null,
	TaiKhoan varchar(20) unique,
	MatKhau varchar(30) not null,
	PhanQuyen int not null,
	constraint fk_taikhoan_manv foreign key (MaNV) references NhanVien(MaNV),
	constraint pk_taikhoan primary key(MaNV,taikhoan)
)

create table PhieuLuong(
	MaPL char(10) primary key,
	MaNV char(10) not null,
	SoNgayLam int default 0,
	TamUng money default 0,
	TienPhat money default 0,
	TienThuong money default 0,
	NgayXuatPL smalldatetime not null,
	TongLuong money default 0,
	ThangLuong varchar(20) not null,
	constraint fk_phieuluong_manv foreign key (MaNV) references NhanVien(MaNV) 
)
create table NguyenLieu(
	MaNL char(10) primary key,
	TenNL varchar(30) not null,
	DVT varchar(10) not null,
	MaNCC char(10) not null,
	constraint fk_nguyenlieu_mancc foreign key (MaNCC) references NhaCungCap(MaNCC)
)
create table NhaCungCap(
	MaNCC char(10) primary key,
	TenNCC varchar(30) not null,
	DiaChi varchar(30) not null,
	SDT int not null
)
create table PhieuNhap(
	MaPN char(10) primary key,
	NgayNhap smalldatetime not null,
	MaNV char(10) not null,
	constraint fk_phieunhap_manv foreign key (MaNV) references NhanVien(MaNV)
)
create table ChiTietPhieuNhap(
	MaPN char(10) not null,	
	MaNL char(10) not null,
	SoLuong int default 0,
	ThanhTien money default 0,
	constraint fk_chitietphieunhap_mapn foreign key (MaPN) references PhieuNhap(MaPN),
	constraint fk_chitietphieunhap_manl foreign key (MaNL) references NguyenLieu(MaNL)
)
create table PhieuXuat(
	MaPX char(10) primary key,
	MaNV char(10) not null,
	NgayXuat smalldatetime not null,
	constraint fk_phieuxuat_manv foreign key (MaNV) references NhanVien(MaNV)
)
create table ChiTietPhieuXuat(
	MaPX char(10) not null,
	MaNL char(10) not null,
	SoLuong int,
	constraint fk_chitietphieuxuat_mapx foreign key (MaPX) references PhieuXuat(MaPX),
	constraint fk_chitietphieuxuat_manl foreign key (MaNL) references NguyenLieu(MaNL)
)
create table Mon(
	MaMon char(10) primary key,
	TenMon nvarchar(20) not null unique,
	DonGia smallmoney default 0
)
create table HoaDon(
	MaHD char(10) primary key,
	NgayLapHD smalldatetime not null,
	MaNV char(10) not null,
	constraint fk_hoadon_manv foreign key (MaNV) references NhanVien(MaNV)
)
create table ChiTietHoaDon(
	MaMon char(10) not null,
	SoLuong int not null,
	ThanhTien money not null,
	MaHD char(10) not null,
	constraint fk_chitiethoadon_mamon foreign key (MaMon) references Mon(MaMon),
	constraint fk_chitiethoadon_mahd foreign key (MaHD) references HoaDon(MaHD)
)


insert into NhanVien values ('NV01',N'Nhan Vien',11/26/2000,190000,N'Vinh Long',N'Bep',N'Nam',11/26/2000)
insert into NhanVien values ('NV02',N'Nhan Vien',11/26/2000,190000,N'Vinh Long',N'Bep',N'Nam',11/26/2000)

update NhanVien set SDT = 160000 where MaNV = 'NV01'

select * from NhanVien