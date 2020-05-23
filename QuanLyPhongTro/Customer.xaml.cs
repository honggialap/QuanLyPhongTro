using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using DTO;
using Model;

namespace QuanLyPhongTro
{
    /// <summary>
    /// Interaction logic for Customer.xaml
    /// </summary>
    public partial class Customer : Window
    {
        public Customer()
        {
            InitializeComponent();
            LoadGridKhachHang();
            LoadGridPhongTro();
            LoadGridPhieuChi();
            LoadGridPhieuThu();
            LoadGridHopDong();
        }

        private KhachHangModel khModel = new KhachHangModel();
        private PhongTroModel phongTroModel = new PhongTroModel();
        private HopDongModel hopDongModel = new HopDongModel();
        private PhieuThuModel phieuThuModel = new PhieuThuModel();
        private PhieuChiModel phieuChiModel = new PhieuChiModel();

        private void resetTabKH()
        {
            tbHoTen.Text = null;
            tbThongTin.Text = null;
            tbLienLac.Text = null;
            tbGhiChu.Text = null;
            tbMaHD.Text = null;
            LoadGridKhachHang();
        }
        private void LoadGridKhachHang()
        {
            List<KHACHHANG> listKhachHang = khModel.getAll();
            gridKhachHang.ItemsSource = listKhachHang;
        }

        private void BtThem_Click(object sender, RoutedEventArgs e)
        {
            KHACHHANG khachHang = new KHACHHANG();
            khachHang.hoTenKH = tbHoTen.Text;
            khachHang.thongTin = tbThongTin.Text;
            khachHang.lienLac = tbLienLac.Text;
            khachHang.ghiChu = tbGhiChu.Text;
            khModel.Add(khachHang);
            resetTabKH();
        }

        private void BtSua_Click(object sender, RoutedEventArgs e)
        {
            KHACHHANG khachHang = new KHACHHANG();
            khachHang.hoTenKH = tbHoTen.Text;
            khachHang.thongTin = tbThongTin.Text;
            khachHang.lienLac = tbLienLac.Text;
            khachHang.ghiChu = tbGhiChu.Text;
            khachHang.idKhachHang = int.Parse(tbMaHD.Text);
            khModel.Edit(khachHang);
            resetTabKH();
        }

        private void GridKhachHang_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void BtXoa_Click(object sender, RoutedEventArgs e)
        {
            KHACHHANG khachHang = new KHACHHANG();
            khachHang.hoTenKH = tbHoTen.Text;
            khachHang.thongTin = tbThongTin.Text;
            khachHang.lienLac = tbLienLac.Text;
            khachHang.ghiChu = tbGhiChu.Text;
            khachHang.idKhachHang = int.Parse(tbMaHD.Text);
            khModel.Delete(khachHang);
            resetTabKH();
        }

        /// <summary>
        /// tab Phong tro
        /// </summary>
        /// 
        private void resetTabPhongTro()
        {
            tbTabPhongTroTenPhong.Text = null;
            tbTabPhongTroGia.Text = null;
            tbTabPhongTroTinhTrang.Text = null;
            tbTabPhongTroChiSoNuoc.Text = null;
            tbTabPhongTroChiSoDien.Text = null;
            tbTabPhongTroMaHD.Text = null;
            LoadGridPhongTro();
        }
        private void LoadGridPhongTro()
        {
            List<PHONGTRO> listPhongTro = phongTroModel.getAll();
            gridTabPhongTroPhongtro.ItemsSource = listPhongTro;
        }

        private void BtTabPhongTroThem_Click(object sender, RoutedEventArgs e)
        {
            PHONGTRO phongTro = new PHONGTRO();
            phongTro.tenPhong = tbTabPhongTroTenPhong.Text;
            phongTro.giaKhuyenNghi = int.Parse( tbTabPhongTroGia.Text);
            phongTro.tinhTrangPhong = tbTabPhongTroTinhTrang.Text;
            phongTro.chiSoNuocHienHanh = int.Parse( tbTabPhongTroChiSoNuoc.Text);
            phongTro.chiSoDienHienHanh = int.Parse(tbTabPhongTroChiSoDien.Text);
            phongTroModel.Add(phongTro);
            resetTabPhongTro();
        }

