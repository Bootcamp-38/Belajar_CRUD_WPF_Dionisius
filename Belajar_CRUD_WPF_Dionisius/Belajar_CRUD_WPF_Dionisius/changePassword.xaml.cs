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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Belajar_CRUD_WPF_Dionisius
{
    /// <summary>
    /// Interaction logic for changePassword.xaml
    /// </summary>
    public partial class changePassword : Window
    {
        MyContext myContext = new MyContext();
        public changePassword()
        {
            InitializeComponent();
        }

        private void changePassButton_Click(object sender, RoutedEventArgs e)
        {
            string userName = textBoxEmail.Text;
            string tokenBox = textBoxToken.Password;

            if (myContext.Users.Any(a => a.UserName == userName)){
                var passChange = myContext.Users.Where(m => m.UserName == userName).Single();
                if(passChange.Password == tokenBox)
                {
                    if(textBoxNewPassword.Password == textBoxConfirm.Password)
                    {
                        passChange.Password = textBoxNewPassword.Password;
                        myContext.SaveChanges();
                        MessageBox.Show("Password berhasil diganti");
                        LoginWindow login = new LoginWindow();
                        login.Show();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Please confirm your new password");
                        textBoxNewPassword.Clear();
                        textBoxConfirm.Clear();
                    }
                }
                else
                {
                    MessageBox.Show(tokenBox + passChange.Password);
                    //MessageBox.Show(passChange.Password);
                    MessageBox.Show("Token Wrong!!! Please Check your Email");
                }
            }
            else
            {
                MessageBox.Show("Wrong Username");
            }
        }
    }
}
