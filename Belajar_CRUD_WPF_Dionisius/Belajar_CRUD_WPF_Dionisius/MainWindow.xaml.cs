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
            // Menampilkan DATA GRID
            TableSupplier.ItemsSource = myContext.Suppliers.ToList();
            // Membuat Id tidak bisa diganti
            textBoxId.IsEnabled = false;
        }

        private void TableSupplier_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                object item = TableSupplier.SelectedItem;

                // Memanggil Tabel ke TextBox
                string ID = (TableSupplier.SelectedCells[0].Column.GetCellContent(item) as TextBlock).Text;
                textBoxId.Text = ID;
                string Name = (TableSupplier.SelectedCells[1].Column.GetCellContent(item) as TextBlock).Text;
                textBoxName.Text = Name;
            }
            catch (Exception)
            {
                
            }
                
        }

       

        private void ButtonInputClick(object sender, RoutedEventArgs e)
        {
            var input = new Supplier(textBoxName.Text);
            if (textBoxName.Text == string.Empty)
            {
                MessageBox.Show("Tidak ada data yang dimasukkan");
                textBoxName.Focus();
                
            }
            else {
                myContext.Suppliers.Add(input);
                myContext.SaveChanges();

                MessageBox.Show("Input Berhasil");
                TableSupplier.ItemsSource = myContext.Suppliers.ToList();
                textBoxName.Clear();
            }
            
        }

        private void ButtonUpdateClick(object sender, RoutedEventArgs e)
        {
            if(textBoxName.Text == string.Empty || textBoxId.Text == string.Empty)
            {
                MessageBox.Show("Pilih Data Terlebih Dahulu");
            }
            else
            {
                int Id = (TableSupplier.SelectedItem as Supplier).Id;

                Supplier update = myContext.Suppliers.Where(id => id.Id == Id).Single();
                update.Name = textBoxName.Text;
                myContext.SaveChanges();

                MessageBox.Show("Data Berhasil Update");
                TableSupplier.ItemsSource = myContext.Suppliers.ToList();
                textBoxName.Clear();
                textBoxId.Clear();
            }
        }

        private void ButtonDeleteClick(object sender, RoutedEventArgs e)
        {
            if(textBoxName.Text == string.Empty || textBoxId.Text == string.Empty)
            {
                MessageBox.Show("Tidak ada data yang ingin dihapus");
            }
            else {
                int Id = (TableSupplier.SelectedItem as Supplier).Id;

                var deleteSupplier = myContext.Suppliers.Where(id => id.Id == Id).Single();
                myContext.Suppliers.Remove(deleteSupplier);
                myContext.SaveChanges();

                MessageBox.Show("Data Berhasil Dihapus");
                TableSupplier.ItemsSource = myContext.Suppliers.ToList();
                textBoxName.Clear();
                textBoxId.Clear();
            }
        }
    }
}