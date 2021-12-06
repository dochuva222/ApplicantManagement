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
    public partial class ApplicantApplicationsPage : Page
    {
        public ApplicantApplicationsPage()
        {
            InitializeComponent();
            DGApplications.ItemsSource = GlobalSettings.DB.Application.Where(a => a.UserID == GlobalSettings.LoggedUser.ID).ToList();
        }
    }
}
