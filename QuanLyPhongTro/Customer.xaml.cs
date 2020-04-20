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
            //load tab khach hang
            LoadGridKhachHang();
            LoadGridPhongTro();
            LoadGridHopDong();
        }

        private KhachHangModel khModel = new KhachHangModel();
        private PhongTroModel phongTroModel = new PhongTroModel();
        private HopDongModel hopDongModel = new HopDongModel();
        private PhieuThuModel phieuThuModel = new PhieuThuModel();

        /// <summary>
        /// /tab khach hang
        /// </summary>
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
            LoadGridKhachHang();
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
            LoadGridKhachHang();
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
            LoadGridKhachHang();
        }

        /// <summary>
        /// tab Phong tro
        /// </summary>
        /// 
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
            LoadGridPhongTro();
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
            LoadGridPhongTro();
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
            LoadGridPhongTro();
        }

        /// <summary>
        /// tab HopDong
        /// </summary>
        /// 
        private void LoadGridHopDong()
        {
            //load grid
            //    List<HOPDONG> listHopDong = hopDongModel.getAll();
            //    gridTabHopDong.ItemsSource = listHopDong;
            //    //load combo box
            //    List<KHACHHANG> listKhachHang = khModel.getAll();
            //    cbTabHopDongmaKH.ItemsSource = listKhachHang;
            //    cbTabHopDongmaKH.DisplayMemberPath = "hoTenKH";
            //    cbTabHopDongmaKH.SelectedValue = "idKhachHang";
            //    List<PHONGTRO> listPhongTro = phongTroModel.getAll();
            //    cbTabHopDongMaPhongTro.ItemsSource = listPhongTro;
            //    cbTabHopDongMaPhongTro.DisplayMemberPath = "tenPhong";
            //    cbTabHopDongMaPhongTro.SelectedValue = "idPhongTro";
            //    List<PHIEUTHU> listPhieuThu = phieuThuModel.getAll();
            //    cbTabHopDongMaPhieuThu.ItemsSource = listPhieuThu;
            //    cbTabHopDongMaPhieuThu.DisplayMemberPath = "idPhieuThu";
            //    cbTabHopDongMaPhieuThu.SelectedValue = "idPhieuThu";
        }
    }
}
