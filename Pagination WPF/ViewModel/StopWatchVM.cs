using System;
using System.Diagnostics;
using System.Windows.Threading;

namespace Pagination_WPF.ViewModel
{
    class StopWatchVM : Utils.NotifyChanged
    {
        private Stopwatch _stopwatch;
        private DispatcherTimer _timer;
        public StopWatchVM()
        {
            _stopwatch = new Stopwatch();
            _timer = new DispatcherTimer();
            _timer.Interval = TimeSpan.FromMilliseconds(1);
            _timer.Tick += Timer_Tick;
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            TimeSpan timeElapsed = _stopwatch.Elapsed;
            StopwatchText = string.Format("{0:00}:{1:00}:{2:00}:{3:00}", timeElapsed.Hours, timeElapsed.Minutes, timeElapsed.Seconds, timeElapsed.Milliseconds);
        }
        private string _stopwatchText;
        public string StopwatchText
        {
            get { return _stopwatchText; }
            set
            {
                _stopwatchText = value;
                OnPropertyChanged("StopwatchText");
            }
        }

        public void Start()
        {
            _stopwatch.Start();
            _timer.Start();
        }

        public void Stop()
        {
            _stopwatch.Stop();
            _timer.Stop();
        }

        public void Reset()
        {
            _stopwatch.Reset();
            StopwatchText = "00:00:00";
        }

    }
}
