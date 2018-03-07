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
using Entities;
using DataAccess;

namespace CybellesCykler
{
    public partial class MainWindow : Window
    {
        DbHandler dbh;
        public MainWindow()
        {
            InitializeComponent();
           
            dbh = new DbHandler();
            this.DataContext = dbh;
        }

        private void BtnShowRentees_Click(object sender, RoutedEventArgs e)
        {
            DtgSelected.ItemsSource = dbh.GetAllRentees();
        }

        private void BtnShowBikes_Click(object sender, RoutedEventArgs e)
        {
            DtgSelected.ItemsSource = dbh.GetAllBikes();
        }

        private void BtnShowOrders_Click(object sender, RoutedEventArgs e)
        {
            Orders WO = new Orders();
            WO.ShowDialog();
        }
    }
}
