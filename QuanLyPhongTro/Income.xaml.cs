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

namespace QuanLyPhongTro
{
    /// <summary>
    /// Interaction logic for Income.xaml
    /// </summary>
    public partial class Income : Window
    {
        public Home home;
        public Income()
        {
            InitializeComponent();
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            home.Show();
        }
    }
}
