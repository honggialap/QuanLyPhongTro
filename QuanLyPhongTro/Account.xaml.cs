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
    /// Interaction logic for Account.xaml
    /// </summary>
    public partial class Account : Window
    {
        public Home home;
        public ACCOUNT account;
        public LoginModel login;

        public Account()
        {
            InitializeComponent();
            Load();
        }

        public void Load()
        {
            login = new LoginModel();
            dataGrid.ItemsSource = login.Load();
        }

        private void Window_Closed_1(object sender, EventArgs e)
        {
            home.Show();
        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        { 
            if(dataGrid.SelectedItem != null)
            {
                account = new ACCOUNT();
                account = (ACCOUNT)dataGrid.SelectedItem;
                taiKhoan.Text = account.taiKhoan;
                matKhau.Text = account.matKhau;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (taiKhoan.Text != "" && matKhau.Text != "")
            {
                login = new LoginModel();
                account = new ACCOUNT();
                account.taiKhoan = taiKhoan.Text;
                account.matKhau = matKhau.Text;
                if(login.ThemTaiKhoan(account))
                    MessageBox.Show("Thành công");
                Load();
            }
           
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (taiKhoan.Text != "" && matKhau.Text != ""
                && dataGrid.SelectedItem != null)
            {
                login = new LoginModel();
                account = new ACCOUNT();
                account = (ACCOUNT)dataGrid.SelectedItem;
                account.taiKhoan = taiKhoan.Text;
                account.matKhau = matKhau.Text;
                if (login.SuaTaiKhoan(account))
                    MessageBox.Show("Thành công");
                Load();
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (dataGrid.SelectedItem != null)
            {
                login = new LoginModel();
                account = new ACCOUNT();
                account = (ACCOUNT)dataGrid.SelectedItem;
                account.taiKhoan = taiKhoan.Text;
                account.matKhau = matKhau.Text;
                if(login.xoa(account))
                    MessageBox.Show("Thành công");
                Load();
            }
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            taiKhoan.Text = "";
            matKhau.Text = "";
            dataGrid.SelectedItem = null;
        }
    }
}
