using Belajar_CRUD_WPF_Dionisius.Context;
using Belajar_CRUD_WPF_Dionisius.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Mail;
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
            if (emailTextBox.Text == string.Empty)
            {
                MessageBox.Show("Email harus diisi", "Warning!", MessageBoxButton.OK);
            }
            else
            {
                if (!myContext.Users.Any(x => x.UserName == emailTextBox.Text))
                {
                    MessageBox.Show("Email anda tidak terdaftar", "Caution!", MessageBoxButton.OK);
                    emailTextBox.Clear();
                    emailTextBox.Focus();
                }
                else
                {
                    Guid id = Guid.NewGuid();
                    string guid = id.ToString();
                    User updateUser = (from m in myContext.Users where m.UserName == emailTextBox.Text select m).FirstOrDefault();

                    updateUser.Password = id.ToString();
                    myContext.SaveChanges();

                    string dateNow = DateTime.Now.ToString();
                    string PasswordText = "Masukkan Token ini pada Layar Anda: " + guid;

                    SmtpClient client = new SmtpClient();
                    client.Port = 587;
                    client.Host = "smtp.gmail.com";
                    client.EnableSsl = true;
                    client.Timeout = 10000;
                    client.DeliveryMethod = SmtpDeliveryMethod.Network;
                    client.UseDefaultCredentials = false;
                    client.Credentials = new System.Net.NetworkCredential("dionisiusyose11@gmail.com", "gmaildion1997");
                    MailMessage mm =
                        new MailMessage("donotreply@gmail.com", emailTextBox.Text
                        , $"Secret Token !!! for {dateNow}", PasswordText);
                    mm.BodyEncoding = UTF8Encoding.UTF8;
                    mm.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;
                    client.Send(mm);

                    MessageBox.Show("Token telah terkirim. Silahkan cek email anda!!!");

                    changePassword change = new changePassword();
                    change.Show();
                    this.Close();

                }
            }
        }
    }
}
