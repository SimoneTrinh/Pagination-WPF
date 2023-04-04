using System;
using System.Windows;
using System.Windows.Controls;

namespace Pagination_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            navFrame.Navigate(new Uri("/Pages/Page1.xaml", UriKind.Relative));
        }

        private void sideBar_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var selected = sideBar.SelectedItem as NavButton;
            navFrame.Navigate(selected?.Navlink);
        }
    }
}
