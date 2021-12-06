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
    public partial class ApplicantAccountPage : Page
    {
        User contextUser;
        public ApplicantAccountPage(User postUser)
        {
            InitializeComponent();
            contextUser = postUser;
            DataContext = contextUser;
            CBGenders.ItemsSource = GlobalSettings.DB.Gender.ToList();
            
        }

        private void BSave_Click(object sender, RoutedEventArgs e)
        {
            string errorMessage = "";
            if (string.IsNullOrWhiteSpace(contextUser.Surname))
                errorMessage += "Введите фамилию\n";
            if (string.IsNullOrWhiteSpace(contextUser.Name))
                errorMessage += "Введите имя\n";
            if (string.IsNullOrWhiteSpace(contextUser.Patronymic))
                errorMessage += "Введите отчество\n";
            if (string.IsNullOrWhiteSpace(contextUser.Login))
                errorMessage += "Введите логин\n";
            if (string.IsNullOrWhiteSpace(contextUser.Password))
                errorMessage += "Введите пароль\n";
            if (contextUser.Gender == null)
                errorMessage += "Выберите пол\n";
            if (!string.IsNullOrWhiteSpace(errorMessage))
            {
                MessageBox.Show(errorMessage, "Неверные данные");
                return;
            }
            if (contextUser.ID == 0)
                GlobalSettings.DB.User.Add(contextUser);
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
                contextUser.Image = File.ReadAllBytes(dialog.FileName);
                ImageUser.Source = Tools.BytesToImage(contextUser.Image);
            }
        }
    }
}
