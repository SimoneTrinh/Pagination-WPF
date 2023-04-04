using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Threading;

namespace StopWatch_Navigation
{
    /// <summary>
    /// Interaction logic for Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {

        private DispatcherTimer timer;
        private TimeSpan elapsedTime;
        public Page1()
        {
            InitializeComponent();

        }

        private void startButton_Click(object sender, RoutedEventArgs e)
        {
            startButton.IsEnabled = false;
            stopButton.IsEnabled = true;

            timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(0.1);
            timer.Tick += timer_Tick;
            timer.Start();
        }

        private void stopButton_Click(object sender, RoutedEventArgs e)
        {
            startButton.IsEnabled = true;
            stopButton.IsEnabled = false;

            if (timer != null)
            {
                timer.Stop();
                timer.Tick -= timer_Tick;
                timer = null;
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            elapsedTime += TimeSpan.FromSeconds(0.1);
            stopwatchText.Text = elapsedTime.ToString(@"hh\:mm\:ss\.f");
        }
    }
}
