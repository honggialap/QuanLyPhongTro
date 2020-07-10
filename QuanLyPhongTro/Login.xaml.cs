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
using System.Windows.Navigation;
using System.Windows.Shapes;
using DTO;
using Model;
namespace QuanLyPhongTro
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        ACCOUNT account = new ACCOUNT();
        LoginModel login = new LoginModel();

        private void BtAdd_Click(object sender, RoutedEventArgs e)
        {
            account.taiKhoan = taiKhoan.Text;
            account.matKhau = matKhau.Password;
            bool kq = login.DangNhap(account);
            if (kq == true)
            {
                Home home = new Home();
                home.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Access denied!");
            }
        }

        private void TaiKhoan_TextChanged(object sender, TextChangedEventArgs e)
        {
        }

    }
}
