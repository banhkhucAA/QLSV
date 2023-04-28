use TestwithC#

create table tblSinhVien(ngaytao datetime default getdate(), nguoitao nvarchar(30) default 'admin', 
ngaycapnhat datetime default getdate(), nguoicapnhat nvarchar(30) default 'admin',
masinhvien char(10) primary key, matkhau varchar(100) default 'matkhau', ho nvarchar(10), tendem nvarchar(10), ten nvarchar(10), 
ngaysinh date, gioitinh nvarchar(5), quequan nvarchar(10), diachi nvarchar(30),dienthoai varchar(30), email nvarchar(30), manganh char(10) references lopchuyennganh(malopchuyennganh))
select*from tblSinhVien

create table tblGiaoVien(ngaytao datetime default getdate(), nguoitao nvarchar(30) default 'admin', 
ngaycapnhat datetime default getdate(), nguoicapnhat nvarchar(30) default 'admin', 
magiaovien char(10) primary key,matkhau varchar(100) default 'matkhau', ho nvarchar(10), tendem nvarchar(20), ten nvarchar(10),
gioitinh nvarchar(10), ngaysinh date, dienthoai char(20), email nvarchar(20), diachi nvarchar(30), chucvu nvarchar(30),mabomon char(10) references bomon_giaovien(mabomon))
select*from tblGiaoVien

create table tblMonHoc(ngaytao datetime default getdate(), nguoitao nvarchar(30) default 'admin', 
ngaycapnhat datetime default getdate(), nguoicapnhat nvarchar(30) default 'admin', 
mamonhoc int IDENTITY(1,1) primary key, tenmonhoc nvarchar(20), sotinchi int, manganh char(10) references chuyennganh(manganh))
select*from tblMonHoc


Alter table tblMonHoc Alter Column tenmonhoc nvarchar(100)
create table tblLopHocPhan(ngaytao datetime default getdate(), nguoitao nvarchar(30) default 'admin', 
ngaycapnhat datetime default getdate(), nguoicapnhat nvarchar(30) default 'admin',
malophoc char(10) primary key, mamonhoc int references tblMonHoc(mamonhoc),
magiaovien char(10) references tblGiaoVien(magiaovien),ca int, thu int, toanha char(10),phong int, lichthi datetime)

select*from tblVien

create table tblVien(makhoa_vien char(10) not null primary key, tenvien nvarchar(30))

select*from tblLopHocPhan
insert into tblLopHocPhan(malophoc,mamonhoc,magiaovien,daketthuc)
values('LHP'+cast(next value for lophocphanSeq as varchar(30)),'1','GV1120',1)
insert into tblLopHocPhan(malophoc,mamonhoc,magiaovien,daketthuc)
values('LHP'+cast(next value for lophocphanSeq as varchar(30)),'2','GV1123',1)
insert into tblLopHocPhan(malophoc,mamonhoc,magiaovien,daketthuc)
values('LHP'+cast(next value for lophocphanSeq as varchar(30)),'3','GV1124',0)
insert into tblLopHocPhan(malophoc,mamonhoc,magiaovien,daketthuc)
values('LHP'+cast(next value for lophocphanSeq as varchar(30)),'1','GV1126',1)
--
insert into tblLopHocPhan(malophoc,mamonhoc,magiaovien,daketthuc)
values('LHP'+cast(next value for lophocphanSeq as varchar(30)),'5','GV1120',1)
insert into tblLopHocPhan(malophoc,mamonhoc,magiaovien,daketthuc)
values('LHP'+cast(next value for lophocphanSeq as varchar(30)),'7','GV1124',1)
insert into tblLopHocPhan(malophoc,mamonhoc,magiaovien,daketthuc)
values('LHP'+cast(next value for lophocphanSeq as varchar(30)),'9','GV1125',0)
insert into tblLopHocPhan(malophoc,mamonhoc,magiaovien,daketthuc)
values('LHP'+cast(next value for lophocphanSeq as varchar(30)),'8','GV1123',1)
insert into tblLopHocPhan(malophoc,mamonhoc,magiaovien,daketthuc)
values('LHP'+cast(next value for lophocphanSeq as varchar(30)),'1','GV1125',1)

select*from tblDiem
create table tblDiem(ngaytao datetime default getdate(), nguoitao nvarchar(30) default 'admin', 
ngaycapnhat datetime default getdate(), nguoicapnhat nvarchar(30) default 'admin',
malophoc char(10) references tblLopHocPhan(malophoc), masinhvien char(10) references tblSinhVien(masinhvien), 
CONSTRAINT Diem_pk PRIMARY KEY (masinhvien,malophoc), Diem10 float default 0, Diem40 float default 0, Diem50 float default 0,Tongket float default 0)

insert into tblDiem(malophoc,masinhvien)
values('LHP11','SV1126')
insert into tblDiem(malophoc,masinhvien)
values('LHP11','SV1129')
insert into tblDiem(malophoc,masinhvien)
values('LHP14','SV1129')
insert into tblDiem(malophoc,masinhvien)
values('LHP13','SV1132')
--
insert into tblDiem(malophoc,masinhvien)
values('LHP15','SV1126')
insert into tblDiem(malophoc,masinhvien)
values('LHP20','SV1129')
insert into tblDiem(malophoc,masinhvien)
values('LHP19','SV1129')
insert into tblDiem(malophoc,masinhvien)
values('LHP18','SV1132')


select*from tblDiem
select*from tblLopHocPhan
alter table tblLopHocPhan drop column daketthuc

create table TaiKhoan(tentaikhoan varchar(30) primary key, matkhau varchar(30))

select*from tblGiaoVien

insert into tblGiaoVien(magiaovien, ho, tendem, ten, gioitinh, ngaysinh, dienthoai, email, diachi)
values('GV'+cast(next value for giaovienSeq as varchar(30)),N'Nguyễn',N'Thị Thu',N'Mai',N'Nữ','1987-01-01','0123456789','thumai@gmail.com',N'Địa chỉ của Mai')
insert into tblGiaoVien(magiaovien, ho, tendem, ten, gioitinh, ngaysinh, dienthoai, email, diachi)
values('GV'+cast(next value for giaovienSeq as varchar(30)),N'Nguyễn',N'Danh',N'An',N'Nam','1987-05-02','0123457689','anmoon@gmail.com',N'Địa chỉ của An')
insert into tblGiaoVien(magiaovien, ho, tendem, ten, gioitinh, ngaysinh, dienthoai, email, diachi)
values('GV'+cast(next value for giaovienSeq as varchar(30)),N'Nguyễn',N'Vũ',N'Hoàng',N'Nam','1988-01-01','0185456789','hdung@gmail.com',N'Địa chỉ của Dung')
insert into tblGiaoVien(magiaovien, ho, tendem, ten, gioitinh, ngaysinh, dienthoai, email, diachi)
values('GV'+cast(next value for giaovienSeq as varchar(30)),N'Nguyễn',N'Thị Mai',N'Trang',N'Nữ','1988-12-24','0123458989','tranglt.com',N'Địa chỉ của Trang')

select*from tblMonHoc

--nếu thêm thứ và ca thì phải sửa
insert into tblMonHoc(tenmonhoc,sotinchi)
values(N'Vật lý đại cương',3)
insert into tblMonHoc(tenmonhoc,sotinchi)
values(N'Tư tưởng HCM',2)
insert into tblMonHoc(tenmonhoc,sotinchi)
values(N'Toán cao cấp',3)
insert into tblMonHoc(tenmonhoc,sotinchi)
values(N'Lịch sử Đảng',2)

select*from tblSinhVien

select*from tblLopHocPhan

create sequence sinhvienSeq
start with 1100 increment by 1

create sequence giaovienSeq
start with 1100 increment by 1

create sequence lophocphanSeq
start with 1 increment by 1

create sequence malophocSeq
start with 1 increment by 1

SELECT*FROM TBLgIAOvIEN

