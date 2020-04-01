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

        PHIEUCHI phieuChi = new PHIEUCHI();
        PhieuChiModel phieuChiModel = new PhieuChiModel();

        private void BtAdd_Click(object sender, RoutedEventArgs e)
        {
            phieuChi.tienDien = int.Parse(value1.Text);
            phieuChi.tienNuoc =int.Parse( value2.Text);
            phieuChi.tienKhac = int.Parse(value3.Text);

            phieuChi.idPhieuChi = 1;
            bool kq = phieuChiModel.Delete(phieuChi);
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
