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
using System.Windows.Shapes;

namespace Belajar_CRUD_WPF_Dionisius
{
    /// <summary>
    /// Interaction logic for LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        MyContext myContext = new MyContext();
        public LoginWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(emailTextBox.Text == string.Empty && passwordTextBox.Password == string.Empty)
            {
                MessageBox.Show("Anda belum memasukkan username dan password");
            }
            else if(emailTextBox.Text == string.Empty)
            {
                passwordTextBox.Clear();
                MessageBox.Show("Masukkan Email");
            }
            else if (passwordTextBox.Password == string.Empty)
            {
                emailTextBox.Clear();
                MessageBox.Show("Masukkan Password");
            }
            else
            {
                User user = myContext.Users.Where(check => check.UserName == emailTextBox.Text).Single();
                if(user.UserName == emailTextBox.Text && user.Password == passwordTextBox.Password)
                {
                    MainWindow main = new MainWindow();
                    main.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Username atau Password yang anda masukkan salah");
                    passwordTextBox.Clear();
                }
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            App.Current.Shutdown();
        }

        private void forgot_btn_Click(object sender, RoutedEventArgs e)
        {
            //App.Current.Shutdown();
            //BG.Opacity = 0.3;
            //login_btn.IsEnabled = false;
            //passwordTextBox.IsEnabled = false;
            //emailTextBox.IsEnabled = false;

            Guid newGuid = Guid.NewGuid();

            string usernameCheck = emailTextBox.Text;

            if (myContext.Users.Any(a => a.UserName == usernameCheck))
            {
                var passChange = myContext.Users.Where(m => m.UserName == usernameCheck).Single();
                passChange.Password = newGuid.ToString();
                myContext.SaveChanges();

                MessageBox.Show("Token telah terkirim. Silahkan cek email anda!!!");

                changePassword change = new changePassword();
                change.Show();
                this.Close();

            }
            else
            {
                MessageBox.Show($"Username yang anda masukkan salah");
            }
        }
    }
}
