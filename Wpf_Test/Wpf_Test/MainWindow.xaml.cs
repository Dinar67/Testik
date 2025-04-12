using System.Windows;
using Wpf_Test.Pages;

namespace Wpf_Test
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Navigation.MainFrame = MyFrame;

            Navigation.MainFrame.Navigate(new MainPage());
        }
    }
}
