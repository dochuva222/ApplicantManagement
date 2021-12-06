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

namespace ApplicantManagement.Pages
{
    /// <summary>
    /// Interaction logic for ApplicantMenuPage.xaml
    /// </summary>
    public partial class ApplicantMenuPage : Page
    {
        public ApplicantMenuPage()
        {
            InitializeComponent();
            ApplicantFrame.Navigate(new SpecialitiesPage());
        }

        private void bPersonalAccount_Click(object sender, RoutedEventArgs e)
        {

        }

        private void bRatings_Click(object sender, RoutedEventArgs e)
        {
            ApplicantFrame.Navigate(new RatingsPage()); 
        }

        private void bApplication_Click(object sender, RoutedEventArgs e)
        {
            ApplicantFrame.Navigate(new ApplicantApplicationsPage());
        }

        private void BSpecialities_Click(object sender, RoutedEventArgs e)
        {
            ApplicantFrame.Navigate(new SpecialitiesPage());
        }
    }
}
