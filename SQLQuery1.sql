create database QuanLyQuanMyCay
create table NhanVien(
	MaNV varchar(5) primary key,
	TenNV nvarchar(30) not null,
	NgaySinh smalldatetime not null,
	SDT varchar(11) not null,
	DiaChi nvarchar(30),
	ChucVu nvarchar(20) not null,
	GioiTinh nvarchar(3),
	NgayVaoLam smalldatetime not null
)
alter table NhanVien alter column SDT varchar(11) not null
create table TaiKhoan(
	MaNV varchar(5) not null,
	TaiKhoan varchar(20) unique,
	MatKhau varchar(30) not null,
	PhanQuyen int not null,
	constraint fk_taikhoan_manv foreign key (MaNV) references NhanVien(MaNV),
	constraint pk_taikhoan primary key(MaNV,taikhoan)
)

create table PhieuLuong(
	MaPL varchar(5) primary key,
	MaNV varchar(5) not null,
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
	MaNL varchar(5) primary key,
	TenNL varchar(30) not null,
	DVT varchar(10) not null,
	MaNCC varchar(5) not null,
	constraint fk_nguyenlieu_mancc foreign key (MaNCC) references NhaCungCap(MaNCC)
)
create table NhaCungCap(
	MaNCC varchar(5) primary key,
	TenNCC varchar(30) not null,
	DiaChi varchar(30) not null,
	SDT varchar(10) not null
)
create table PhieuNhap(
	MaPN varchar(5) primary key,
	NgayNhap smalldatetime not null,
	MaNV varchar(5) not null,
	constraint fk_phieunhap_manv foreign key (MaNV) references NhanVien(MaNV)
)
create table ChiTietPhieuNhap(
	MaPN varchar(5) not null,	
	MaNL varchar(5) not null,
	SoLuong int default 0,
	ThanhTien money default 0,
	constraint fk_chitietphieunhap_mapn foreign key (MaPN) references PhieuNhap(MaPN),
	constraint fk_chitietphieunhap_manl foreign key (MaNL) references NguyenLieu(MaNL)
)
create table PhieuXuat(
	MaPX varchar(5) primary key,
	MaNV varchar(5) not null,
	NgayXuat smalldatetime not null,
	constraint fk_phieuxuat_manv foreign key (MaNV) references NhanVien(MaNV)
)
create table ChiTietPhieuXuat(
	MaPX varchar(5) not null,
	MaNL varchar(5) not null,
	SoLuong int,
	constraint fk_chitietphieuxuat_mapx foreign key (MaPX) references PhieuXuat(MaPX),
	constraint fk_chitietphieuxuat_manl foreign key (MaNL) references NguyenLieu(MaNL)
)
create table Mon(
	MaMon varchar(5) primary key,
	TenMon nvarchar(20) not null unique,
	DonGia smallmoney default 0
)
create table HoaDon(
	MaHD varchar(5) primary key,
	NgayLapHD smalldatetime not null,
	MaNV varchar(5) not null,
	constraint fk_hoadon_manv foreign key (MaNV) references NhanVien(MaNV)
)
create table ChiTietHoaDon(
	MaMon varchar(5) not null,
	SoLuong int not null,
	ThanhTien money not null,
	MaHD varchar(5) not null,
	constraint fk_chitiethoadon_mamon foreign key (MaMon) references Mon(MaMon),
	constraint fk_chitiethoadon_mahd foreign key (MaHD) references HoaDon(MaHD)
)

select *from NhanVien


