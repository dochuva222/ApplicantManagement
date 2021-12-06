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
    /// Interaction logic for ApplicationPage.xaml
    /// </summary>
    public partial class ApplicationPage : Page
    {
        DataBase.Application contextApplicaiton = new DataBase.Application();
        public ApplicationPage()
        {
            InitializeComponent();
            DataContext = contextApplicaiton;
            CBSpecialities.ItemsSource = GlobalSettings.DB.Speciality.Where(s => s.FormOfEducationID == 1 && s.IsBudgetForm == true).ToList();
            CBUsers.ItemsSource = GlobalSettings.DB.User.Where(u => u.RoleID == 2).ToList();
        }

        private void BSave_Click(object sender, RoutedEventArgs e)
        {
            string errorMessage = "";
            if (contextApplicaiton.User == null)
                errorMessage += "Выберите абитуриента\n";
            if (contextApplicaiton.AverageScore == 0)
                errorMessage += "Введите средний балл аттестата\n";
            if (contextApplicaiton.Speciality == null)
                errorMessage += "Выберите специальность\n";
            if (!string.IsNullOrWhiteSpace(errorMessage))
            {
                MessageBox.Show(errorMessage, "Неверные данные");
                return;
            }
            contextApplicaiton.Date = DateTime.Now;
            GlobalSettings.DB.Application.Add(contextApplicaiton);
            GlobalSettings.DB.SaveChanges();
            NavigationService.GoBack();
        }

        private void BCancel_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            if (CBSpecialities != null)
            {
                CBSpecialities.SelectedItem = null;
                Refresh();
            }
        }

        private void Refresh()
        {
            var specialities = GlobalSettings.DB.Speciality.ToList();
            if (RBBase1.IsChecked == true)
                specialities = specialities.Where(s => s.IsBudgetForm == true).ToList();
            else
                specialities = specialities.Where(s => s.IsBudgetForm == false).ToList();
            if (RBForm1.IsChecked == true)
                specialities = specialities.Where(s => s.FormOfEducationID == 1).ToList();
            else
                specialities = specialities.Where(s => s.FormOfEducationID == 2).ToList();
            CBSpecialities.ItemsSource = specialities;
        }
    }
}
