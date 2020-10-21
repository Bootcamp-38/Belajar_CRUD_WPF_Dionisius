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
    /// Interaction logic for UserControlTransaction.xaml
    /// </summary>
    public partial class UserControlTransaction : UserControl
    {
        MyContext myContext = new MyContext();
        public DateTime dateTime;
        public UserControlTransaction()
        {
            InitializeComponent();
            
            TableTransaction.ItemsSource = myContext.Transactions.ToList();
        }

        private void TableItem_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                object item = TableTransaction.SelectedItem;

                // Memanggil Tabel ke TextBox
                string ID = (TableTransaction.SelectedCells[0].Column.GetCellContent(item) as TextBlock).Text;
                textBoxId.Text = ID;
                string Date = (TableTransaction.SelectedCells[1].Column.GetCellContent(item) as TextBlock).Text;
                textBoxDate.Text = Date;
            }
            catch (Exception)
            {

            }
        }

        private void ButtonInputClick(object sender, RoutedEventArgs e)
        {
            if (textBoxDate.Text == string.Empty)
            {
                MessageBox.Show("Tidak ada data yang dimasukkan", "Peringatan");
                textBoxDate.Focus();
            }
            else
            {
                if(DateTime.TryParse(textBoxDate.Text, out dateTime))
                {
                    String.Format("{0:mm/dd/yyyy}", dateTime);

                    var input = new Transaction(textBoxDate.Text);
                    myContext.Transactions.Add(input);
                    myContext.SaveChanges();

                    MessageBox.Show("Input Berhasil", "Sukses");
                    TableTransaction.ItemsSource = myContext.Transactions.ToList();
                    textBoxId.Clear();
                    textBoxDate.Clear();
                }
                else
                {
                    MessageBox.Show("Invalid Date", "Warning!!!");
                }
            }
        }

        private void ButtonUpdateClick(object sender, RoutedEventArgs e)
        {
            if (textBoxDate.Text == string.Empty)
            {
                MessageBox.Show("Tidak ada data yang dimasukkan", "Peringatan");
                textBoxDate.Focus();
            }
            else
            {
                if (DateTime.TryParse(textBoxDate.Text, out dateTime))
                {
                    int Id = (TableTransaction.SelectedItem as Transaction).Id;
                    Transaction updateTransaction = myContext.Transactions.Where(update => update.Id == Id).Single();

                    String.Format("{0:mm/dd/yyyy}", dateTime);

                    updateTransaction.Date = textBoxDate.Text;

                    myContext.SaveChanges();

                    MessageBox.Show($"Data {textBoxId.Text} Berhasil Update", "Sukses");
                    TableTransaction.ItemsSource = myContext.Transactions.ToList();
                    textBoxId.Clear();
                    textBoxDate.Clear();
                }
                else
                {
                    MessageBox.Show("Invalid Date", "Warning!!!");
                }
            }
        }

        private void ButtonDeleteClick(object sender, RoutedEventArgs e)
        {
            if (textBoxDate.Text == string.Empty)
            {
                MessageBox.Show("Tidak ada data yang dimasukkan", "Peringatan");
                textBoxDate.Focus();
            }
            else
            {
                MessageBoxResult result = MessageBox.Show("Anda Yakin Ingin Menghapus Data???", "Konfirmasi", MessageBoxButton.YesNo, MessageBoxImage.Question);

                if (result == MessageBoxResult.Yes)
                {
                    int Id = (TableTransaction.SelectedItem as Transaction).Id;

                    Transaction deleteTransaction = myContext.Transactions.Where(delete => delete.Id == Id).Single();

                    if(myContext.TransactionItems.Any(a => a.Transaction.Id == Id))
                    {
                        MessageBox.Show("Data sedang digunakan", "WARNING!!!");
                    }
                    else
                    {
                        myContext.Transactions.Remove(deleteTransaction);

                        myContext.SaveChanges();

                        MessageBox.Show($"Data {textBoxId.Text} Dihapus", "Sukses");
                    }
                    TableTransaction.ItemsSource = myContext.Transactions.ToList();
                    textBoxDate.Clear();
                    textBoxId.Clear();

                }
                else
                {
                    TableTransaction.ItemsSource = myContext.Transactions.ToList();
                }
            }

            //if (textBoxDate.Text == string.Empty)
            //{
            //    MessageBox.Show("Tidak ada data yang ingin dihapus", "Peringatan");
            //}
            //else
            //{
            //    MessageBoxResult result = MessageBox.Show("Anda Yakin Ingin Menghapus Data???", "Konfirmasi", MessageBoxButton.YesNo, MessageBoxImage.Question);

            //    if (result == MessageBoxResult.Yes)
            //    {
            //        int Id = (TableItem.SelectedItem as Transaction).Id;

            //        var deleteTransaction = myContext.Transactions.Where(delete => delete.Id == Id).Single();
            //        myContext.Transactions.Remove(deleteTransaction);
            //        myContext.SaveChanges();

            //        MessageBox.Show($"Data {textBoxId.Text} Dihapus", "Sukses");
            //        TableItem.ItemsSource = myContext.Items.ToList();
            //        textBoxId.Clear();
            //        textBoxDate.Clear();
            //    }
            //    else
            //    {
            //        TableItem.ItemsSource = myContext.Items.ToList();
            //    }
            //}
        }

        private void refresh_btn_Click(object sender, RoutedEventArgs e)
        {
            //TableItem.ItemsSource = myContext.Transactions.ToList();
        }
    }
}
