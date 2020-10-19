using Belajar_CRUD_WPF_Dionisius.Context;
using Belajar_CRUD_WPF_Dionisius.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
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
    /// Interaction logic for Page1.xaml
    /// </summary>
    public partial class Page1 : Window
    {
        int cb_sup;

        MyContext myContext = new MyContext();
        public Page1()
        {
            InitializeComponent();
            TableItem.ItemsSource = myContext.Items.Include("Supplier").ToList();

            var tipe = myContext.Suppliers.ToList();
            comboBoxSupplierId.ItemsSource = tipe;
        }

        public void BindingBox()
        {
            //Item item = (from m in myContext.Items.Include("Supplier") select m).Single();
            var item = (from m in myContext.Suppliers select m.Name);
            //myContext.Items.Include("Supplier").Load();
            comboBoxSupplierId.ItemsSource = item.ToList();

        }

        private void TableItem_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
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
                    int Id = (TableItem.SelectedItem as Item).Id;

                    var deleteSupplier = myContext.Items.Where(delete => delete.Id == Id).Single();
                    myContext.Items.Remove(deleteSupplier);
                    myContext.SaveChanges();

                    MessageBox.Show($"Data {textBoxId.Text} Dihapus", "Sukses");
                    TableItem.ItemsSource = myContext.Items.ToList();
                    textBoxName.Clear();
                    textBoxId.Clear();
                }
                else
                {
                    TableItem.ItemsSource = myContext.Items.ToList();
                }
            }
        }

        private void Supplier_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            main.Show();
            this.Close();
        }

        private void comboBoxSupplierId_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //comboBoxSupplierId.ItemsSource = myContext.Items.Include("Supplier");
        }

        private void Item_Click(object sender, RoutedEventArgs e)
        {
            this.Show();
        }

        private void comboBoxSupplierId_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                cb_sup = Convert.ToInt32(comboBoxSupplierId.SelectedValue.ToString());
            }
            catch(Exception)
            {
                
            }
        }

        private void ListViewItem_MouseEnter(object sender, RoutedEventArgs e)
        {
            // Set tooltip visibility

            if (Tg_btn.IsChecked == true)
            {
                tt_home.Visibility = Visibility.Collapsed;
                tt_contacts.Visibility = Visibility.Collapsed;
            }
            else
            {
                tt_home.Visibility = Visibility.Visible;
                tt_contacts.Visibility = Visibility.Visible;

            }
        }

        private void Tg_Btn_Unchecked(object sender, RoutedEventArgs e)
        {
            //img_bg.Opacity = 1;
            BG.Opacity = 1;
        }

        private void Tg_Btn_Checked(object sender, RoutedEventArgs e)
        {
            //img_bg.Opacity = 0.3;
            BG.Opacity = 0.3;
        }

        private void BG_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Tg_btn.IsChecked = false;
        }

        private void CloseBtn_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Supplier_Selected(object sender, RoutedEventArgs e)
        {
            SupplierMenu page = new SupplierMenu();
            page.Show();
            this.Close();
        }

        private void Item_Selected(object sender, RoutedEventArgs e)
        {
            this.Show();
        }
    }
}
