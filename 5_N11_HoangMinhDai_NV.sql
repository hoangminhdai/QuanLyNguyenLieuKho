use N11_QLNguyenLieuNhaHang_T5
go

--dữ liệu danh mục
insert into NhaCungCap(TenNCC, DiaChi, SDT) values
	(N'TVP Food', N'TP HCM', '123123123'),
	(N'Công ty Cổ phần Tôn Phan', N'Sài Gòn', '456456789'),
	(N'Thực phẩm Đại Thuận', N'Số 10 Thiền Quang', '9876543'),
	(N'San Hà Food', N'Số 11 Lê Duẩn', '212345267'),
	(N'G.C Food', N'Số 12 Bùi Viện', '3748674937')
go
insert into NhanVien(HoTen, NgaySinh, DiaChi, SDT) values
	(N'Nguyễn Minh Đức', '1/1/1991', N'Hà Nội', '123'), --mm/dd/yyyy
	(N'Mai Quốc Khánh', '2/2/1992', N'Hà Nội', '123'),
	(N'Lê Thị Diễm', '3/3/1993', N'Hà Nội', '123'),
	(N'Hoàng Thị Thảo', '4/4/1994', N'Hà Nội', '123'),
	(N'Mai Văn Trường', '2/15/1995', N'Hà Nội', '123')
go

insert into NguyenLieu(TenNL, LoaiTuoiKho, GiaTien, TenDonVi) values
	(N'Bột ca cao', 0, 10000, N'cân'),
	(N'Bột hạnh nhân', 0, 20000, N'cân'),
	(N'Bột kem sữa', 0, 30000, N'cân'),
	(N'Bột mỳ', 0, 40000, N'cân'),
	(N'Bột trà xanh', 0, 50000, N'cân')
go

--tạo 3 phiếu đặt nguyên liệu
INSERT INTO dbo.PhieuDatNL
        ( MaNCC, MaNV )
VALUES  ( 1, 3 ),
		( 2, 4 ),
		( 3, 5 )
GO

--với mỗi phiếu đặt có 1 chi tiết tương ứng
--mã nguyên liệu từ 16 đến 20 là nguyên liệu khô
INSERT INTO dbo.ChiTietPDNL
        ( MaPDNL, MaNL, SoLuong )
VALUES  ( 1, 1, 2 ),

		( 2, 2, 7 ),

		( 3, 3, 6 )
GO
SELECT *FROM ChiTietPDNL
--tạo 3 hóa đơn nhập liệu tương ứng với 3 phiếu đặt
INSERT INTO dbo.HoaDonNhapNL
        ( MaPDNL, MaNV)
VALUES  ( 1, 1 ),
		( 2, 2 ),
		( 3, 3 )
GO

        
--với mỗi hóa đơn nhập có 1 chi tiết tương ứng
INSERT INTO dbo.ChiTietHDN
        ( MaHD, MaNL, GiaTien, SoLuong )
VALUES  ( 1, 1, 10000, 2 ),
	    ( 1, 2, 10000, 2 ),
		( 1, 3, 10000, 2 ),
		( 1, 4, 10000, 2 ),
		( 1, 5, 10000, 2 ),

		( 2, 1, 30000,10 ),
	    ( 2, 2, 30000,10 ),
		( 2, 3, 30000,10 ),
		( 2, 4, 30000,10 ),
		( 2, 5, 30000,10 ),
			
		( 3, 1, 30000,9 ),
	    ( 3, 2, 30000,9 ),
		( 3, 3, 30000,9 ),
		( 3, 4, 30000,9 ),
		( 3, 5, 30000,9 )
			
GO


--sau khi nhập xong thì có các câu lệnh update tương ứng
--hóa đơn nhập thứ nhất
update NguyenLieu
set SoLuong += 2,GiaTien=10000 where MaNL = 1
update NguyenLieu
set SoLuong += 7 ,GiaTien=15000 where MaNL = 2
update NguyenLieu
set SoLuong += 6,GiaTien=16000 where MaNL = 3