        private void BtTabPhongTroSua_Click(object sender, RoutedEventArgs e)
        {
            PHONGTRO phongTro = new PHONGTRO();
            phongTro.tenPhong = tbTabPhongTroTenPhong.Text;
            phongTro.giaKhuyenNghi = int.Parse(tbTabPhongTroGia.Text);
            phongTro.tinhTrangPhong = tbTabPhongTroTinhTrang.Text;
            phongTro.chiSoNuocHienHanh = int.Parse(tbTabPhongTroChiSoNuoc.Text);
            phongTro.chiSoDienHienHanh = int.Parse(tbTabPhongTroChiSoDien.Text);
            phongTro.idPhongTro = int.Parse(tbTabPhongTroMaHD.Text);
            phongTroModel.Edit(phongTro);
            resetTabPhongTro();
        }

        private void BtTabPhongTroXoa_Click(object sender, RoutedEventArgs e)
        {
            PHONGTRO phongTro = new PHONGTRO();
            phongTro.tenPhong = tbTabPhongTroTenPhong.Text;
            phongTro.giaKhuyenNghi = int.Parse(tbTabPhongTroGia.Text);
            phongTro.tinhTrangPhong = tbTabPhongTroTinhTrang.Text;
            phongTro.chiSoNuocHienHanh = int.Parse(tbTabPhongTroChiSoNuoc.Text);
            phongTro.chiSoDienHienHanh = int.Parse(tbTabPhongTroChiSoDien.Text);
            phongTro.idPhongTro = int.Parse(tbTabPhongTroMaHD.Text);
            phongTroModel.Delete(phongTro);
            resetTabPhongTro();
        }
        /////
        ///Phieu Chi
        ///
        private void resetTabPhieuChi()
        {
            tbTabPhieuChiTenPhieuChi.Text = null;
            tbTabPhieuChiTienDien.Text = null;
            tbTabPhieuChiTienNuoc.Text = null;
            tbTabPhieuChiTienKhac.Text = null;
            tbTabPhieuChiMaHD.Text = null;
            LoadGridPhieuChi();

        }
        private void LoadGridPhieuChi()
        {
            List<PHIEUCHI> listPhieuChi = phieuChiModel.getAll();
            gridTabPhieuChi.ItemsSource = listPhieuChi;
        }

        private void BtTabPhieuChiThem_Click(object sender, RoutedEventArgs e)
        {
            PHIEUCHI phieuChi = new PHIEUCHI();
            phieuChi.tenPhieuChi = tbTabPhieuChiTenPhieuChi.Text;
            phieuChi.tienDien = int.Parse(tbTabPhieuChiTienDien.Text);
            phieuChi.tienNuoc = int.Parse(tbTabPhieuChiTienNuoc.Text);
            phieuChi.tienKhac = int.Parse(tbTabPhieuChiTienKhac.Text);
            phieuChiModel.Add(phieuChi);
            resetTabPhieuChi();
        }

        private void BtTabPhieuChiSua_Click(object sender, RoutedEventArgs e)
        {
            PHIEUCHI phieuChi = new PHIEUCHI();
            phieuChi.tenPhieuChi = tbTabPhieuChiTenPhieuChi.Text;
            phieuChi.tienDien = int.Parse(tbTabPhieuChiTienDien.Text);
            phieuChi.tienNuoc = int.Parse(tbTabPhieuChiTienNuoc.Text);
            phieuChi.tienKhac = int.Parse(tbTabPhieuChiTienKhac.Text);
            phieuChi.idPhieuChi = int.Parse(tbTabPhieuChiMaHD.Text);
            phieuChiModel.Edit(phieuChi);
            resetTabPhieuChi();
        }

        private void BtTabPhieuChiXoa_Click(object sender, RoutedEventArgs e)
        {
            PHIEUCHI phieuChi = new PHIEUCHI();
            phieuChi.tenPhieuChi = tbTabPhieuChiTenPhieuChi.Text;
            phieuChi.tienDien = int.Parse(tbTabPhieuChiTienDien.Text);
            phieuChi.tienNuoc = int.Parse(tbTabPhieuChiTienNuoc.Text);
            phieuChi.tienKhac = int.Parse(tbTabPhieuChiTienKhac.Text);
            phieuChi.idPhieuChi = int.Parse(tbTabPhieuChiMaHD.Text);
            phieuChiModel.Delete(phieuChi);
            resetTabPhieuChi();
        }

        ///
        ///Phieu Thu
        ///
        private void resetTabPhieuThu()
        {
            tbTabPhieuThuTenPhieuThu.Text = null;
            tbTabPhieuThuPhiTuyBien.Text = null;
            tbTabPhieuThuPhiThuePhong.Text = null;
            tbTabPhieuThuTienDien.Text = null;
            tbTabPhieuThuTienNuoc.Text = null;
            tbTabPhieuThuMaHD.Text = null;
            LoadGridPhieuThu();
        }
        private void LoadGridPhieuThu()
        {
            List<PHIEUTHU> listPhieuThu = phieuThuModel.getAll();
            gridTabPhieuThu.ItemsSource = listPhieuThu;
        }

