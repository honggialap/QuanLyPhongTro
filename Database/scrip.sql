create table KHACHHANG(
	idKhachHang int Identity  primary key,
	hoTenKhachHang varchar, 
	thongTinCaNhan varchar,
	lienLac varchar, 
	ghiChu varchar, 
	idHopDong int,
)

create table HOPDONG(
	idHopdong int Identity  primary key,
	bieuPhiTuyBien int, 
	bieuPhiGiaPhong int,
	idPhieuThu int, 
	idPhongTro int, 
	ghiChu varchar,
)

create table PHIEUTHU(
	idPhieuThu int Identity  primary key,
	phiTuyBien int, 
	phiThuePhong int,
	tienNuoc int, 
	tienDien int, 
	ghiChu varchar,
)

create table PHONGTRO(
	idPhongTro int Identity  primary key,
	tenPhong varchar, 
	giaKhuyenNghi int,
	tinhTrangPhong varchar, 
	chiSoNuocHienHanh int, 
	chiSoDienHienHanh varchar,
)

create table ACCOUNT(
	id int Identity  primary key,
	taiKhoan varchar, 
	matKhau varchar,
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