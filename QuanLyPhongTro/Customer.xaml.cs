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
            LoadGrid();
        }

        private KhachHangModel khModel = new KhachHangModel();


        private void LoadGrid()
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
            LoadGrid();
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
            LoadGrid();
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
            LoadGrid();
        }
    }
}
