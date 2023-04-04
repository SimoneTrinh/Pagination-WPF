using System;
using System.Windows;

namespace StopWatch_Navigation
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
        }

        private void goToFirstPageButton_Click(object sender, RoutedEventArgs e)
        {
            //if (mainFrame == null)
            //{
            //    mainFrame?.Navigate(new Page1());
            //}

            mainFrame.NavigationService.Navigate(new Uri("Page1.xaml", UriKind.Relative));
        }

        private void goToSecondPageButton_Click(object sender, RoutedEventArgs e)
        {
            //if (mainFrame == null)
            //{
            //    mainFrame?.Navigate(new Page2());
            //}
            mainFrame.NavigationService.Navigate(new Uri("Page2.xaml", UriKind.Relative));

        }
    }
}
