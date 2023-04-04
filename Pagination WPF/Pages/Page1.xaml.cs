using Pagination_WPF.ViewModel;
using System.Windows;
using System.Windows.Controls;

namespace Pagination_WPF.Pages
{
    /// <summary>
    /// Interaction logic for Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {
        private StopWatchVM _stopWatchVM;
        public Page1()
        {
            InitializeComponent();
            _stopWatchVM = new StopWatchVM();
            DataContext = _stopWatchVM;
        }

        private void StartButton_Click(object sender, RoutedEventArgs e)
        {
            _stopWatchVM.Start();
        }

        private void StopButton_Click(object sender, RoutedEventArgs e)
        {
            _stopWatchVM.Stop();
        }

        private void ResetButton_Click(object sender, RoutedEventArgs e)
        {
            _stopWatchVM.Reset();
        }
    }
}
