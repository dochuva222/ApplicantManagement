using ApplicantManagement.Models;
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

namespace ApplicantManagement
{
    /// <summary>
    /// Interaction logic for LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        public LoginWindow()
        {
            InitializeComponent();
        }

        private void bLogin_Click(object sender, RoutedEventArgs e)
        {
            var loggedUser = GlobalSettings.DB.User.FirstOrDefault(u => u.Login == tbLogin.Text);
            if (loggedUser == null || loggedUser.Password != pbPassword.Password)
            {
                MessageBox.Show("Неверный логин или пароль");
                return;
            }
            GlobalSettings.LoggedUser = loggedUser;
            new MainWindow(loggedUser).Show();
            this.Close();
                
        }

        private void BLogout_Click(object sender, RoutedEventArgs e)
        {
            App.Current.Shutdown();
        }
    }
}
