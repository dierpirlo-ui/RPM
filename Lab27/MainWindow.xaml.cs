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

namespace LabWork27
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            ContentFrame.Navigate(new Pages.MainPage());
            App.CurrentFrame = ContentFrame;
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            App.CurrentFrame.GoBack();
        }

        private void ContentFrame_ContentRendered(object sender, EventArgs e)
        {
            BackButton.Visibility = ContentFrame.CanGoBack ? Visibility.Visible : Visibility.Collapsed;
        }
    }
}