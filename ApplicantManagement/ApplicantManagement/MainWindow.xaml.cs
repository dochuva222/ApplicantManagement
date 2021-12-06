using ApplicantManagement.DataBase;
using ApplicantManagement.Pages;
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

namespace ApplicantManagement
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
       
        public MainWindow(User loggedUser)
        {
            InitializeComponent();
            if (loggedUser.RoleID == 1)
                MainFrame.Navigate(new AdminMenuPage());
            else
                MainFrame.Navigate(new ApplicantMenuPage());
        }
    }
}
