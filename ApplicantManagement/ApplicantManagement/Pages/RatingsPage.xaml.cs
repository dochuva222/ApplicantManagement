using ApplicantManagement.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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
    public partial class RatingsPage : Page
    {
        public RatingsPage()
        {
            InitializeComponent();
            var myApplications = GlobalSettings.DB.Application.Where(a => a.UserID == GlobalSettings.LoggedUser.ID).Select(a => a.Speciality).Select(a => a.ID).ToList();
            LVRatings.ItemsSource = GlobalSettings.DB.Application.Where(a => myApplications.Contains(a.SpecialityID)).OrderByDescending(o => o.AverageScore).ToList();
            CollectionView view = (CollectionView)CollectionViewSource.GetDefaultView(LVRatings.ItemsSource);
            PropertyGroupDescription groupDescription = new PropertyGroupDescription("Speciality");
            view.GroupDescriptions.Add(groupDescription);
        }
    }
}