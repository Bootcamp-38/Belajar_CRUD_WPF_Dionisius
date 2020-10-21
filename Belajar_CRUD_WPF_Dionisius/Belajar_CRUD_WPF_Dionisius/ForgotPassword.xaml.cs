using Belajar_CRUD_WPF_Dionisius.Context;
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
    /// Interaction logic for ForgotPassword.xaml
    /// </summary>
    public partial class ForgotPassword : Window
    {
        MyContext myContext = new MyContext();
        public ForgotPassword()
        {
            InitializeComponent();
        }

        private void submitEmailButton_Click(object sender, RoutedEventArgs e)
        {
            Guid newGuid = Guid.NewGuid();
            

            string usernameCheck = textBoxEmail.Text;

            if(myContext.Users.Any(a => a.UserName == usernameCheck))
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
