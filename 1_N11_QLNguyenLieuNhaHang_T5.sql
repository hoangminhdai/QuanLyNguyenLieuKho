/*===================================================*/
--THỨ TỰ CHẠY CÁC FILE SQL
-- CreateDatabase → DuLieuDanhMuc 
-- → DuLieuNghiepVu_Thanh → DuLieuNghiepVu_Tien
-- → DuLieuNghiepVu_Minh → DuLieuNghiepVu_Dai

/*===================================================*/
--XÓA NẾU ĐÃ TỒN TẠI

use master
go

if exists(select 1 from sys.databases where name='N11_QLNguyenLieuNhaHang_T5')
begin
drop database N11_QLNguyenLieuNhaHang_T5
end
go

/*===================================================*/
--THƯ MỤC

create database N11_QLNguyenLieuNhaHang_T5
on
(
	name = N11_QLNguyenLieuNhaHang_T5,
	filename = 'D:\N11_QLNguyenLieuNhaHang_T5\N11_QLNguyenLieuNhaHang_T5.mdf'
)
log on
(
	name = N11_QLNguyenLieuNhaHang_T5_log,
	filename = 'D:\N11_QLNguyenLieuNhaHang_T5\N11_QLNguyenLieuNhaHang_T5_log.ldf'
)
go

use N11_QLNguyenLieuNhaHang_T5
go

/*===================================================*/
--CẤU TRÚC

--Nhà cung cấp (Mã nhà cung cấp, Tên nhà cung cấp, Địa chỉ, Số điện thoại)
create table NhaCungCap
(
	MaNCC int identity(1, 1) primary key,
	TenNCC nvarchar(50),
	DiaChi nvarchar(50),
	SDT nvarchar(12)
)
go



--Nhân viên (Mã nhân viên, Họ tên, Ngày sinh, Địa chỉ, Số điện thoại)
create table NhanVien
(
	MaNV int identity(1, 1) primary key,
	HoTen nvarchar(50),
	NgaySinh date,
	DiaChi nvarchar(50),
	SDT char(12)
)
go

--Nguyên liệu (Mã nguyên liệu, Tên nguyên liệu, Loại tươi/khô, Số lượng, Tên đơn vị)
create table NguyenLieu
(
	MaNL int identity(1, 1) primary key,
	TenNL nvarchar(30),
	LoaiTuoiKho bit, --1: tươi, 0: khô
	GiaTien int,
	SoLuong float default 0, --bình thường khi mới tạo thì số lượng là 0
	TenDonVi nvarchar(30)
)
go

--Phiếu đặt nguyên liệu (Mã phiếu đặt, Ngày lập, Mã nhà cung cấp, Mã nhân viên)
create table PhieuDatNL
(
	MaPDNL int identity(1, 1) primary key,
	NgayLap date default getdate(),
	MaNCC int foreign key references NhaCungCap(MaNCC),
	MaNV int foreign key references NhanVien(MaNV)
)
go

--Chi tiết phiếu đặt (Mã chi tiết, Mã phiếu, Mã nguyên liệu, Số lượng)
create table ChiTietPDNL
(
	MaPDNL int foreign key references PhieuDatNL(MaPDNL),
	MaNL int foreign key references NguyenLieu(MaNL),
	SoLuong float not null,

	primary key(MaPDNL, MaNL)
)
go

--Hóa đơn nhập nguyên liệu (Mã hóa đơn, Ngày lập, Mã phiếu đặt, Ngày lập, Mã nhân viên)
create table HoaDonNhapNL
(
	MaHDN int identity(1, 1) primary key,
	MaPDNL int foreign key references PhieuDatNL(MaPDNL),
	NgayLap date default getdate(),
	MaNV int foreign key references NhanVien(MaNV),
)
go








--Chi tiết hóa đơn nhập (Mã chi tiết, Mã hóa đơn, Mã khối)
create table ChiTietHDN
(
	MaHD int foreign key references HoaDonNhapNL(MaHDN),
	MaNL int foreign key references NguyenLieu(MaNL),
	GiaTien int not null,
	SoLuong float not null,

	primary key(MaHD, MaNL)
)
go

--Phiếu thống kê nguyên liệu (Mã phiếu thống kê, Ngày lập, Mã nhân viên)
create table PhieuThongKe
(
	MaPTK int identity(1, 1) primary key,
	NgayLap date default getdate(),
	MaNV int foreign key references NhanVien(MaNV)
)
go

--Chi tiết phiếu thống kê (Mã chi tiết, Mã phiếu, Mã khối)
create table ChiTietPTK
(
	MaPTK int foreign key references PhieuThongKe(MaPTK),
	MaNL int foreign key references NguyenLieu(MaNL),
	SoLuong float not null,

	primary key (MaPTK, MaNL)
)
go

--Biên bản thanh lý (Mã biên bản, Ngày lập, Mã nhân viên)
create table BienBanThanhLy
(
	MaBB int identity(1, 1) primary key,
	NgayLap date default getdate(),
	MaNV int foreign key references NhanVien(MaNV)
)
go

--Chi tiết biên bản thanh lý (Mã chi tiết, Mã biên bản, Mã khối, Giá trên một đơn vị, Số lượng)
create table ChiTietBBTL
(
	MaBB int foreign key references BienBanThanhLy(MaBB),
	MaNL int foreign key references NguyenLieu(MaNL),
	Gia int not null,
	SoLuong float not null,

	primary key(MaBB, MaNL)
)
go



/*===================================================*/
--DANH MỤC

/*
Dữ liệu danh mục ở các bảng sau:

	NhaCungCap: lưu thông tin về nhà cung cấp
	NhanVien: lưu thông tin về nhân viên
	NguyenLieu: lưu thông tin về các nguyên liệu

	LƯU Ý khi nhập [Nguyên liệu]: có một trường [Loại tươi/khô] dạng bit, 
		1 tương ứng với tươi, 0 tương ứng với khô
	→ Tiến làm phần nhập nguyên liệu tươi, thì khi nhập vào bảng [Nguyên liệu] nhớ đặt [Loại tươi/khô] là 1
	Tương tự, với Đại.

Dữ liệu nghiệp vụ ở các bảng còn lại.
	
Các bước đối với nghiệp vụ nhập nguyên liệu tươi/khô của Tiến và Đại:
- Tạo [Phiếu đặt nguyên liệu] trước, sau đó tạo các [Chi tiết phiếu đặt] tương ứng.
Lưu ý rằng [Chi tiết phiếu đặt] gồm [Mã nguyên liệu] và [Số lượng]
	việc tách [Phiếu đặt] riêng khỏi [Hóa đơn nhập] là nhằm giải quyết bài toán nguyên liệu bị hao hụt trên đường vận chuyển.
- Tạo [Hóa đơn nhập], chọn [Phiếu đặt nguyên liệu] tương ứng.
- Tạo các [Khối nguyên liệu].
- Tạo các [Chi tiết hóa đơn nhập] tương ứng với [Khối nguyên liệu].

Đối với nghiệp vụ thanh lý của Minh:
- Tạo [Biên bản thanh lý].
- Tạo các [Chi tiết biên bản thanh lý].
- Trừ đi [Số lượng] tương ứng của các [Khối nguyên liệu].
	
Đối với nghiệp vụ thống kê nguyên liệu của Thành:
- Tạo [Phiếu thống kê].
- Tạo các [Chi tiết phiếu thống kê] tương ứng.
*/