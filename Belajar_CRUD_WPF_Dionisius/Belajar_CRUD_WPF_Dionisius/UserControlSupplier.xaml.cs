using Belajar_CRUD_WPF_Dionisius.Context;
using Belajar_CRUD_WPF_Dionisius.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
    /// Interaction logic for UserControlSupplier.xaml
    /// </summary>
    public partial class UserControlSupplier : UserControl
    {
        MyContext myContext = new MyContext();
        public UserControlSupplier()
        {
            InitializeComponent();
        }

        private void ButtonInputClick(object sender, RoutedEventArgs e)
        {
            if (textBoxName.Text == string.Empty)
            {
                MessageBox.Show("Tidak ada data yang dimasukkan", "Peringatan");
                textBoxName.Focus();

            }
            else
            {
                var input = new Supplier(textBoxName.Text);
                myContext.Suppliers.Add(input);
                myContext.SaveChanges();

                MessageBox.Show("Input Berhasil", "Sukses");
                TableSupplier.ItemsSource = myContext.Suppliers.ToList();
                textBoxName.Clear();
            }

        }

        private void ButtonUpdateClick(object sender, RoutedEventArgs e)
        {
            if (textBoxName.Text == string.Empty || textBoxId.Text == string.Empty)
            {
                MessageBox.Show("Pilih Data Terlebih Dahulu", "Peringatan");
            }
            else
            {
                int Id = (TableSupplier.SelectedItem as Supplier).Id;

                Supplier updateSupplier = myContext.Suppliers.Where(update => update.Id == Id).Single();

                updateSupplier.Name = textBoxName.Text;
                myContext.SaveChanges();

                MessageBox.Show($"Data {textBoxId.Text} Berhasil Update", "Sukses");
                TableSupplier.ItemsSource = myContext.Suppliers.ToList();
                textBoxName.Clear();
                textBoxId.Clear();
            }
        }

        private void ButtonDeleteClick(object sender, RoutedEventArgs e)
        {
            if (textBoxName.Text == string.Empty || textBoxId.Text == string.Empty)
            {
                MessageBox.Show("Tidak ada data yang ingin dihapus", "Peringatan");
            }
            else
            {
                MessageBoxResult result = MessageBox.Show("Anda Yakin Ingin Menghapus Data???", "Konfirmasi", MessageBoxButton.YesNo, MessageBoxImage.Question);

                if (result == MessageBoxResult.Yes)
                {
                    int Id = (TableSupplier.SelectedItem as Supplier).Id;

                    var deleteSupplier = myContext.Suppliers.Where(delete => delete.Id == Id).Single();
                    myContext.Suppliers.Remove(deleteSupplier);
                    myContext.SaveChanges();

                    MessageBox.Show($"Data {textBoxId.Text} Dihapus", "Sukses");
                    TableSupplier.ItemsSource = myContext.Suppliers.ToList();
                    textBoxName.Clear();
                    textBoxId.Clear();
                }
                else
                {
                    TableSupplier.ItemsSource = myContext.Suppliers.ToList();
                }
            }
        }

        private void textBoxName_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^a-zA-Z]+$");
            e.Handled = regex.IsMatch(e.Text);
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
    }
}
