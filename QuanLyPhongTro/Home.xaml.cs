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
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Home : Window
    {
        public Motel motel;
        public Customer customer;
        public Contract contract;
        public Income income;
        public Outcome outcome;
        public Account account;
        public Home()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Motel motel = new Motel();
            motel.home = this;
            motel.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Customer customer = new Customer();
            customer.home = this;
            customer.Show();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Contract contract = new Contract();
            contract.home = this;
            contract.Show();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Contract contract = new Contract();
            contract.home = this;
            contract.Show();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Income income = new Income();
            income.home = this;
            income.Show();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Account ac = new Account();
            ac.home = this;
            ac.Show();
        }

        private void HomeWindow_Closed(object sender, EventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