use N11_QLNguyenLieuNhaHang_T5
--Nhập thêm 5 cân bột mì,5 cân bột trà xanh

INSERT INTO dbo.ChiTietHDN ( MaHD, MaNL, GiaTien, SoLuong ) VALUES  ( 4, 19, 10000, 5 )
update NguyenLieu set soluong+=5 where MaNL=19
INSERT INTO dbo.ChiTietHDN ( MaHD, MaNL, GiaTien, SoLuong ) VALUES  ( 4, 20, 50000, 5 )
update NguyenLieu set soluong+=5 where MaNL=20



 -- in ra biểu mẫu nhập nguyên liệu khô
 select NguyenLieu.TenNL,ChiTietPDNL.SoLuong as [số lượng dự kiên], ChiTietHDN.SoLuong as [thực nhập],
 NguyenLieu.TenDonVi as [đơn vị],ChiTietHDN.GiaTien as [giá tiền/đơn vị], ChiTietHDN.GiaTien*ChiTietHDN.SoLuong as [Tổng Tiền]
 from NguyenLieu 
 join ChiTietPDNL on ChiTietPDNL.MaNL = NguyenLieu.MaNL
 join PhieuDatNL on PhieuDatNL.MaPDNL=ChiTietPDNL.MaPDNL
 join HoaDonNhapNL on HoaDonNhapNL.MaPDNL=PhieuDatNL.MaPDNL
 join ChiTietHDN on ChiTietHDN.MaHD=HoaDonNhapNL.MaHDN
 where HoaDonNhapNL.NgayLap='2019-05-06'

 --dua ra ho ten nhan vien co 2 phieu dat nguyen lieu 
select NhanVien.HoTen,count(*) as [số phiếu đặt NL] from PhieuDatNL
join NhanVien on NhanVien.MaNV=PhieuDatNL.MaNV
group by NhanVien.HoTen
having count (*)=2
-- đưa ra giá trung bình của nguyên liệu khô
select avg(GiaTien) from NguyenLieu
where LoaiTuoiKho=1
-- cách 2
select sum(GiaTien)/COUNT(*) from NguyenLieu
where LoaiTuoiKho=1
-- đưa ra họ tên nhân viên có nhiều hóa đơn nhập nhất
select top 1 with ties NhanVien.HoTen, count(HoaDonNhapNL.MaHDN) as soluonghoadon
from NhanVien join HoaDonNhapNL on HoaDonNhapNL.MaNV=NhanVien.MaNV
group by NhanVien.HoTen
order by soluonghoadon desc

-- tạo view biểu mẫu hóa đươn nhập nguyên liệu
create view BieuMau as 
(select NguyenLieu.TenNL,ChiTietPDNL.SoLuong as [số lượng dự kiên], ChiTietHDN.SoLuong as [thực nhập],
 NguyenLieu.TenDonVi as [đơn vị],ChiTietHDN.GiaTien as [giá tiền/đơn vị], ChiTietHDN.GiaTien*ChiTietHDN.SoLuong as [Tổng Tiền]
 from NguyenLieu 
 join ChiTietPDNL on ChiTietPDNL.MaNL = NguyenLieu.MaNL
 join PhieuDatNL on PhieuDatNL.MaPDNL=ChiTietPDNL.MaPDNL
 join HoaDonNhapNL on HoaDonNhapNL.MaPDNL=PhieuDatNL.MaPDNL
 join ChiTietHDN on ChiTietHDN.MaHD=HoaDonNhapNL.MaHDN
 
 )
 drop view BieuMau
 -- tạo view phiếu đặt nguyên liệu
 create view PhieuDat as
 (
	select NguyenLieu.TenNL,ChiTietPDNL.SoLuong,NguyenLieu.TenDonVi,NguyenLieu.GiaTien,PhieuDatNL.NgayLap
	from NguyenLieu 
	join ChiTietPDNL on NguyenLieu.MaNL=ChiTietPDNL.MaNL
	join PhieuDatNL on PhieuDatNL.MaPDNL=ChiTietPDNL.MaPDNL
	where PhieuDatNL.NgayLap ='2019-04-08'and NguyenLieu.LoaiTuoiKho='0'
	
 )
 drop view PhieuDat