set identity_insert tblSinhVien on
select*from tblSinhVien
select next value for sinhvienSeq
insert into tblSinhVien(masinhvien, ho, tendem, ten, ngaysinh, gioitinh, quequan, diachi, email,manganh)
values('SV'+cast (next value for sinhvienSeq as varchar(30)),N'Nguyễn',N'Danh',N'An','2002-03-29',N'Nam','Hai Phong','Ha Noi','changtraifc1@gmail.com','CNTT62A')
insert into tblSinhVien(masinhvien, ho, tendem, ten, ngaysinh, gioitinh, quequan, diachi, email,manganh)
values('SV'+cast(next value for sinhvienSeq as varchar(30)),N'Nguyễn',N'Dan',N'Anh','2002-03-20',N'Nam','Hai Phong','Ho CHi Minh','changtraifc2@gmail.com','CNTT62B')
insert into tblSinhVien(masinhvien, ho, tendem, ten, ngaysinh, gioitinh, quequan, diachi, email,manganh)
values('SV'+cast(next value for sinhvienSeq as varchar(30)),N'Đặng',N'Như',N'Ngọc','2002-01-31',N'Nữ','Ha Noi','Ha Noi','fuckgirl1@gmail.com','CNTT62A')
insert into tblSinhVien(masinhvien, ho, tendem, ten, ngaysinh, gioitinh, quequan, diachi, email,manganh)
values('SV'+cast(next value for sinhvienSeq as varchar(30)),N'Nguyễn',N'Đào',N'Hải','2002-05-29',N'Nam','Hai Phong','Ha Noi','changtraifc3@gmail.com','CNTT62A')

insert into tblSinhVien(masinhvien, ho, tendem, ten, ngaysinh, gioitinh, quequan, diachi, email,manganh)
values('SV'+cast (next value for sinhvienSeq as varchar(30)),N'Nguyễn',N'Ngọc',N'Như','2002-07-29',N'Nữ',N'Nam Định',N'Hà Nội','changtraifc1@gmail.com','TMDT62A')
insert into tblSinhVien(masinhvien, ho, tendem, ten, ngaysinh, gioitinh, quequan, diachi, email,manganh)
values('SV'+cast(next value for sinhvienSeq as varchar(30)),N'Hoàng',N'Lan',N'Phương','2001-06-17',N'Nữ',N'Hải Phòng',N'Hồ Chí Minh','changtraifc3@gmail.com','TMDT62A')
insert into tblSinhVien(masinhvien, ho, tendem, ten, ngaysinh, gioitinh, quequan, diachi, email,manganh)
values('SV'+cast(next value for sinhvienSeq as varchar(30)),N'Đặng',N'Việt',N'Hùng','2002-01-31',N'Nam','Ha Noi','Ha Noi','fuckgirl_!@@gmail.com','TMDT62B')
insert into tblSinhVien(masinhvien, ho, tendem, ten, ngaysinh, gioitinh, quequan, diachi, email)
values('SV'+cast(next value for sinhvienSeq as varchar(30)),N'Nguyễn',N'Đào',N'Việt','2002-05-29',N'Nam','Hai Phong','Ha Noi','changtraadsadc3@gmail.com','MIS62A')

insert into tblSinhVien(masinhvien, ho, tendem, ten, ngaysinh, gioitinh, quequan, diachi, email,manganh)
values('SV'+cast (next value for sinhvienSeq as varchar(30)),N'Nguyễn',N'Hoàng',N'Như','2002-07-29',N'Nữ',N'Nam Định',N'Hà Nội','changtraifc1@gmail.com','CS62A')
insert into tblSinhVien(masinhvien, ho, tendem, ten, ngaysinh, gioitinh, quequan, diachi, email,manganh)
values('SV'+cast(next value for sinhvienSeq as varchar(30)),N'Hoàng',N'Thị',N'Phương','2001-06-17',N'Nữ',N'Hải Phòng',N'Hồ Chí Minh','changtraifc3@gmail.com','TMDT62A')
insert into tblSinhVien(masinhvien, ho, tendem, ten, ngaysinh, gioitinh, quequan, diachi, email,manganh)
values('SV'+cast(next value for sinhvienSeq as varchar(30)),N'Đặng',N'Văn',N'Hùng','2002-01-31',N'Nam','Ha Noi','Ha Noi','fuckgirl_!@@gmail.com','CS62B')
insert into tblSinhVien(masinhvien, ho, tendem, ten, ngaysinh, gioitinh, quequan, diachi, email,manganh)
values('SV'+cast(next value for sinhvienSeq as varchar(30)),N'Nguyễn',N'Báo',N'Việt','2002-05-29',N'Nam','Hai Phong','Ha Noi','changtraadsadc3@gmail.com','MIS62A')

select*from tblGiaoVien where magiaovien = N'Nguyễn';

--SINH VIÊN--
--proc chọn tất cả các sinh viên
alter procedure SelectAllSinhVien
as
	select masinhvien,
	case
		when LEN(tendem)>0 then concat(ho,' ',tendem,' ',ten)
		else concat (ho,' ',ten)
	end as hoten,
	convert(varchar(10), ngaysinh, 103) as ngaysinh,
	case 
		when gioitinh = N'Nam' then N'Nam'
		else N'Nữ'
	end as gt,
	quequan,
	matkhau,
	diachi,
	email,
	dienthoai
	from tblSInhVien
go;
exec SelectAllSinhVien

--proc tìm kiếm sinh viên dựa theo từ khóa, có thể là mã sinh viên, họ tên, điện thoại,...
alter procedure SelectSinhVien @tukhoa nvarchar(50)
as
	select masinhvien,
	case
		when LEN(tendem)>0 then concat(ho,' ',tendem,' ',ten)
		else concat (ho,' ',ten)
	end as hoten,
	convert(varchar(10), ngaysinh, 103) as ngaysinh,
	case 
		when gioitinh = N'Nam' then N'Nam'
		else N'Nữ'
	end as gt,
	quequan,
	matkhau,
	diachi,
	email,
	dienthoai,
	manganh
	from tblSInhVien
	where 
		lower(ho) like '%'+lower(trim(@tukhoa))+'%'
		or lower(tendem) like '%'+lower(trim(@tukhoa))+'%'
		or lower(ten) like '%'+lower(trim(@tukhoa))+'%'
		or lower(masinhvien) like '%'+lower(trim(@tukhoa))+'%'
		or lower(concat(ho,' ',tendem,' ',ten)) like '%'+lower(@tukhoa)+'%'
		or lower(concat(ho,' ',ten)) like '%'+lower(@tukhoa)+'%'
		or lower(gioitinh) like '%'+lower(trim(@tukhoa))+'%'
		or lower(quequan) like '%'+lower(trim(@tukhoa))+'%'
		or lower(matkhau) like '%'+lower(trim(@tukhoa))+'%'
		or lower(diachi) like '%'+lower(trim(@tukhoa))+'%'
		or lower(email) like '%'+lower(trim(@tukhoa))+'%'
		or lower(dienthoai) like '%'+lower(trim(@tukhoa))+'%'
		or lower(manganh) like '%'+lower(trim(@tukhoa))
		order by ten

exec SelectSinhVien N'Hải'

select*from tblSinhVien
exec sp_help tblSinhVien

-------sửa/////////////////////////////////////////////
alter procedure ThemSV @matkhau nvarchar(100),@Ho nvarchar(20), @TenDem nvarchar(20), @Ten nvarchar(20), @Ngaysinh date, @Gioitinh nvarchar(10),
@QueQuan nvarchar(20), @Diachi nvarchar(60), @DienThoai varchar(30),@Email nvarchar(60),@malopchuyennganh char(10)
as
begin
if not exists (select malopchuyennganh from LopChuyenNganh where malopchuyennganh = @malopchuyennganh) print N'Không tồn tại lớp chuyên ngành này, không thể thêm sinh viên'
else
insert into tblSinhVien(masinhvien,matkhau,ho,tendem,ten,ngaysinh,gioitinh,quequan,diachi,dienthoai,email,manganh)
values('SV'+cast(next value for sinhvienSeq as varchar(30)),
@matkhau,@Ho,@TenDem,@Ten,@Ngaysinh,@Gioitinh,@QueQuan,@Diachi,@DienThoai,@Email,@malopchuyennganh)
end
go

select*from LopChuyenNganh

exec ThemSV 'matkhau',N'Nguyễn',N'Như',N'Ngọc','2002-10-16',N'Nam',N'Bình Định',N'Hà Nội','0972715602','bdinhboy@gmail.com','SV'
exec sp_help tblSinhVien
exec sp_help tblGiaoVien
select*from tblSInhVien

