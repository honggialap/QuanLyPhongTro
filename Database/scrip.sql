create table KHACHHANG(
	idKhachHang int Identity  primary key,
	hoTenKhachHang varchar(100), 
	thongTinCaNhan varchar(100),
	lienLac varchar(100), 
	ghiChu varchar(100), 
	idHopDong int,
)

create table HOPDONG(
	idHopdong int Identity  primary key,
	bieuPhiTuyBien int, 
	bieuPhiGiaPhong int,
	idPhieuThu int, 
	idPhongTro int, 
	ghiChu varchar(100),
)

create table PHIEUTHU(
	idPhieuThu int Identity  primary key,
	phiTuyBien int, 
	phiThuePhong int,
	tienNuoc int, 
	tienDien int, 
	ghiChu varchar(100),
)

create table PHONGTRO(
	idPhongTro int Identity  primary key,
	tenPhong varchar(100), 
	giaKhuyenNghi int,
	tinhTrangPhong varchar(100), 
	chiSoNuocHienHanh int, 
	chiSoDienHienHanh varchar(100),
)

create table ACCOUNT(
	id int Identity  primary key,
	taiKhoan varchar(100), 
	matKhau varchar(100),
)

create table PHIEUCHI(
	idPhieuChi int Identity  primary key,
	tienDien int, 
	tienNuoc int,
	tienKhac int,
)
--KhachHang
ALTER TABLE KHACHHANG
ADD FOREIGN KEY (idHopDong) REFERENCES HOPDONG(idHopDong)
--Hop Dong 
ALTER TABLE HOPDONG
ADD FOREIGN KEY (idPhieuThu) REFERENCES PHIEUTHU(idPhieuThu)
ALTER TABLE HOPDONG
ADD FOREIGN KEY (idPhongTro) REFERENCES PHONGTRO(idPhongTro);