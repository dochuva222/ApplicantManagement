using ApplicantManagement.DataBase;
using ApplicantManagement.Model.Services;
using ApplicantManagement.Models;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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
    /// <summary>
    /// Interaction logic for SpecialityPage.xaml
    /// </summary>
    public partial class SpecialityPage : Page
    {
        Speciality contextSpeciality;
        public SpecialityPage()
        {
            InitializeComponent();
            contextSpeciality = new Speciality();
            DataContext = contextSpeciality;
        }

        private void BSave_Click(object sender, RoutedEventArgs e)
        {
            string errorMessage = "";
            if (string.IsNullOrWhiteSpace(contextSpeciality.Name))
                errorMessage += "Введите название\n";
            if (contextSpeciality.PlaceNumber == 0)
                errorMessage += "Введите кол-во мест\n";
            if (!string.IsNullOrWhiteSpace(errorMessage))
            {
                MessageBox.Show(errorMessage, "Неверные данные");
                return;
            }
            if (RBForm.IsChecked == true)
                contextSpeciality.FormOfEducationID = 1;
            else
                contextSpeciality.FormOfEducationID = 2;
            contextSpeciality.IsBudgetForm = RBBase.IsChecked.Value;
            if (contextSpeciality.ID == 0)
                GlobalSettings.DB.Speciality.Add(contextSpeciality);
            GlobalSettings.DB.SaveChanges();
            NavigationService.GoBack();
        }

        private void BCancel_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void StringTextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!Regex.IsMatch(e.Text, @"^[а-яА-Я]+$"))
                e.Handled = true;
            else
                e.Handled = false;
        }

        private void BChangePhoto_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new OpenFileDialog() { Filter = ".png, .jpg, .jpeg| *.png; *.jpg; *.jpeg" };
            if (dialog.ShowDialog().GetValueOrDefault())
            {
                contextSpeciality.Image = File.ReadAllBytes(dialog.FileName);
                SpecialityImage.Source = Tools.BytesToImage(contextSpeciality.Image);
            }
        }

        private void TextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!Regex.IsMatch(e.Text, @"^[0-9]+$"))
                e.Handled = true;
            else
                e.Handled = false;
        }
    }
}
