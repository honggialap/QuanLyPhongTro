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
            account.matKhau = matKhau.Text;
            Customer formCustomer = new Customer();
            bool kq = login.DangNhap(account);
            if (kq == true)
            {
                MessageBox.Show("Đang nhập thành công");
                this.Close();
                formCustomer.Show();
            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại", "Vui lòng kiểm tra lại thông tin tài khoản mật khẩu");
            }
        }
    }
}
