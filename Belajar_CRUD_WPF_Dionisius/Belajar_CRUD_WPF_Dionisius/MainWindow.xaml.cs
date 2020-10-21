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
        UserControlSupplier UCSup = new UserControlSupplier();
        UserControlItem UCItem = new UserControlItem();
        UserControlTransaction UCTrans = new UserControlTransaction();
        public MainWindow()
        {
            InitializeComponent();
            // Menampilkan DATA GRID
            BG.Children.Add(UCSup);
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
            Application.Current.Shutdown();
        }

        private void Supplier_Selected(object sender, RoutedEventArgs e)
        {
            if (BG.Children.Contains(UCSup))
            {
                BG.Children.Remove(UCSup);
                BG.Children.Add(UCSup);
            }
            else
            {
                BG.Children.Remove(UCItem);
                BG.Children.Remove(UCTrans);
                BG.Children.Add(UCSup);
            }
        }

        private void Item_Selected(object sender, RoutedEventArgs e)
        {
            if (BG.Children.Contains(UCItem))
            {
                BG.Children.Remove(UCItem);
                BG.Children.Add(UCItem);
            }
            else
            {
                BG.Children.Remove(UCSup);
                BG.Children.Remove(UCTrans);
                BG.Children.Add(UCItem);
            }
        }

        private void Trans_Selected(object sender, RoutedEventArgs e)
        {
            if (BG.Children.Contains(UCTrans))
            {
                BG.Children.Remove(UCTrans);
                BG.Children.Add(UCTrans);
            }
            else
            {
                BG.Children.Remove(UCSup);
                BG.Children.Remove(UCItem);
                BG.Children.Add(UCTrans);
            }
        }

        private void logout_btn_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Anda Yakin Ingin Logout", "Konfirmasi", MessageBoxButton.YesNo, MessageBoxImage.Question);

            if (result == MessageBoxResult.Yes)
            {
                result = MessageBox.Show("Yakin???", "Konfirmasi", MessageBoxButton.YesNo, MessageBoxImage.Question);
                if(result == MessageBoxResult.Yes)
                {
                    LoginWindow login = new LoginWindow();
                    login.Show();
                    this.Close();
                }
                else { }
            }
            else
            {
                
            }
        }

    }
}