        private void TbTabPhieuThuThem_Click(object sender, RoutedEventArgs e)
        {
            PHIEUTHU phieuThu = new PHIEUTHU();
            phieuThu.tenPhieuThu = tbTabPhieuThuTenPhieuThu.Text;
            phieuThu.phiTuyBien = int.Parse(tbTabPhieuThuPhiTuyBien.Text);
            phieuThu.phiThuePhong = int.Parse(tbTabPhieuThuPhiThuePhong.Text);
            phieuThu.tienDien = int.Parse(tbTabPhieuThuTienDien.Text);
            phieuThu.tienNuoc = int.Parse(tbTabPhieuThuTienNuoc.Text);
            phieuThu.ghiChu = tbGhiChu.Text;
            phieuThuModel.Add(phieuThu);
            resetTabPhieuThu();
        }

        private void BtTabPhieuThuSua_Click(object sender, RoutedEventArgs e)
        {
            PHIEUTHU phieuThu = new PHIEUTHU();
            phieuThu.tenPhieuThu = tbTabPhieuThuTenPhieuThu.Text;
            phieuThu.phiTuyBien = int.Parse(tbTabPhieuThuPhiTuyBien.Text);
            phieuThu.phiThuePhong = int.Parse(tbTabPhieuThuPhiThuePhong.Text);
            phieuThu.tienDien = int.Parse(tbTabPhieuThuTienDien.Text);
            phieuThu.tienNuoc = int.Parse(tbTabPhieuThuTienNuoc.Text);
            phieuThu.ghiChu = tbTabPhieuThuGhiChu.Text;
            phieuThu.idPhieuThu = int.Parse(tbTabPhieuThuMaHD.Text);
            phieuThuModel.Edit(phieuThu);
            resetTabPhieuThu();
        }

        private void BtTabPhieuThuXoa_Click(object sender, RoutedEventArgs e)
        {
            PHIEUTHU phieuThu = new PHIEUTHU();
            phieuThu.tenPhieuThu = tbTabPhieuThuTenPhieuThu.Text;
            phieuThu.phiTuyBien = int.Parse(tbTabPhieuThuPhiTuyBien.Text);
            phieuThu.phiThuePhong = int.Parse(tbTabPhieuThuPhiThuePhong.Text);
            phieuThu.tienDien = int.Parse(tbTabPhieuThuTienDien.Text);
            phieuThu.tienNuoc = int.Parse(tbTabPhieuThuTienNuoc.Text);
            phieuThu.ghiChu = tbTabPhieuThuGhiChu.Text;
            phieuThu.idPhieuThu = int.Parse(tbTabPhieuThuMaHD.Text);
            phieuThuModel.Delete(phieuThu);
            resetTabPhieuThu();
        }

        /// <summary>
        /// /tab khach hang
        /// </summary>
        /// 
        private void resetTabHopDong()
        {
            tbTabHopDongBieuPhiGiaPhong.Text = null;
            tbTabHopDongBieuPhiTuyBien.Text = null;
            tbTabHopDongGhiChu.Text = null;
            cbTabHopDongIdKhachHang.Text = null;
            cbTabHopDongIdKhachHang.Text = null;
            tbTabPhieuThuMaHD.Text = null;
            LoadGridHopDong();
        }
        private void LoadGridHopDong()
        {
            List<HOPDONG> listHopDong = hopDongModel.getAll();
            gridTabHopDong.ItemsSource = listHopDong;
            List<PHONGTRO> listPhongTro = phongTroModel.getAll();
            cbTabHopDongIdPhongTro.ItemsSource = listPhongTro;
            List<KHACHHANG> listKhachHang = khModel.getAll();
            cbTabHopDongIdKhachHang.ItemsSource = listKhachHang;
        }

        private void TbTabHopDongThem_Click(object sender, RoutedEventArgs e)
        {
            HOPDONG hopDong = new HOPDONG();
            hopDong.phiTuyBien = int.Parse(tbTabHopDongBieuPhiTuyBien.Text);
            hopDong.phiGiaPhong = int.Parse(tbTabHopDongBieuPhiGiaPhong.Text);
            hopDong.idPhongTro = int.Parse(cbTabHopDongIdPhongTro.Text.ToString());
            hopDong.idKhachHang = int.Parse(cbTabHopDongIdKhachHang.Text.ToString());
            hopDong.ghiChu = tbTabHopDongGhiChu.Text;
            hopDongModel.Add(hopDong);
            resetTabHopDong();
        }
    }
}
