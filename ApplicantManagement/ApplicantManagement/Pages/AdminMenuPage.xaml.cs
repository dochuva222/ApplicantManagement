using ApplicantManagement.DataBase;
using ApplicantManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
    public partial class AdminMenuPage : Page
    {
        public AdminMenuPage()
        {
            InitializeComponent();
            CBSpecialities.ItemsSource = GlobalSettings.DB.Speciality.Where(s => s.IsBudgetForm == true && s.FormOfEducationID == 1).ToList();
        }

        private void bNewApplicant_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new ApplicantAccountPage(new User() { RoleID = 2 }));
        }

        private void bClear_Click(object sender, RoutedEventArgs e)
        {
            CBForms.SelectedIndex = 0;
            CBSpecialities.SelectedItem = null;
            Refresh();
        }
        private void cbSpecialities_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Refresh();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            Refresh();
        }

        private void Refresh()
        {
            if (CBSpecialities == null)
                return;
            var filtred = GlobalSettings.DB.Application.ToList();
            var specialities = GlobalSettings.DB.Speciality.ToList();

            specialities = specialities.Where(s => s.IsBudgetForm == TIBudget.IsSelected).ToList();

            if (CBForms.SelectedIndex == 1)
                specialities = specialities.Where(s => s.FormOfEducationID == 1).ToList();
            if (CBForms.SelectedIndex == 2)
                specialities = specialities.Where(s => s.FormOfEducationID == 2).ToList();

            CBSpecialities.ItemsSource = specialities;

            if (CBSpecialities.SelectedItem != null)
                filtred = filtred.Where(a => a.SpecialityID == (CBSpecialities.SelectedItem as Speciality).ID).ToList();
            if (CBForms.SelectedIndex == 1)
                filtred = filtred.Where(f => f.Speciality.FormOfEducationID == 1).ToList();
            else if(CBForms.SelectedIndex == 2)
                filtred = filtred.Where(f => f.Speciality.FormOfEducationID == 2).ToList();
            if (!string.IsNullOrWhiteSpace(TBFullName.Text))
                filtred = filtred.Where(f => f.User.Name.ToLower().Contains(TBFullName.Text.ToLower()) || f.User.Surname.ToLower().Contains(TBFullName.Text.ToLower()) || f.User.Patronymic.ToLower().Contains(TBFullName.Text.ToLower())).ToList();
            DGBudgetApplications.ItemsSource = filtred.Where(f => f.Speciality.IsBudgetForm == true).ToList();
            DGNotBudgetApplications.ItemsSource = filtred.Where(f => f.Speciality.IsBudgetForm == false).ToList();
        }

        private void TBFullName_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!Regex.IsMatch(e.Text, @"^[а-яА-Я\s]+$"))
                e.Handled = true;
            else
                e.Handled = false;
        }

        private void TBFullName_TextChanged(object sender, TextChangedEventArgs e)
        {
            Refresh();
        }

        private void TabControl_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Refresh();
        }

        private void CBForms_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Refresh();
        }

        private void BCreateApplication_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new ApplicationPage());
        }

        private void BAddSpciality_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new SpecialityPage());
        }
    }
}