alter procedure updateSV @msv char(10),@nguoicapnhat nvarchar(60), @matkhau nvarchar(100), @Ho nvarchar(20), @TenDem nvarchar(20), @Ten nvarchar(20), @Ngaysinh date, @Gioitinh nvarchar(10),
@QueQuan nvarchar(20), @Diachi nvarchar(60), @DienThoai varchar(30),@Email nvarchar(60)
as
begin
update tblSinhVien 
set ho = @Ho, tendem = @TenDem, ten = @ten, ngaysinh = @Ngaysinh, gioitinh = @Gioitinh,
quequan = @QueQuan, diachi = @Diachi, email = @Email, dienthoai = @DienThoai,matkhau = @matkhau,
ngaycapnhat = getdate(), nguoicapnhat = @nguoicapnhat
where masinhvien = @msv;
end
go

select*from tblSinhVien
exec updateSV 'SV1128','password',N'Nguyễn',N'Ngu',N'Học','2001-12-12',N'Nữ',N'Hải Dương',N'Hà Nội','0961673206','nguvcl@gmail.com'


alter procedure deleteSV @msv char(10)
as
begin
delete from tblLopHocPhan where masinhvien = @msv
delete from tblDiem where masinhvien = @msv
delete from tblSinhVien 
where masinhvien = @msv;
if(@@ROWCOUNT>0) return 1 else return 0;
end
go

select*from tblSinhVien
exec deleteSV 'SV1109'

select*from tblSInhVien
--procedure chon 1 sv
create procedure selectSV
@msv char(10)
as
begin
select*from tblSinhVien
where masinhvien = @msv;
end
go

exec selectSV 'SV1126'


--GIÁO VIÊN
--proc chọn tất cả các GIÁO VIÊN
select*from tblGiaoVien
alter procedure SelectAllGiaoVien
as
	select magiaovien,
	case
		when LEN(tendem)>0 then concat(ho,' ',tendem,' ',ten)
		else concat (ho,' ',ten)
	end as hoten,
	convert(varchar(10), ngaysinh, 103) as ngaysinh,
	case 
		when gioitinh = N'Nam' then N'Nam'
		else N'Nữ'
	end as gt,
	matkhau,
	dienthoai,
	diachi,
	email
	from tblGiaoVien
go;
exec SelectAllGiaoVien
select*from tblGiaoVien

--proc tìm kiếm giáo viên dựa theo từ khóa, có thể là mã sinh viên, họ tên, điện thoại,...
alter procedure SelectGiaoVien @tukhoa nvarchar(50)
as
	select magiaovien,
	case
		when LEN(tendem)>0 then concat(ho,' ',tendem,' ',ten)
		else concat (ho,' ',ten)
	end as hoten,
	convert(varchar(10), ngaysinh, 103) as ngaysinh,
	case 
		when gioitinh = N'Nam' then N'Nam'
		else N'Nữ'
	end as gt,
	matkhau,
	dienthoai,
	diachi,
	email,
	chucvu,
	mabomon
	from tblGiaoVien
	where 
		lower(ho) like '%'+lower(trim(@tukhoa))+'%'
		or lower(tendem) like '%'+lower(trim(@tukhoa))+'%'
		or lower(ten) like '%'+lower(trim(@tukhoa))+'%'
		or lower(magiaovien) like '%'+lower(trim(@tukhoa))+'%'
		or lower(concat(ho,' ',tendem,' ',ten)) like '%'+lower(@tukhoa)+'%'
		or lower(concat(ho,' ',ten)) like '%'+lower(@tukhoa)+'%'
		or lower(gioitinh) like '%'+lower(trim(@tukhoa))+'%'
		or lower(matkhau) like '%'+lower(trim(@tukhoa))+'%'
		or lower(dienthoai) like '%'+lower(trim(@tukhoa))+'%'
		or lower(diachi) like '%'+lower(trim(@tukhoa))+'%'
		or lower(email) like '%'+lower(trim(@tukhoa))+'%'
		or lower(chucvu) like '%'+lower(trim(@tukhoa))+'%'
		or lower(mabomon) like '%'+lower(trim(@tukhoa))+'%'
		order by ten

exec SelectGiaoVien N''

select*from tblGiaoVien
exec sp_help tblGiaoVien

--proc themgv

alter procedure ThemGV @matkhau varchar(100), @Ho nvarchar(20), @TenDem nvarchar(20), @Ten nvarchar(20), @Gioitinh nvarchar(10),@Ngaysinh date,
@DienThoai char(20), @Email nvarchar(60),@Diachi nvarchar(60), @chucvu nvarchar(60), @mabomon char(10)
as
begin
if (select count(chucvu) from tblGiaoVien where chucvu = N'Trưởng bộ môn' and mabomon = @mabomon and chucvu = @chucvu)>=1 
print N'Một bộ môn thuộc 1 khoa/viện chỉ có thể có 1 Trưởng bộ môn'
else insert into tblGiaoVien(magiaovien,matkhau,ho,tendem,ten,gioitinh,ngaysinh,dienthoai,email,diachi,chucvu,mabomon)
values('GV'+cast(next value for giaovienSeq as varchar(30)),@matkhau,
@Ho,@TenDem,@Ten,@Gioitinh,@Ngaysinh,@DienThoai,@Email,@Diachi,@chucvu,@mabomon)
end
go

select count(chucvu) from tblGiaoVien where chucvu = N'Trưởng bộ môn' and manganh = 'CS'

exec ThemGV 'matkhau',N'Vũ',N'Hoài',N'Thương Như',N'Nữ','2002-05-07','0971282602','bdinhgirl@gmail.com',N'Bình Định',N'Giáo viên','CNTT'
exec sp_help tblGiaoVien

delete from tblGiaoVien where magiaovien = 'GV1135'
select*from tblGiaoVien

--proc updategv
alter procedure updateGV @mgv char(10),@nguoicapnhat nvarchar(60),@matkhau nvarchar(100),@Ho nvarchar(20), @TenDem nvarchar(20), @Ten nvarchar(20), @Gioitinh nvarchar(10),@Ngaysinh date,
@DienThoai char(20), @Email nvarchar(60),@Diachi nvarchar(60), @chucvu nvarchar(60), @mabomon char(10)
as
begin
if (select count(chucvu) from tblGiaoVien where chucvu = N'Trưởng bộ môn' and mabomon = @mabomon and chucvu = @chucvu)>=1 
print N'Một ngành chỉ có thể có 1 Trưởng bộ môn'
else
update tblGiaoVien 
set ho = @Ho, tendem = @TenDem, ten = @ten, ngaysinh = @Ngaysinh, gioitinh = @Gioitinh,
dienthoai = @DienThoai, diachi = @Diachi, email = @Email, matkhau = @matkhau,
ngaycapnhat = getdate(), nguoicapnhat = @nguoicapnhat, chucvu = @chucvu, mabomon = @mabomon
where magiaovien = @mgv;
end
go

select*from tblGiaoVien
exec updateGV 'GV1118',N'Nguyễn',N'Như',N'Ngọc',N'Nữ','2002-10-16','0972715602','bdinhboy@gmail.com',N'Bình Định'

select* from tblGiaoVien


--procedure chon 1 gv
create procedure selectGV
@mgv char(10)
as
begin
select*from tblGiaoVien
where magiaovien = @mgv;
end
go

exec selectGV 'GV1120'

select*from tblDiem
create procedure deleteGV @mgv char(10)
as
begin
delete from tblDiem where malophoc in(select malophoc from tblLopHocPhan where magiaovien = @mgv)
delete from tblLopHocPhan where magiaovien = @mgv
delete from tblGiaoVien
where magiaovien = @mgv;
if(@@ROWCOUNT>0) return 1 else return 0;
end
go

--MÔN HỌC
--proc chọn tất cả các môn học
select*from tblMonHoc
create procedure SelectAllMonHoc
as
	select mamonhoc,
	tenmonhoc,
	sotinchi
	from tblMonHoc
go;
exec SelectAllMonHoc
select*from tblMonHoc

--proc tìm kiếm môn học dựa theo từ khóa, có thể là mã sinh viên, họ tên, điện thoại,...
--nếu thêm thứ và ca thì phải sửa

delete from tblMonHoc where mamonhoc = '16'

alter procedure SelectMonHoc @tukhoa nvarchar(50)
as
	select mamonhoc,
	tenmonhoc,
	sotinchi,
	manganh
	from tblMonHoc
	where 
		lower(tenmonhoc) like '%'+lower(trim(@tukhoa))+'%'
		or lower(sotinchi) like '%'+lower(trim(@tukhoa))+'%'
		or lower(mamonhoc) like '%'+lower(trim(@tukhoa))+'%' 
		or lower(manganh) like '%'+lower(trim(@tukhoa))+'%'
		order by tenmonhoc

