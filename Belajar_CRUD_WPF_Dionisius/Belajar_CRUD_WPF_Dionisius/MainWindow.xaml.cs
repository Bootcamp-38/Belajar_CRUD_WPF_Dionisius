using Belajar_CRUD_WPF_Dionisius.Context;
using Belajar_CRUD_WPF_Dionisius.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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

namespace Belajar_CRUD_WPF_Dionisius
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            // Menampilkan DATA GRID
        }

        private void SupplierGo_Click(object sender, RoutedEventArgs e)
        {
            SupplierMenu page = new SupplierMenu();
            page.Show();
            this.Close();
        }

        private void ItemGo_Click(object sender, RoutedEventArgs e)
        {
            Page1 page = new Page1();
            page.Show();
            this.Close();
        }
    }
}