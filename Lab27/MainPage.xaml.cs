using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace LabWork27.Pages
{
    /// <summary>
    /// Логика взаимодействия для MainPage.xaml
    /// </summary>
    public partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void AuthorizationButton_Click(object sender, RoutedEventArgs e)
        {
            App.CurrentFrame.Navigate(new Pages.AuthorizationPage());
        }

        private void RegistrationButton_Click(object sender, RoutedEventArgs e)
        {
            App.CurrentFrame.Navigate(new Pages.RegistrationPage());
        }

        private void SettingsButton_Click(object sender, RoutedEventArgs e)
        {
            App.CurrentFrame.Navigate(new Pages.SettingsPage());
        }
    }
}