-- tạo 2 store procedure


--tạo thủ tục thêm  phieu dat nguyên liệu
create proc pc_ThemNguyenLieu
@TenNL nvarchar(50),
@LoaiTuoiKho bit,
@GiaTien int,
@Soluong float,
@TenDonVi nvarchar(50)
as
begin
	INSERT INTO dbo.NguyenLieu(TenNL,LoaiTuoiKho,GiaTien,SoLuong,TenDonVi )
	VALUES  (@TenNL,@LoaiTuoiKho,@GiaTien,@Soluong,@TenDonVi  )
end
create proc pc_ThemPhieuDatNL
@MaNCC int,
@MaNV int
as
begin
	INSERT INTO dbo.PhieuDatNL( MaNCC, MaNV )
	VALUES  ( @MaNCC, @MaNV )
end

-- tạo thủ tục thêm chi tiết phiếu đặt nl
create proc pc_ThemChiTietPDNL
@MaPDNL int,
@MaNL int,
@SoLuong int
as
begin
	 INSERT INTO dbo.ChiTietPDNL(MaPDNL, MaNL,SoLuong)
	VALUES   (@MaPDNL,@MaNL, @SoLuong )
end
drop proc  pc_ThemChiTietPDNL
-- tạo thủ tục Thêm hóa đơn nhập
create proc pc_ThemHoaDonNhapNL
@MaPDNL int,
@MaNV int
as
begin
	 INSERT INTO dbo.HoaDonNhapNL(MaPDNL,MaNV)
	VALUES   (@MaPDNL,@MaNV )
end
-- thủ tục thêm chi tiết hóa đơn nhập
create proc pc_ThemChiTietHDN
@MaHD int,
@MaNL int,
@GiaTien int,
@SoLuong int
as
begin
	 INSERT INTO dbo.ChiTietHDN(MaHD,MaNL,GiaTien,SoLuong)
	VALUES   (@MaHD,@MaNL,@GiaTien,@SoLuong)
	update NguyenLieu set SoLuong+=@SoLuong,GiaTien=@GiaTien where MaNL=@MaNL
end

drop proc pc_ThemChiTietHDN
--xóa 1 phiếu đặt nguyên liệu
create trigger tr_XoaPhieuDatNL on PhieuDatNL
instead of delete 
as 
begin
	declare @MaPhieuDat int
	select @MaPhieuDat=(select MaPDNL from deleted)
	delete ChiTietPDNL where ChiTietPDNL.MaPDNL= @MaPhieuDat
	delete PhieuDatNL where PhieuDatNL.MaPDNL=@MaPhieuDat 
end
drop trigger tr_XoaPhieuDatNL

-- xóa 1 hóa đơn nhập
create trigger tr_XoaHoaDonNhap on HoaDonNhapNL
instead of delete 
as
begin
	declare @MaHoaDon int
	select @MaHoaDon=(select MaHDN from deleted)
	delete ChiTietHDN where MaHDN=@MaHoaDon
	delete HoaDonNhapNL where MaHDN=@MaHoaDon
end
drop trigger tr_XoaHoaDonNhap



 
 exec pc_ThemNguyenLieu N'lạc',0,40000,6,'kg'
 delete ChiTietPDNL
 delete ChiTietHDN
 select *from PhieuDatNL
 select *from HoaDonNhapNL
 
 exec pc_ThemPhieuDatNL 1,1
 exec pc_ThemChiTietPhieuDatNL 15,1,10
 exec pc_ThemHoaDonNhapNL 
 alter table NhanVien 
 create proc pc_UpdateNguyenLieu
