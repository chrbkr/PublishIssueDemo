using ProjectB;
using System.Windows;

namespace ProjectA
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ConfigReader configReader;

        public MainWindow()
        {
            InitializeComponent();
            DummyLabel.Content = "Hello";
        }

        private void ShowEndpoint(object sender, RoutedEventArgs e)
        {
            configReader = new ConfigReader();
            DummyLabel.Content = configReader.GetEndpoint();
        }
    }
}
