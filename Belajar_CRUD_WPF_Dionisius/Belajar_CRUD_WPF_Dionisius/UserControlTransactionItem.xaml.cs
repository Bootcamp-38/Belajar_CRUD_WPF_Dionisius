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
    /// Interaction logic for UserControlTransactionItem.xaml
    /// </summary>
    public partial class UserControlTransactionItem : UserControl
    {
        MyContext myContext = new MyContext();
        int cb_item, cb_trans;
        public UserControlTransactionItem()
        {
            InitializeComponent();
            TableTi.ItemsSource = myContext.TransactionItems.ToList();
            textBoxId.IsEnabled = false;
            comboBoxUpdate();
        }

        public void comboBoxUpdate()
        {
            var showItem = myContext.Items.ToList();
            var showTrans = myContext.Transactions.ToList();
            var itemShow = myContext.Items.First();
            myContext.Entry(itemShow).Reload();
            comboBoxItemId.ItemsSource = showItem;
            var transShow = myContext.Transactions.First();
            myContext.Entry(transShow).Reload();
            comboBoxTransactionId.ItemsSource = showTrans;
        }

        private void TableItem_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            comboBoxUpdate();

            try
            {
                object item = TableTi.SelectedItem;

                // Memanggil Tabel ke TextBox
                string ID = (TableTi.SelectedCells[0].Column.GetCellContent(item) as TextBlock).Text;
                textBoxId.Text = ID;
                string Quantity = (TableTi.SelectedCells[1].Column.GetCellContent(item) as TextBlock).Text;
                textBoxQuantity.Text = Quantity;
                string ItemId = (TableTi.SelectedCells[2].Column.GetCellContent(item) as TextBlock).Text;
                comboBoxItemId.Text = ItemId;
                string TransId = (TableTi.SelectedCells[3].Column.GetCellContent(item) as TextBlock).Text;
                comboBoxTransactionId.Text = TransId;


            }
            catch (Exception)
            {

            }
        }



        private void ButtonInputClick(object sender, RoutedEventArgs e)
        {
            comboBoxUpdate();

            if (textBoxQuantity.Text == string.Empty || comboBoxItemId.SelectedItem == null || comboBoxTransactionId.SelectedItem == null)
            {
                MessageBox.Show("Tidak ada data yang dimasukkan", "Peringatan");
                textBoxQuantity.Focus();
            }
            else
            {
                var itemNameInput = myContext.Items.Where(m => m.Id == cb_item).FirstOrDefault();
                var transactionInput = myContext.Transactions.Where(a => a.Id == cb_trans).FirstOrDefault();
                var input = new TransactionItem(Convert.ToInt32(textBoxQuantity.Text), itemNameInput, transactionInput);

                myContext.TransactionItems.Add(input);
                myContext.SaveChanges();

                MessageBox.Show("Input Berhasil", "Sukses");
                TableTi.ItemsSource = myContext.TransactionItems.ToList();
                textBoxQuantity.Clear();
                comboBoxItemId.SelectedItem = null;
                comboBoxTransactionId.SelectedItem = null;
            }
        }

        private void ButtonUpdateClick(object sender, RoutedEventArgs e)
        {
            comboBoxUpdate();
            if (textBoxQuantity.Text == string.Empty || textBoxId.Text == string.Empty)
            {
                MessageBox.Show("Pilih Data Terlebih Dahulu", "Peringatan");
            }
            else
            {
                int Id = (TableTi.SelectedItem as TransactionItem).Id;

                TransactionItem updateTi = (from m in myContext.TransactionItems where m.Id == Id select m).Single();
                var itemInput = myContext.Items.Where(a => a.Id == cb_item).FirstOrDefault();
                var transInput = myContext.Transactions.Where(b => b.Id == cb_trans).FirstOrDefault();

                updateTi.Number = Convert.ToInt32(textBoxQuantity.Text);
                updateTi.Item = itemInput;
                updateTi.Transaction = transInput;

                myContext.SaveChanges();

                MessageBox.Show($"Data {textBoxId.Text} Berhasil Update", "Sukses");
                TableTi.ItemsSource = myContext.TransactionItems.ToList();
                textBoxQuantity.Clear();
                textBoxId.Clear();
                comboBoxItemId.SelectedItem = null;
                comboBoxTransactionId.SelectedItem = null;
            }
        }

        private void ButtonDeleteClick(object sender, RoutedEventArgs e)
        {
            comboBoxUpdate();

            if (textBoxQuantity.Text == string.Empty || textBoxId.Text == string.Empty)
            {
                MessageBox.Show("Tidak ada data yang ingin dihapus", "Peringatan");
            }
            else
            {
                MessageBoxResult result = MessageBox.Show("Anda Yakin Ingin Menghapus Data???", "Konfirmasi", MessageBoxButton.YesNo, MessageBoxImage.Question);

                if (result == MessageBoxResult.Yes)
                {
                    int Id = (TableTi.SelectedItem as TransactionItem).Id;

                    var deleteTi = myContext.TransactionItems.Where(delete => delete.Id == Id).Single();
                    myContext.TransactionItems.Remove(deleteTi);
                    myContext.SaveChanges();

                    MessageBox.Show($"Data {textBoxId.Text} Dihapus", "Sukses");
                    TableTi.ItemsSource = myContext.TransactionItems.ToList();
                    textBoxQuantity.Clear();
                    textBoxId.Clear();
                    comboBoxItemId.SelectedItem = null;
                    comboBoxTransactionId.SelectedItem = null;
                }
                else
                {
                    TableTi.ItemsSource = myContext.TransactionItems.ToList();
                }
            }
        }



        private void comboBoxItemId_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                cb_item = Convert.ToInt32(comboBoxItemId.SelectedValue.ToString());
            }
            catch (Exception)
            {

            }
        }

        private void comboBoxTransId_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                cb_trans = Convert.ToInt32(comboBoxTransactionId.SelectedValue.ToString());
            }
            catch (Exception)
            {

            }
        }

        private void refresh_btn_Click(object sender, RoutedEventArgs e)
        {
            TableTi.ItemsSource = myContext.TransactionItems.ToList();

            comboBoxUpdate();
        }
    }
}