@MaNL int,
@TenNL nvarchar(50),
@LoaiTuoiKho bit,
@GiaTien int,
@Soluong float,
@TenDonVi nvarchar(50)
as
begin
	UPDATE dbo.NguyenLieu 
	SET TenNL=@TenNL,LoaiTuoiKho=@LoaiTuoiKho,GiaTien=@GiaTien,Soluong=@Soluong,TenDonVi=@TenDonVi  
	where MaNL=@MaNL
end
 create proc pc_TaoPDNL
@MaNCC int,
@MaNL int

as
begin
	UPDATE dbo.NguyenLieu 
	SET TenNL=@TenNL,LoaiTuoiKho=@LoaiTuoiKho,GiaTien=@GiaTien,Soluong=@Soluong,TenDonVi=@TenDonVi  
	where MaNL=@MaNL
end
--------------------------------------

CREATE proc sp_BieuMauNhapNLT 
@MaHDN int
as
begin
	declare  @HoTen nvarchar(50)
	declare @NgayLap date
	declare @TenNCC nvarchar(50)
	set @NgayLap = (select NgayLap from dbo.HoaDonNhapNL where MaHDN = @MaHDN)
	set @HoTen = (select HoTen from NhanVien where MaNV = (select MaNV from dbo.HoaDonNhapNL where MaHDN = @MaHDN))
	set @TenNCC=(select TenNCC from NhaCungCap join PhieuDatNL on NhaCungCap.MaNCC=PhieuDatNL.MaNCC join HoaDonNhapNL on HoaDonNhapNL.MaPDNL=PhieuDatNL.MaPDNL where MaHDN=@MaHDN)

	print ''
	print N'                                     HÓA ĐƠN NHẬP NGUYÊN LIỆU KHÔ'
	print ''
	print N'                                       Nhà Cung Cấp:' +@TenNCC
	print ''
	print N'STT | Tên nguyên liệu               | Dự kiến  |Thực nhập | Đơn vị   | Giá tiền trên 1 đơn vị | Tổng tiền'
	print  '---------------------------------------------------------------------------------------------------------'
	declare c cursor local forward_only for
		select NguyenLieu.TenNL,ChiTietPDNL.SoLuong as [so luong du kiên], ChiTietHDN.SoLuong as [thuc nhap],
			NguyenLieu.TenDonVi as [don vi],ChiTietHDN.GiaTien as [giá tien/don vi], ChiTietHDN.GiaTien*ChiTietHDN.SoLuong as [Tong Tien]
			from PhieuDatNL
			join ChiTietPDNL on ChiTietPDNL.MaPDNL=PhieuDatNL.MaPDNL
			join NguyenLieu on NguyenLieu.MaNL=ChiTietPDNL.MaNL
			join ChiTietHDN on ChiTietHDN.MaNL=NguyenLieu.MaNL
			JOIN HoaDonNhapNL on HoaDonNhapNL.MaHDN=ChiTietHDN.MaHD
		where dbo.HoaDonNhapNL.MaHDN = @MaHDN and NguyenLieu.LoaiTuoiKho=0 and HoaDonNhapNL.MaPDNL=PhieuDatNL.MaPDNL

	declare @STT int, @TenNL nvarchar(30), @Dukien float, @Thucnhap FLOAT, @TenDonVi nvarchar(30), @GiaTien INT, @Tongtien int,@TongCong int
	set @STT = 1 
	set @TongCong=0

	open c
	fetch next from c into @TenNL, @Dukien, @Thucnhap, @TenDonVi, @GiaTien, @Tongtien

	while @@FETCH_STATUS = 0
	begin
		print ' ' + cast (@STT as char(3)) + '|  ' + cast (@TenNL as nchar(29)) + '|  ' + cast(@Dukien as char(8)) + '|  ' + cast(@Thucnhap as char(8))  + '|  ' + cast(@TenDonVi as char(8))  + '|  ' + cast(@GiaTien as char(22)) + '|  ' + cast(@Tongtien as char(8))
		set @STT += 1
		set @TongCong= @TongCong+@Tongtien

		fetch next from c into @TenNL, @Dukien, @Thucnhap, @TenDonVi, @GiaTien, @Tongtien
	end

	print ''
	
	print N'                                                                                        Tổng cộng:'+ cast(@TongCong as char(10))+'VND'
	print ''
	print ''
	print N'Ngày lập: ' + cast(@NgayLap as char(50)) + N'Nhân viên ký xác nhận'
	print ''
	print ''
	print ''
	print '                                                                ' +     @HoTen