exec SelectMonHoc ' '

select*from tblmonhoc
exec sp_help tblmonhoc

--proc themmh
--nếu thêm thứ và ca thì phải sửa

alter procedure ThemMH @tenmh nvarchar(40), @sotinchi int, @manganh char(10)
as
begin
if exists(select * from tblMonHoc where tenmonhoc = @tenmh)
print N'Môn học này đã có trong danh sách, không thể thêm'
else
insert into tblMonhoc(tenmonhoc,sotinchi,manganh)
values (@tenmh, @sotinchi,@manganh)
if @@ROWCOUNT > 0 begin return 1 end
else begin return 0 end
end
go

exec ThemMH N'Nhập môn công nghệ thông tin','3','CNTT'
exec sp_help tblMonHoc
select*from tblMonHoc
--proc updatemh
--nếu thêm thứ và ca thì phải sửa

alter procedure updateMH @mmh int,@tenmh nvarchar(40),@sotinchi int, @manganh char(10)
as
begin
if exists(select * from tblMonHoc where tenmonhoc = @tenmh)
print N'Môn học này đã có trong danh sách, không thể cập nhật lại tên'
else
update tblMonHoc 
set tenmonhoc = @tenmh, sotinchi = @sotinchi,
ngaycapnhat = getdate(), manganh = @manganh
where mamonhoc = @mmh;
if @@ROWCOUNT > 0 begin return 1 end
else begin return 0 end
end
go

select*from tblMonHoc
exec updateMH '1',N'Thiết kế web','3'

--procedure chon 1 monhoc
--nếu thêm thứ và ca thì phải sửa

alter procedure selectMH
@mmh int
as
begin
select tenmonhoc, sotinchi, manganh from tblMonHoc
where mamonhoc = @mmh;
end
go

exec selectMH '1'

select*from tblDiem


--LOP HOC
select*from tblLopHocPhan
select*from tblPhong

---------------------sửa
alter procedure allLopHoc @tukhoa nvarchar(50)
as
begin
	select
	malophoc,
	tenmonhoc,sotinchi,ca,thu,concat(toanha,'-',phong) as phong,concat(lichthi,'- ca',ca,N'- thứ',thu) as lichthi
	from tblLopHocPhan,tblMonHoc
	where tblLopHocPhan.mamonhoc = tblMonHoc.mamonhoc
	and (lower(tenmonhoc) like '%'+lower(@tukhoa)+'%' or
	lower(malophoc) like '%'+lower(@tukhoa)+'%' or
	lower(phong) like '%'+lower(@tukhoa)+'%' or
	lower(lichthi) like '%'+lower(@tukhoa)+'%' or
	lower(ca) like '%'+lower(@tukhoa)+'%' or
	lower(thu) like '%'+lower(@tukhoa)+'%' or
	lower(toanha) like '%'+lower(@tukhoa)+'%')
end
go

exec allLopHoc ''
delete from tblLopHocPhan where malophoc = 'LHP42'
select*from tblMonHoc
select*from tblLopHocPhan
exec sp_help tblLopHocPhan

---------------------------------------sửa
select*from tblLopHocPhan
alter table tblLopHocPhan add namhoc int

alter procedure insertLopHoc
@mamonhoc int,
@Thu int, @Ca int, @toanha char(2),@phong char(20)
as
begin
	if (@Thu > 7 or @Thu <2 or @Ca <1 or @Ca > 8) print N'Không thể thêm thứ hoặc ca học sai quy định'
	else if not exists(select mamonhoc from tblMonHoc where mamonhoc = @mamonhoc) print N'Môn học không tồn tại, không thể thêm'
	else if exists(select distinct toanha from tblLopHocPhan where toanha = @toanha and phong = @phong and ca = @ca and thu = @thu) print N'Phòng học không thể bị trùng trong cùng ngày và ca học'
	else
	insert into tblLopHocPhan(malophoc,mamonhoc,ca,thu,toanha,phong,lichthi)
	values('LHP'+cast (next value for lophocphanSeq as varchar(30)),@mamonhoc,@Ca,@Thu,@toanha,@phong,dateadd(day,100,getDate()))
	if @@ROWCOUNT > 0 begin return 1 end
	else begin return 0 end
end

exec insertLopHoc 13,'GV1125',3,4,'A2',611
select*from tblLopHocPhan

delete from tblLopHocPhan where phong = ' A 2- 611'
exec sp_help tblLopHocPhan
--proc updatelophoc
-----------------------------------sửa
select*from tblLopHocPhan

alter procedure updateLopHoc
@malophoc char(10),
@mamonhoc int,
@Thu int, @Ca int, @toanha char(2),@phong char(20), @lichthi date
as
begin
	if (@Thu > 7 or @Thu <2 or @Ca <1 or @Ca > 8) print N'Thứ hoặc ca học sai quy định'
	else if not exists(select malophoc from tblLopHocPhan where malophoc = @malophoc) print N'Lớp học không tồn tại, không thể sửa'
	else if not exists(select mamonhoc from tblMonHoc where mamonhoc = @mamonhoc) print N'Môn học không tồn tại, không thể sửa'
	else if exists(select distinct phong from tblLopHocPhan where toanha = @toanha and phong = @phong and ca = @ca and thu = @thu) print N'Phòng học không thể bị trùng trong cùng ngày và ca học'
	else if exists(select distinct lichthi from tblLopHocPhan where toanha = @toanha and phong = @phong and ca = @ca and thu = @thu) print N'Phòng học không thể bị trùng trong cùng ngày và ca thi'
	else
	update tblLopHocPhan
	set
	mamonhoc = @mamonhoc,
	ngaycapnhat = getdate(),
	thu = @Thu, ca = @ca, toanha = @toanha, phong = @phong, lichthi = @lichthi
	where malophoc = @malophoc
	if @@ROWCOUNT > 0 begin return 1 end
	else begin return 0 end;
end


select*from tblLophocPhan
-------------

------------sửa-----------
alter procedure selectLopHoc @malophoc char(10)
as
begin
	select * from tblLopHocPhan where malophoc = @malophoc 
end

exec selectLopHoc 'LHP11'

select*from taikhoan
insert into TaiKhoan values('qldt','qldt')

--QUẢN LÝ ĐĂNG NHẬP
alter procedure dangnhap @loaitaikhoan varchar(10), @taikhoan varchar(50), @matkhau varchar(50)
as
begin
	if @loaitaikhoan = N'qldt' 
		select*from taikhoan 
		where tentaikhoan = @taikhoan and matkhau = @matkhau
	else if @loaitaikhoan = N'admin' 
		select*from taikhoan 
		where tentaikhoan = @taikhoan and matkhau = @matkhau
	else if @loaitaikhoan = N'gv' 
		select*from tblGiaoVien
		where magiaovien=@taikhoan and matkhau = @matkhau
	else 
		select*from tblSinhVien
		where masinhvien = @taikhoan and matkhau = @matkhau
end

exec dangnhap 'sv','SV1126','matkhau'
select*from tblsinhvien
select*from taikhoan
insert into taikhoan values('admin','admin')

--select*from tblDiem
--Xét các học phần các sinh viên đã đăng ký

select*from tblLopHocPhan
select*from tblDiem
select*from tblGiaoVien
select*from tblMonHoc

select*from tblSinhVien where masinhvien = 'SV1126';

//**********************************************
************************************************/
select*from tblDiem
select*from tblLopHocPhan
select*from kyhoc
----------------------------- sửa----------------------------------------

alter procedure mondadangky @masinhvien char(10), @tukhoa nvarchar(60)
as
begin
	select tblLopHocPhan.malophoc, tenmonhoc, sotinchi,masinhvien,
	case when len(trim(tendem)) > 0 then concat(ho,' ',tendem,' ',' ',ten)
	else concat(ho,' ',ten) end as hotengvien,
	ca,thu
	from tblMonHoc, tblLopHocPhan, tblGiaoVien, tblDiem
	where tblLopHocPhan.malophoc = tblDiem.malophoc and tblLopHocPhan.magiaovien = tblGiaoVien.magiaovien and  tblMonHoc.mamonhoc = tblLopHocPhan.mamonhoc
	and masinhvien = @masinhvien and
	(lower(tblLopHocPhan.malophoc) like '%'+lower(@tukhoa)+'%' or
	lower(tenmonhoc) like '%'+lower(@tukhoa)+'%' or
	lower(sotinchi) like '%'+lower(@tukhoa)+'%' or
	lower(ho) like '%'+lower(@tukhoa)+'%' or
	lower(tendem) like '%'+lower(@tukhoa)+'%' or
	lower(ten) like '%'+lower(@tukhoa)+'%' or
	ca like '%'+lower(@tukhoa)+'%' or
	thu like '%'+lower(@tukhoa)+'%' or
	lower(concat(ho,' ',tendem,' ',ten)) like '%'+lower(@tukhoa)+'%')
