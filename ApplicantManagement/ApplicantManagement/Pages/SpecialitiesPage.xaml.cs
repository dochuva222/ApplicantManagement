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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ApplicantManagement.Pages
{
    /// <summary>
    /// Interaction logic for SpecialitiesPage.xaml
    /// </summary>
    public partial class SpecialitiesPage : Page
    {
        public SpecialitiesPage()
        {
            InitializeComponent();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            Refresh();
        }

        private void Refresh()
        {
            LVSpecialities.ItemsSource = GlobalSettings.DB.Speciality.ToList();
        }
    }
}