end
go
 
EXEC sp_BieuMauNhapNLT 1
drop proc sp_BieuMauNhapNLT
select TenNCC from NhaCungCap join PhieuDatNL on NhaCungCap.MaNCC=PhieuDatNL.MaNCC join HoaDonNhapNL on HoaDonNhapNL.MaPDNL=PhieuDatNL.MaPDNL where MaHDN=1
select *from PhieuDatNL where MaPDNL=1
select *from HoaDonNhapNL where MaHDN=1 exec pc_ThemChiTietPDNL 1,1,9
exec pc_ThemChiTietPDNL 31,5,9
exec pc_ThemChiTietPDNL 31,2,9
exec pc_ThemChiTietPDNL 31,3,9
exec pc_ThemChiTietPDNL 31,4,9

exec pc_ThemChiTietHoaDonNhapNL  1,1,30000,9
exec pc_ThemChiTietHoaDonNhapNL  2,1,30000,9
exec pc_ThemChiTietHoaDonNhapNL  3,1,30000,7
exec pc_ThemChiTietHoaDonNhapNL  4,1,30000,8
exec pc_ThemChiTietHoaDonNhapNL  5,1,30000,9
exec pc_ThemChiTietHoaDonNhapNL   10,1,30000,9


delete ChiTietHDN 
delete ChiTietPDNL

select *from NguyenLieu where MaNL=2
update NguyenLieu set TenNL=N'Hạt Tiêu' where MaNL=9
update HoaDonNhapNL set MaPDNL=3 where MaHDN=3
update PhieuDatNL set MaNV=1 where PhieuDatNL.MaPDNL=1
SELECT *FROM ChiTietHDN
SELECT *FROM ChiTietPDNL
select *from HoaDonNhapNL
select *from PhieuDatNL

SELECT        NguyenLieu.TenNL, ChiTietHDN.GiaTien, ChiTietPDNL.SoLuong, ChiTietHDN.SoLuong AS thucnhap, NguyenLieu.TenDonVi
FROM            PhieuDatNL INNER JOIN
                         NhanVien ON PhieuDatNL.MaNV = NhanVien.MaNV INNER JOIN
                         NhaCungCap ON PhieuDatNL.MaNCC = NhaCungCap.MaNCC INNER JOIN
                         HoaDonNhapNL ON PhieuDatNL.MaPDNL = HoaDonNhapNL.MaPDNL AND NhanVien.MaNV = HoaDonNhapNL.MaNV INNER JOIN
                         ChiTietPDNL ON PhieuDatNL.MaPDNL = ChiTietPDNL.MaPDNL INNER JOIN
                         NguyenLieu ON ChiTietPDNL.MaNL = NguyenLieu.MaNL INNER JOIN
                         ChiTietHDN ON HoaDonNhapNL.MaHDN = ChiTietHDN.MaHD AND NguyenLieu.MaNL = ChiTietHDN.MaNL
WHERE       ChiTietHDN.MaHD in (select HoaDonNhapNL.MaHDN from HoaDonNhapNL where HoaDonNhapNL.MaHDN=1)

select *from HoaDonNhapNL

 create proc pc_XoaNguyenLieu
@MaNL int
as
begin
	delete ChiTietPDNL where MaNL=@MaNL
	delete ChiTietHDN where MaNL=@MaNL
	delete ChiTietBBTL where MaNL=@MaNL
	delete ChiTietPTK where MaNL=@MaNL
	delete NguyenLieu where MaNL=@MaNL
end