end


exec sp_help tblSinhVien
select*from tblGiaoVien
select*from tblLopHocPhan
select*from tblDiem
select*from tblMonHoc

exec mondadangky 'SV1202','KH7',''

--select*from tblGiaoVien

select*from tblLopHocPhan
select*from tblDiem
-----------------------
------------------------
-------------------------------

--test dữ liệu
select*from tblLopHocPhan
select*from tblDiem
select*from tblSinhVien
select*from tblMonHoc

--proc dslopchuadangky
select*from chuyennganh
select*from lopchuyennganh

where mamonhoc in (select

alter proc dsLopChuaDky
----------------------sửa
@masinhvien char(10)
as
begin
select
malophoc,tblLopHocPhan.mamonhoc,tenmonhoc,sotinchi,
case when len(tendem) > 0 then concat(ho,' ',tendem,' ',ten)
else concat (ho,' ',ten) end as gvien,ca,thu
from tblLopHocPhan,tblMonHoc,tblGiaoVien
where tblMonHoc.mamonhoc = tblLopHocPhan.mamonhoc and tblLopHocPhan.magiaovien = tblGiaoVien.magiaovien
and malophoc not in (select malophoc from tblDiem where masinhvien = @masinhvien) 
and tblLopHocPhan.mamonhoc in (select mamonhoc from tblMonHoc where manganh in 
(select manganh from chuyennganh where manganh in 
(select manganh from lopchuyennganh where malopchuyennganh in 
(select manganh from tblSinhVien where masinhvien = @masinhvien))));
end

select*from tblSinhVien where masinhvien = 'SV1143'
select*from LopChuyenNganh
select*from chuyennganh
select*from tblMonHoc where mamonhoc = '32' or mamonhoc = '33'
select*from tblLopHocPhan 
exec dsLopChuaDky'SV1143'
select*from tblMonHoc
select magiaovien from tblLopHocPhan where malophoc = 'LHP102' or malophoc = 'LHP103'
select*from tblDiem
select*from tblSinhVien

-----------------------------------------------------------------------------------------------------------------------------------------------------------
select*from bomon_giaovien, tblVien, chuyennganh, lopchuyennganh where bomon_giaovien.makhoa_vien = tblVien.makhoa_vien and ChuyenNganh.makhoa_vien = tblVien.makhoa_vien and chuyennganh.manganh = LopChuyenNganh.manganh and mabomon = 'CNTT'
------------------------------------------------------------------------------------------------------------------------------------------------------------

----------------------chạy lại---------------------------------------------------AAAAAAAAAAAA
select*from tblDiem
select*from tblLopHocPhan

alter procedure tracuudiem @masinhvien char(10), @tukhoa nvarchar(30)
as
begin
select tblLopHocPhan.mamonhoc,tblDiem.malophoc,tenmonhoc,diem10,diem40,diem50,tongket
from tblLopHocPhan,tblMonHoc,tblDiem
where masinhvien = @masinhvien and tblDiem.malophoc = tblLopHocPhan.malophoc and tblMonHoc.mamonhoc = tblLopHocPhan.mamonhoc
and (lower(tblDiem.malophoc) like '%'+lower(@tukhoa)+'%' or
	tblLopHocPhan.mamonhoc like '%'+lower(@tukhoa)+'%'or
	lower(tblLopHocPhan.mamonhoc) like '%'+lower(@tukhoa)+'%' or
	lower(tenmonhoc) like '%'+lower(@tukhoa)+'%' or
	lower(diem10) like '%'+lower(@tukhoa)+'%' or
	lower(diem40) like '%'+lower(@tukhoa)+'%' or
	lower(diem50) like '%'+lower(@tukhoa)+'%' or
	lower(Tongket) like '%'+lower(@tukhoa)+'%')
end

exec tracuudiem 'SV1202',' '

select*from tblgiaovien
select*from tbllophocphan
select*from tblDiem
select*from tblMonHoc

alter procedure danhsachlop @magiaovien char(10), @tukhoa nvarchar(30)
as
begin
select tblLopHocPhan.mamonhoc,malophoc,tenmonhoc,ca,thu
from tblLopHocPhan,tblMonHoc
where tblMonHoc.mamonhoc = tblLopHocPhan.mamonhoc and magiaovien = @magiaovien
and
	(lower(tblLopHocPhan.mamonhoc) like '%'+lower(@tukhoa)+'%'or
	lower(tenmonhoc) like '%'+lower(@tukhoa)+'%')
group by tblLopHocPhan.mamonhoc,malophoc,tenmonhoc,ca,thu
end

exec danhsachlop 'GV1120',''

select*from tblgiaovien
select*from tbllophocphan
select*from tblDiem
select*from tblMonHoc
select*from tblSinhVien
	
alter procedure dssv1lophp @malophoc char(10), @tukhoa nvarchar(30)
as
begin
select malophoc,
case when len(tendem) > 0 then concat(ho,' ',tendem,' ',ten)
else concat (ho,' ',ten) end as hotensinhvien,
ngaysinh,gioitinh,quequan,diachi,dienthoai,email
from tblDiem,tblSinhVien
where tblDiem.masinhvien = tblSinhVien.masinhvien and malophoc = @malophoc
and (lower(malophoc) like '%'+lower(trim(@tukhoa))+'%' or
	ngaysinh like N'%'+lower(trim(@tukhoa))+N'%'or
	lower(ho) like '%'+lower(trim(@tukhoa))+'%'or 
	lower(tendem) like '%'+lower(trim(@tukhoa))+'%'or 
	lower(ten) like '%'+lower(trim(@tukhoa))+'%' or
	lower(gioitinh) like N'%'+lower(trim(@tukhoa))+N'%' or
	lower(quequan) like N'%'+lower(trim(@tukhoa))+N'%' or
	lower(diachi) like N'%'+lower(trim(@tukhoa))+N'%' or
	lower(dienthoai) like N'%'+lower(trim(@tukhoa))+N'%' or
	lower(email) like N'%'+lower(trim(@tukhoa))+N'%')
group by malophoc,ho,tendem,ten,ngaysinh,gioitinh,quequan,diachi,dienthoai,email
end

exec dssv1lophp 'LHP11',''
select*from taikhoan

alter procedure doimatkhau @loaitaikhoan char(10),@taikhoan char(10),@matkhaumoi char(30)
as
begin
if(@loaitaikhoan = N'admin') update taikhoan set matkhau = @matkhaumoi where tentaikhoan = @taikhoan
else if(@loaitaikhoan = N'gv') update tblGiaoVien set matkhau = @matkhaumoi where magiaovien = @taikhoan
else update tblSinhVien set matkhau = @matkhaumoi where masinhvien = @taikhoan
end

select*from tblDiem
select*from tblLopHocPhan
select*from tblMonHoc
select*from tblGiaoVien

----nghiệp vụ điểm
alter procedure selectDiem @mlh char(10), @tukhoa nvarchar(30)
as
begin
select tblDiem.masinhvien,
case when len(tendem) > 0 then concat(ho,' ',tendem,' ',ten)
else concat (ho,' ',ten) end as hotensinhvien,
tblLopHocPhan.malophoc,tblMonHoc.mamonhoc,tenmonhoc,diem10,diem40,diem50,tongket
from tblDiem,tblMonHoc,tblLopHocPhan,tblSinhVien
where tblLopHocPhan.malophoc = @mlh
and tblLopHocPhan.malophoc = tblDiem.malophoc and tblMonHoc.mamonhoc = tblLopHocPhan.mamonhoc and tblDiem.masinhvien = tblSinhVien.masinhvien
end

exec selectDiem 'LHP11',' '
select*from tblDiem
select*from tblMonHoc
select*from tblLopHocPhan
select*from tblsinhvien

alter procedure DiemTbhe10 @msv char(10)
as
begin
select masinhvien, sum(tongket)/(select count(*)from tblDiem where masinhvien = @msv) as diemtbhe10
from tblDiem
where masinhvien = @msv
group by masinhvien
end

exec DiemTbhe10 'SV1126'

alter procedure Tongtinchi @msv char(10)
as
begin
select masinhvien, sum(sotinchi) as tongsotinchi
from tblLopHocPhan, tblMonHoc, tblDiem
where tblLopHocPhan.malophoc = tblDiem.malophoc and tblLopHocPhan.mamonhoc = tblMonHoc.mamonhoc and masinhvien = @msv
group by masinhvien
end

exec Tongtinchi 'SV1126'

alter procedure updateDiem @msv char(10),@nguoicapnhat char(10),@mlh char(10),@diem10 float, @diem40 float, @diem50 float
as
begin
update tblDiem set Diem10 = @diem10, Diem40 = @diem40, Diem50 = @diem50,
ngaycapnhat = getdate(),nguoicapnhat = @nguoicapnhat
where masinhvien = @msv and malophoc = @mlh
end

create trigger trg_updateDiem on tblDiem after update
as
begin
update tblDiem set Tongket = Diem10*0.1+Diem40*0.4+Diem50*0.5
end

exec updateDiem 'SV1126','LHP15','10','10','10'

select*from tblMonHoc
select*from tblDiem
select*from tblLopHocPhan
select count(*)from tblDiem where masinhvien = 'SV1126'

alter proc dkyhoc
@masinhvien char(10),
@malophoc char(10),
@Thu int,@Ca int
as
begin
declare
		@v_mamonhoc int,
		@v_dadangky int;
		--lấy mã môn học dựa vào mã lớp
select @v_mamonhoc = mamonhoc
from tblLopHocPhan
where malophoc = @malophoc
-- lấy số lần học từng môn dựa vào mã môn và mã sinh viên
select @v_dadangky = count(*)
from tblDiem d
inner join tblLopHocPhan l on d.malophoc = l.malophoc
where  -->lớp đang mở
l.mamonhoc = @v_mamonhoc
and d.masinhvien = @masinhvien

if not exists(select malophoc from tblLopHocPhan where malophoc = @malophoc) print N'Lớp học không tồn tại, không thể đăng ký'
else if not exists(select masinhvien from tblSinhVien where masinhvien = @masinhvien) print N'Sinh viên không tồn tại, không thể đăng ký'
else if exists (select distinct ca,thu,masinhvien from tblLopHocPhan,tblDiem where thu = @Thu and ca = @Ca and masinhvien = @masinhvien and tblLopHocPhan.malophoc = tblDiem.malophoc)
print N'Không thể đăng ký lớp học này vì trùng lịch'
--> nếu kết quả trả về v_dangky >0 sinh viên này đã đăng ký 1 lớp học cùng 1 môn (trùng mã môn học, khác mã lớp học)
else if @v_dadangky>0 return -1;
else
insert into tblDiem(nguoitao,masinhvien,malophoc)
values(@masinhvien,@masinhvien,@malophoc);
if @@ROWCOUNT >0 return 1 else return 0;
end

select*from tblDiem
select*from tblLopHocPhan
select*from tblMonHoc
exec dkyhoc 'SV1134','LHP15','4','6'

insert into tblLopHocPhan(malophoc,mamonhoc,magiaovien,daketthuc,ca,thu) values ('LHP'+cast(next value for LophocphanSeq as varchar(30)),14,'GV1126',0,4,7)

select*from tblSinhVien
-- add thêm 1 column chuyên ngành
create table LopChuyenNganh(malopchuyennganh char(10) not null primary key, caclopchuyennganh nvarchar(30),sotinchiratruong int,manganh char(10) references chuyennganh(manganh))
insert into LopChuyenNganh values('CNTT62A',N'Công nghệ thông tin',N'Công nghệ thông tin 62A',130)
insert into LopChuyenNganh values('CNTT62B',N'Công nghệ thông tin',N'Công nghệ thông tin 62B',130)
insert into LopChuyenNganh values('CNTT61A',N'Công nghệ thông tin',N'Công nghệ thông tin 61A',130)
insert into LopChuyenNganh values('CNTT61B',N'Công nghệ thông tin',N'Công nghệ thông tin 61B',130)
insert into LopChuyenNganh values('MIS62A',N'Công nghệ thông tin',N'Hệ thống thông tin quản lý 62A',125)
insert into LopChuyenNganh values('MIS62B',N'Công nghệ thông tin',N'Hệ thống thông tin quản lý 62B',125)
insert into LopChuyenNganh values('CS62A',N'Công nghệ thông tin',N'Khoa học máy tính 62A',120)
insert into LopChuyenNganh values('CS62B',N'Công nghệ thông tin',N'Khoa học máy tính 62B',120)
select*from lopchuyennganh

select*from tblSinhVien
alter table tblSinhVien add manganh char(10) references LopChuyenNganh(manganh)
update tblSinhVien set manganh = 'CNTT62B' where masinhvien = 'SV1129'
update tblSinhVien set manganh = 'CNTT61B' where masinhvien = 'SV1132'
update tblSinhVien set manganh = 'CNTT61A' where masinhvien = 'SV1134'
update tblSinhVien set manganh = 'MIS62A' where masinhvien = 'SV1135'
update tblSinhVien set manganh = 'MIS62B' where masinhvien = 'SV1136'
update tblSinhVien set manganh = 'CS62A' where masinhvien = 'SV1137'
update tblSinhVien set manganh = 'CS62B' where masinhvien = 'SV1138'
update tblSinhVien set manganh = 'CNTT62B' where masinhvien = 'SV1139'

----đang lỗi phần updateSV

select*from LopChuyenNganh
select*from tblMonHoc
delete from LopChuyenNganh where manganh = ''

select*from lopchuyennganh
select*from chuyennganh

alter procedure selectnganhhoc @tukhoa char(10)
as
select 
malopchuyennganh,
tennganh,
caclopchuyennganh,
sotinchiratruong,
chuyennganh.manganh
from LopChuyenNganh, chuyennganh
where lopchuyennganh.manganh = chuyennganh.manganh and 
		(lower(chuyennganh.manganh) like '%'+lower(trim(@tukhoa))+'%'
		or lower(tennganh) like '%'+lower(trim(@tukhoa))+'%'
		or lower(caclopchuyennganh) like '%'+lower(trim(@tukhoa))+'%'
		or lower(malopchuyennganh) like '%'+lower(trim(@tukhoa))+'%'
		or sotinchiratruong like '%'+lower(trim(@tukhoa))+'%')
		order by manganh
		
exec selectnganhhoc N''

select*from 
alter procedure themNganhhoc @manganh char(10), @tennganh nvarchar(50), @lopchuyennganh nvarchar(50), @stcratruong int, @manganh char(10)
as
begin
if exists(select manganh from LopChuyenNganh where manganh = @manganh)
print N'Đã tồn tại ngành này trong danh sách'
else insert into LopChuyenNganh values(@manganh,@tennganh,@lopchuyennganh,@stcratruong)
end

exec themNganhhoc N'TMDT61A',N'Thương mại điện tử',N'Thương mại điện tử 61A',N'125'

select*from chuyennganh
select*from LopChuyenNganh

alter procedure themLopChuyenNganh @malopchuyennganh char(10), @lopchuyennganh nvarchar(50), @stcratruong int, @manganh char(10)
as
begin
if exists(select malopchuyennganh from LopChuyenNganh where malopchuyennganh = @malopchuyennganh)
print N'Đã tồn lớp chuyên ngành này trong danh sách'
else if not exists(select manganh from chuyennganh where manganh = @manganh)
print N'Chưa tồn tại mã ngành này, hãy thêm ngành này trước khi thêm lớp học'
else insert into LopChuyenNganh values(@malopchuyennganh,@lopchuyennganh,@stcratruong,@manganh)
end

exec updateNganhhoc N'TMDT61A',N'Thương mại điện tử',N'Thương mại điện tử 61A',N'125','TMDT'

alter procedure updateLopChuyenNganh @malopchuyennganh char(10),@lopchuyennganh nvarchar(50), @stcratruong int, @manganh char(10)
as
begin
update LopChuyenNganh set caclopchuyennganh = @lopchuyennganh, sotinchiratruong = @stcratruong, manganh = @manganh
where malopchuyennganh = @malopchuyennganh
end

select*from LopChuyenNganh

alter procedure selectNH @malopchuyennganh char(10)
as
begin
select*from LopChuyenNganh
where malopchuyennganh = @malopchuyennganh
end


exec selectNH 'CNTT61A'
select*from tblDiem
select*from tblLopHocPhan

select*from tblDiem
select*from tblLopHocPhan

alter procedure thoikhoabieu @msv char(10)
as
begin
select thu,ca,tblDiem.malophoc,tenmonhoc,concat(toanha,'-',phong) as phonghoc,concat(lichthi,'- ca',ca,N'- thứ',thu) as lichthi
from tblLopHocPhan,tblMonHoc,tblDiem
where masinhvien = @msv and tblLopHocPhan.malophoc = tblDiem.malophoc and tblMonHoc.mamonhoc = tblLopHocPhan.mamonhoc
order by thu
end

exec thoikhoabieu 'SV1126'
select*from tblLopHocPhan
alter table tblLopHocPhan add toa nvar

select*from tblLopHocPhan

alter table tblLopHocPhan alter column phong char(20)
update tblLopHocPhan set phong = '104' where malophoc = 'LHP27'
update tblLopHocPhan set phong = '100' where malophoc = 'LHP26'
update tblLopHocPhan set phong = '101' where malophoc = 'LHP25'
update tblLopHocPhan set phong = '105' where malophoc = 'LHP28'
update tblLopHocPhan set phong = '204' where malophoc = 'LHP24'

select*from tblSinhVien
select*from tblDiem
update tblDiem set nguoicapnhat = 'GV1120' where malophoc = 'LHP15' and masinhvien = 'SV1134'


create procedure xoadangky @msv char(10), @mlh char(10)
as
begin
delete from tblDiem where masinhvien = @msv and malophoc = @mlh and nguoicapnhat = N'admin'
end
go

exec xoadangky 'SV1134','LHP29'

select*from tblLopHocPhan
alter table tblLopHocPhan alter column lichthi date
update tblLopHocPhan set lichthi = dateadd(day,100,ngaytao)

select*from tblLopHocPhan
select*from tblDiem

create procedure deleteLHP @mlh char(10)
as
begin
delete from tblDiem where malophoc = @mlh
delete from tblLopHocPhan where malophoc = @mlh
if(@@ROWCOUNT>0) return 1 else return 0;
end
go

exec deleteLHP 'LHP11'

alter procedure deleteMH @mmh char(10)
as
begin
delete from tblDiem where malophoc in(select malophoc from tblLopHocPhan where mamonhoc = @mmh)
delete from tblLopHocPhan where mamonhoc = @mmh
delete from tblMonHoc where mamonhoc = @mmh
if(@@ROWCOUNT>0) return 1 else return 0;
end
go

exec deleteMH '3'

select*from tblmonhoc
select*from tblLopHocPhan
select*from taikhoan
select*from LopChuyenNganh
select*from tblDiem
select*from tblSinhVien

alter procedure deleteLCN @mlcn char(10)
as
begin
delete from tblDiem where masinhvien in (select masinhvien from tblSinhVien where manganh=@mlcn)
delete from tblSinhVien where manganh = @mlcn
delete from LopChuyenNganh where malopchuyennganh = @mlcn
if(@@ROWCOUNT>0) return 1 else return 0;
end
go


-----------------------------------------------------------------------------
select*from chuyennganh
create table ChuyenNganh (manganh char(10) not null primary key, tennganh nvarchar(60), makhoa_vien char(10) references tblVien(makhoa_vien))
alter table ChuyenNganh add vien nvarchar(60)
insert into ChuyenNganh values('CNTT',N'Công nghệ thông tin',N'Viện Công nghệ thông tin và Kinh tế số')
insert into ChuyenNganh values('TMDT',N'Thương mại điện tử',N'Viện thương mại và kinh tế quốc tế')
insert into ChuyenNganh values('MIS',N'Hệ thống thông tin quản lý',N'Viện Công nghệ thông tin và Kinh tế số')
insert into ChuyenNganh values('CS',N'Khoa học máy tính',N'Viện Công nghệ thông tin và Kinh tế số')


select*from tblGiaoVien
select*from LopChuyenNganh
alter table LopChuyenNganh add manganh char(10) references ChuyenNganh(manganh)

alter table tblGiaoVien add nganhday nvarchar(60) references LopChuyenNganh(tennganh)
update tblGiaoVien set nganhday = N'Công nghệ thông tin'where magiaovien = 'GV1121' or magiaovien = 'GV1123' or magiaovien = 'GV1126'

update LopChuyenNganh set manganh = 'TMDT' where malopchuyennganh like '%TMDT%'
select distinct manganh from LopChuyenNganh

select*from chuyennganh
select*from lopchuyennganh

alter procedure SelectNganh @tukhoa nvarchar(50)
as
	select manganh,
	tennganh,
	makhoa_vien
	from chuyennganh
	where 
		lower(manganh) like '%'+lower(trim(@tukhoa))+'%'
		or lower(tennganh) like '%'+lower(trim(@tukhoa))+'%'
		or lower(makhoa_vien) like '%'+lower(trim(@tukhoa))+'%'
		order by tennganh


exec selectnganh 'CNTT'

alter proc insertNganh @manganh char(10), @tennganh nvarchar(60), @vien char(10)
as
begin
if exists(select manganh from chuyennganh where manganh = @manganh)
print N'Mã ngành đã tồn tại, không thể thêm'
else if not exists(select makhoa_vien from tblVien where makhoa_vien = @vien)
print N'Không tồn tại viện này, không thể thêm'
else insert into chuyennganh values(@manganh,@tennganh,@vien)
end

alter proc updateNganh @manganh char(10), @tennganh nvarchar(60), @vien char(10)
as
begin
if not exists(select makhoa_vien from tblVien where makhoa_vien = @vien)
print N'Không tồn tại viện này, không thể cập nhật'
else
update chuyennganh set tennganh = @tennganh, makhoa_vien = @vien where manganh = @manganh
end

select*from chuyennganh

-- kiểm soát việc thêm, sửa liên quan tới trưởng bộ môn
select*from tblGiaoVien
alter table tblGiaoVien add  manganh char(10) references chuyennganh(manganh)

update tblGiaoVien set manganh = 'CNTT' where magiaovien = 'GV1120' or magiaovien = 'GV1126' or magiaovien = 'GV1127' or magiaovien = 'GV1128' or magiaovien = 'GV1120' or magiaovien = 'GV1129' or

select*from lopchuyennganh
select*from chuyennganh
select*from tblsinhvien

select*from tblmonhoc
select*from chuyennganh

alter table tblMonHoc add manganh char(10) references chuyennganh(manganh)
update tblMonhoc set manganh = 'CS' where sotinchi = '12'

create proc xoaNganh @manganh char(10)
as
begin
delete from tblDiem where masinhvien in(select masinhvien from tblSinhVien where manganh in(select malopchuyennganh from lopchuyennganh where manganh = @manganh))
delete from tblSinhVien where manganh in(select malopchuyennganh from LopChuyenNganh where manganh = @manganh)
delete from tblGiaoVien where manganh = @manganh
delete from tblMonHoc where manganh = @manganh
delete from lopchuyennganh where manganh = @manganh
delete from ChuyenNganh where manganh = @manganh
end

select*from tblDiem
select*from tblSinhVien
select masinhvien from tblSinhVien where manganh in(select malopchuyennganh from lopchuyennganh where manganh = 'CNTT')

select*from ChuyenNganh
insert into ChuyenNganh values('POHE',N'Kinh tế Quốc tế',N'Viện thương mại và kinh tế Quốc tế')
delete from chuyennganh where manganh = 'POHE'
delete from LopChuyenNganh where manganh = 'POHE'

select*from tblMonHoc
select*from tblSinhVien
select*from chuyennganh

select*from tblGiaoVien
select*from lopchuyennganh

create proc selectnganh_hoc @manganh char(10)
as
begin
select*from chuyennganh where manganh = @manganh
end

selectnganh_hoc 'CNTT'

alter table tblGiaoVien drop constraint FK__tblGiaoVi__manga__78D3EB5B
alter table tblGiaoVien drop column manganh
select*from tblGiaoVien

select*from chuyennganh


insert into tblVien values('CNTTVKTS',N'Viện công nghệ thông tin và kinh tế số')
insert into tblVien values('MARKETING',N'Viện marketing')
insert into tblVien values('NHTC',N'Viện ngân hàng tài chính')
insert into tblVien values('SAA',N'Viện kế toán - kiểm toán')


select*from tblVien
drop table tblVien

alter table chuyennganh add makhoa_vien char(10) references tblVien(makhoa_vien)
update chuyennganh set makhoa_vien = 'CNTTVKTS' where manganh = 'CNTT' or manganh = 'CS'or manganh = 'MIS'or manganh = 'TMDT'
update chuyennganh set makhoa_vien = 'MARKETING' where manganh = 'QHCC' or manganh = 'POHE'

drop table bomon_giaovien
create table bomon_giaovien (mabomon char(10) primary key, tenbomon nvarchar(60), makhoa_vien char(10) references tblVien(makhoa_vien))

select*from bomon_giaovien
insert into bomon_giaovien values('CNTT','Công nghệ thông tin','CNTTVKTS')
insert into bomon_giaovien values('MIS','Hệ thống thông tin quản lý','CNTTVKTS')
insert into bomon_giaovien values('NLKT','Nguyên lý kế toán','SAA')
insert into bomon_giaovien values('KTQT','Kế toán quản trị','SAA')

select*from tblGiaoVien
alter table tblGiaoVien add mabomon char(10) references bomon_giaovien(mabomon)

select*from tblGiaoVien
update tblGiaoVien set mabomon = 'KTQT' where magiaovien = 'GV1130' or magiaovien = 'GV1123'

--update lại toàn bộ các proc
insert into tblGiaoVien(magiaovien,ho,tendem,ten,gioitinh,ngaysinh,dienthoai,email,diachi,chucvu,mabomon) values('GV'+cast(next value for giaovienSeq as varchar(30)),'Moon','','An','Nam','2000-02-02','','','',N'Giáo viên','MIS')

--tạo proc cập nhật


--select*from tblGiaoVien where mabomon = 

select mabomon from tblGiaoVien where magiaovien = 'GV1120'

alter proc duyet_giaovienbomon @magiaovien char(10)
as
begin
select magiaovien, concat(ho,' ',tendem,' ',ten) as hoten,gioitinh, ngaysinh, dienthoai, email, diachi 
from tblGiaoVien where mabomon in (select mabomon from tblGiaoVien where magiaovien = @magiaovien)
end

duyet_giaovienbomon 'GV1120'

alter proc timkiemgiaovien @magiaovien char(10),@tukhoa nvarchar(30)
as
begin
select magiaovien, concat(ho,' ',tendem,' ',ten) as hoten,gioitinh, ngaysinh, dienthoai, email, diachi 
from tblGiaoVien where mabomon in (select mabomon from tblGiaoVien where magiaovien = @magiaovien)
and
(
lower(magiaovien) like N'%'+lower(trim(@tukhoa))+N'%' or
lower(ho) like N'%'+lower(trim(@tukhoa))+N'%' or
lower(tendem) like '%'+lower(trim(@tukhoa))+'%' or
lower(ten) like '%'+lower(trim(@tukhoa))+'%' or
lower(ho) like N'%'+lower(trim(@tukhoa))+N'%' or
lower(concat(ho,' ',tendem,' ',ten)) like N'%'+lower(trim(@tukhoa))+N'%' or
lower(gioitinh) = lower(trim(@tukhoa)) or
lower(dienthoai) like N'%'+lower(trim(@tukhoa))+N'%' or
lower(email) like N'%'+lower(trim(@tukhoa))+N'%' or
lower(diachi) like N'%'+lower(trim(@tukhoa))+N'%')
end

timkiemgiaovien N'GV1120',N'Nguyễn Danh'

selectnganh N'Công'

alter proc chiagiaovien @malophoc char(10), @magiaovien char(10), @ca int, @thu int
as
begin
if not exists(select distinct magiaovien from tblLopHocPhan where magiaovien = @magiaovien and ca = @Ca and thu = @Thu) 
update tblLopHocPhan set magiaovien = @magiaovien
where malophoc = @malophoc
if(@@ROWCOUNT>0) return 1 else return 0;
end

chiagiaovien 'LHP98','GV1129',5,4


tongtinchi 'SV1202'

select*from ChuyenNganh
create proc xoabomon @mabomon char(10)
as
begin
delete from tblGiaoVien where mabomon = @mabomon
delete from bomon_giaovien where mabomon = @mabomon
end

create proc thembomon @mabomon char(10), @tenbomon nvarchar(30), @makhoa_vien char(10)
as
begin
insert into bomon_giaovien values(@mabomon, @tenbomon, @makhoa_vien)
end

thembomon 'BM1',N'Bộ môn 1','CNTTVKTS'
select*from bomon_giaovien

alter proc sua @mabomon char(10), @tenbomon nvarchar(30), @makhoa_vien char(10)
as
begin
update bomon_giaovien set tenbomon = @tenbomon, makhoa_vien = @makhoa_vien where mabomon = @mabomon
end

select*from bomon_giaovien
sua 'BM1',N'Bộ môn 1','CNTTVKTS'

create proc selectBM @mabomon char(10)
as
begin
select*from bomon_giaovien where mabomon = @mabomon
end

select*from bomon_giaovien
select*from tblVien
update bomon_giaovien set makhoa_vien = 'MARKETING' where mabomon = 'NLKT'

selectBM 'cntt'

create procedure Selectbomon @tukhoa nvarchar(50)
as
	select mabomon, tenbomon, makhoa_vien
	from bomon_giaovien
	where 
		lower(tenbomon) like '%'+lower(trim(@tukhoa))+'%'
		or lower(mabomon) like '%'+lower(trim(@tukhoa))+'%'
		or lower(makhoa_vien) like '%'+lower(trim(@tukhoa))+'%'
		order by tenbomon

		select*from tblGiaoVien
		select*from tblMonHoc
		select*from tblLopHocPhan

select*from tblmonhoc
select distinct tblMonHoc.manganh from tblMonHoc,chuyennganh,tblLopHocPhan where tblMonHoc.manganh = chuyennganh.manganh and 
tblLopHocPhan.mamonhoc = tblMonHoc.mamonhoc 

alter proc lophocphan_theomanganh  @magiaovien char(10)
as
begin 
select malophoc, tblLopHocPhan.mamonhoc,tenmonhoc,magiaovien,ca, thu, toanha, phong, lichthi, manganh from tblLopHocPhan, tblmonhoc
where tblLopHocPhan.mamonhoc = tblMonHoc.mamonhoc and manganh in (select distinct tblMonHoc.manganh from tblMonHoc,chuyennganh,tblLopHocPhan where tblMonHoc.manganh = chuyennganh.manganh and 
tblLopHocPhan.mamonhoc = tblMonHoc.mamonhoc and magiaovien = @magiaovien)
end

lophocphan_theomanganh 'GV1120'
select*from tblLopHocPhan


select*from bomon_giaovien
select*from tblGiaoVien

-----------------------------------------------------
select*from tblDiem
select*from tblLopHocPhan
select*from lopchuyennganh

alter procedure xuatfilediem @masinhvien char(10)
as
begin
select*from sinhvien where masinhvien = @masinhvien
end

xuatfilediem 'SV1200'

select*from tblLopHocPhan

alter view sinhvien
as
select tblSinhVien.masinhvien, concat(ho,' ',tendem,' ',ten) as hoten,ngaysinh,tblSinhVien.manganh,caclopchuyennganh,tennganh,tblLopHocPhan.mamonhoc,tblDiem.malophoc,tenmonhoc,diem10,diem40,diem50,tongket
from tblLopHocPhan,tblMonHoc,tblDiem,tblSinhVien,LopChuyenNganh,ChuyenNganh
where tblDiem.malophoc = tblLopHocPhan.malophoc and tblMonHoc.mamonhoc = tblLopHocPhan.mamonhoc
and tblSinhVien.masinhvien = tblDiem.masinhvien and LopChuyenNganh.malopchuyennganh = tblSinhVien.manganh and ChuyenNganh.manganh = LopChuyenNganh.manganh

select* from sinhvien
xuatfilediem 'SV1200'

select*from tblLopHocPhan
select*from tblGiaoVien

alter view giaovien
as
select malophoc,mamonhoc,concat('Ca',' ',ca,' ',N'Thứ',' ',thu) as ngayhoc,concat(toanha,'-',phong) as phonghoc,lichthi,concat(ho,' ',tendem,' ',ten) as hoten,chucvu,tblGiaoVien.mabomon,tblGiaoVien.MAGIAOVIEN,tenbomon
from tblGiaoVien, tblLopHocPhan, bomon_giaovien where tblGiaoVien.magiaovien = tblLopHocPhan.magiaovien and tblGiaoVien.mabomon = bomon_giaovien.mabomon

select*from giaovien where magiaovien = 'GV1121'
