using Belajar_CRUD_WPF_Dionisius.Context;
using Belajar_CRUD_WPF_Dionisius.Models;
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

namespace Belajar_CRUD_WPF_Dionisius
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        MyContext myContext = new MyContext();
        public MainWindow()
        {
            InitializeComponent();
            TableSupplier.ItemsSource = myContext.Suppliers.ToList();
        }

        private void TableSupplier_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void btn_input_Click(object sender, RoutedEventArgs e)
        {
            //var input = new Supplier(tb_name);
        }

        private void btn_update_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btn_delete_Click(object sender, RoutedEventArgs e)
        {

        }

    }
}
