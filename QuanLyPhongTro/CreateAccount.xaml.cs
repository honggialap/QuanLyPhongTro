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
    /// Interaction logic for CreateAccount.xaml
    /// </summary>
    public partial class CreateAccount : Window
    {
        public CreateAccount()
        {
            InitializeComponent();
        }

        ACCOUNT account = new ACCOUNT();
        LoginModel loginModel = new LoginModel();

        private void BtAdd_Click(object sender, RoutedEventArgs e)
        {
            account.taiKhoan = taiKhoan.Text;
            account.matKhau = matKhau.Text;
            account.id = 4;
            bool kq = loginModel.xoa(account);
            if (kq == true)
            {
                MessageBox.Show("thêm thanh cong");
            }
            else
            {
                MessageBox.Show("thêm fail");
            }
        }
    }
}
