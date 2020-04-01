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

        PHIEUTHU phieuThu = new PHIEUTHU();
        PhieuThuModel phieuThuModel = new PhieuThuModel();

        private void BtAdd_Click(object sender, RoutedEventArgs e)
        {
            phieuThu.phiThuePhong = int.Parse(value4.Text);
            phieuThu.phiTuyBien = int.Parse(value5.Text);
            phieuThu.tienDien = int.Parse(value1.Text);
            phieuThu.tienNuoc = int.Parse( value3.Text);
            phieuThu.ghiChu = value2.Text;

            phieuThu.idPhieuThu = 1;
            bool kq = phieuThuModel.Delete(phieuThu);
            if (kq == true)
            {
                MessageBox.Show("thanh cong");
            }
            else
            {
                MessageBox.Show("that bai");
            }
        }
    }
}
