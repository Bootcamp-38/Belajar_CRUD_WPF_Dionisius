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
        MyContext myContext = new MyContext();
        public MainWindow()
        {
            InitializeComponent();
            TableSupplier.ItemsSource = myContext.Suppliers.ToList();
            tb_id.IsEnabled = false;
        }

        private void TableSupplier_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(tb_id.Text == string.Empty || tb_name.Text == string.Empty)
            {
                object item = TableSupplier.SelectedItem;

                // BERFUNGSI UNTUK MEMANGGIL TABEL KE TEXTBOX
                string ID = (TableSupplier.SelectedCells[0].Column.GetCellContent(item) as TextBlock).Text;
                tb_id.Text = ID;
                string Name = (TableSupplier.SelectedCells[1].Column.GetCellContent(item) as TextBlock).Text;
                tb_name.Text = Name;
            }   
        }

       

        private void btn_input_Click(object sender, RoutedEventArgs e)
        {
            var input = new Supplier(tb_name.Text);
            if (tb_name.Text == "")
            {
                MessageBox.Show("Tidak ada data yang dimasukkan");
                tb_name.Focus();
                
            }
            else {
                myContext.Suppliers.Add(input);
                myContext.SaveChanges();

                MessageBox.Show("Input Berhasil");
                TableSupplier.ItemsSource = myContext.Suppliers.ToList();
            }
            
        }

        private void btn_update_Click(object sender, RoutedEventArgs e)
        {
            if(tb_name.Text == string.Empty)
            {
                MessageBox.Show("What is the data!!!!");
            }
            else
            {
                int Id = (TableSupplier.SelectedItem as Supplier).Id;

                Supplier update = myContext.Suppliers.Where(id => id.Id == Id).Single();
                update.Name = tb_name.Text;
                myContext.SaveChanges();

                MessageBox.Show("Data Berhasil Update");
                TableSupplier.ItemsSource = myContext.Suppliers.ToList();
                tb_name.Clear();
                tb_id.Clear();
            }
        }

        private void btn_delete_Click(object sender, RoutedEventArgs e)
        {
            if(tb_name.Text == string.Empty)
            {
                MessageBox.Show("Tidak ada data");
            }
            else {
                int Id = (TableSupplier.SelectedItem as Supplier).Id;

                var deleteSupplier = myContext.Suppliers.Where(id => id.Id == Id).Single();
                myContext.Suppliers.Remove(deleteSupplier);
                myContext.SaveChanges();

                MessageBox.Show("Data Berhasil Dihapus");
                TableSupplier.ItemsSource = myContext.Suppliers.ToList();
                tb_name.Clear();
                tb_id.Clear();
            }
        }
    }
}
