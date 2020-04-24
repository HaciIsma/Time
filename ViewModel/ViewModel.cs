using System.Windows.Threading;
using PropertyChanged;
using System;

namespace Time.ViewModel
{
    [AddINotifyPropertyChangedInterface]
    public class ViewModel
    {
        public DispatcherTimer _timer;
        public string CurrentTime { get; set; }
        public ViewModel()
        {
            _timer = new DispatcherTimer(DispatcherPriority.Render);
            _timer.Interval = TimeSpan.FromSeconds(1);
            _timer.Tick += (sender, args) =>
            {
                CurrentTime = DateTime.Now.ToLongTimeString();
            };
            _timer.Start();
        }
    }
}
