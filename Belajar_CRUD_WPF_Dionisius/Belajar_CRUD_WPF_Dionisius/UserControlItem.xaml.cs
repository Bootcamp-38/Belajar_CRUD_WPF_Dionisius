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
    /// Interaction logic for UserControlItem.xaml
    /// </summary>
    public partial class UserControlItem : UserControl
    {
        MyContext myContext = new MyContext();
        int cb_sup;
        public UserControlItem()
        {
            InitializeComponent();

            TableItem.ItemsSource = myContext.Items.ToList();

            textBoxId.IsEnabled = false;

            comboBoxUpdate();

        }

        public void comboBoxUpdate()
        {
            var tipe = myContext.Suppliers.ToList();
            var supId = myContext.Suppliers.First();
            myContext.Entry(supId).Reload();
            comboBoxSupplierId.ItemsSource = tipe;
        }

        private void TableItem_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            comboBoxUpdate();
            
            try
            {
                object item = TableItem.SelectedItem;

                // Memanggil Tabel ke TextBox
                string ID = (TableItem.SelectedCells[0].Column.GetCellContent(item) as TextBlock).Text;
                textBoxId.Text = ID;
                string Name = (TableItem.SelectedCells[1].Column.GetCellContent(item) as TextBlock).Text;
                textBoxName.Text = Name;
                string SupId = (TableItem.SelectedCells[2].Column.GetCellContent(item) as TextBlock).Text;
                comboBoxSupplierId.Text = SupId;
                string Price = (TableItem.SelectedCells[4].Column.GetCellContent(item) as TextBlock).Text;
                textBoxPrice.Text = Price;
                string Stock = (TableItem.SelectedCells[3].Column.GetCellContent(item) as TextBlock).Text;
                textBoxStock.Text = Stock;

            }
            catch (Exception)
            {

            }
        }

        private void ButtonInputClick(object sender, RoutedEventArgs e)
        {
            comboBoxUpdate();

            if (textBoxName.Text == string.Empty || comboBoxSupplierId.SelectedItem == null)
            {
                MessageBox.Show("Tidak ada data yang dimasukkan", "Peringatan");
                textBoxName.Focus();

            }
            else
            {
                //string InputSupName = comboBoxSupplierId.SelectedItem.ToString();
                //var SupplyName = (from m in myContext.Items.Include("Supplier") where m.Supplier.Name == InputSupName select m.Id).Single();
                //MessageBox.Show(SupplyName);

                //Item updateSupplier = (from m in myContext.Items where m.Id == Id select m).Single();
                var suppliernameInput = myContext.Suppliers.Where(m => m.Id == cb_sup).FirstOrDefault();
                var input = new Item(textBoxName.Text, Convert.ToInt32(textBoxPrice.Text), Convert.ToInt32(textBoxStock.Text), suppliernameInput);

                myContext.Items.Add(input);
                myContext.SaveChanges();

                MessageBox.Show("Input Berhasil", "Sukses");
                TableItem.ItemsSource = myContext.Items.ToList();
                textBoxName.Clear();
                textBoxPrice.Clear();
                textBoxStock.Clear();
                comboBoxSupplierId.SelectedItem = null;
            }
        }

        private void ButtonUpdateClick(object sender, RoutedEventArgs e)
        {
            comboBoxUpdate();

            if (textBoxName.Text == string.Empty || textBoxId.Text == string.Empty)
            {
                MessageBox.Show("Pilih Data Terlebih Dahulu", "Peringatan");
            }
            else
            {
                int Id = (TableItem.SelectedItem as Item).Id;

                Item updateSupplier = (from m in myContext.Items where m.Id == Id select m).Single();
                var suppliernameInput = myContext.Suppliers.Where(m => m.Id == cb_sup).FirstOrDefault();
                //var Supplier2 = myContext.Suppliers.Where(m => )

                updateSupplier.Name = textBoxName.Text;
                updateSupplier.Supplier = suppliernameInput;
                updateSupplier.Stock = Convert.ToInt32(textBoxStock.Text);
                updateSupplier.Price = Convert.ToInt32(textBoxPrice.Text);
                //updateSupplier.Supplier = comboBoxSupplierId.SelectedItem.ToString();
                myContext.SaveChanges();

                MessageBox.Show($"Data {textBoxId.Text} Berhasil Update", "Sukses");
                TableItem.ItemsSource = myContext.Items.ToList();
                textBoxName.Clear();
                textBoxId.Clear();
                textBoxPrice.Clear();
                textBoxStock.Clear();
                comboBoxSupplierId.SelectedItem = null;
            }
        }

        private void ButtonDeleteClick(object sender, RoutedEventArgs e)
        {
            comboBoxUpdate();

            if (textBoxName.Text == string.Empty || textBoxId.Text == string.Empty)
            {
                MessageBox.Show("Tidak ada data yang ingin dihapus", "Peringatan");
            }
            else
            {
                MessageBoxResult result = MessageBox.Show("Anda Yakin Ingin Menghapus Data???", "Konfirmasi", MessageBoxButton.YesNo, MessageBoxImage.Question);

                if (result == MessageBoxResult.Yes)
                {
                    int Id = (TableItem.SelectedItem as Item).Id;

                    var deleteSupplier = myContext.Items.Where(delete => delete.Id == Id).Single();
                    myContext.Items.Remove(deleteSupplier);
                    myContext.SaveChanges();

                    MessageBox.Show($"Data {textBoxId.Text} Dihapus", "Sukses");
                    TableItem.ItemsSource = myContext.Items.ToList();
                    textBoxName.Clear();
                    textBoxId.Clear();
                    textBoxPrice.Clear();
                    textBoxStock.Clear();
                    comboBoxSupplierId.SelectedItem = null;
                }
                else
                {
                    TableItem.ItemsSource = myContext.Items.ToList();
                }
            }
        }
        private void textBoxName_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^a-zA-Z0-9]+$");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void comboBoxSupplierId_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                cb_sup = Convert.ToInt32(comboBoxSupplierId.SelectedValue.ToString());
            }
            catch (Exception)
            {

            }
        }

        private void refresh_btn_Click(object sender, RoutedEventArgs e)
        {
            TableItem.ItemsSource = myContext.Items.ToList();

            comboBoxUpdate();
        }
    }
}
