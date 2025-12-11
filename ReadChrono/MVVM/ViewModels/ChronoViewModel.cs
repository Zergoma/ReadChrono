using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Windows.Input;
using PropertyChanged;

namespace ReadChrono.MVVM.ViewModels
{
    [AddINotifyPropertyChangedInterface]
    public class ChronoViewModel
    {
        private Stopwatch _stopwatch = new();
        private readonly IDispatcherTimer _timer;
        public int EllapseTime { get; set; }

        public bool IsRunning { get; set; } = false;

        public ICommand StartStopWatch =>
            new Command(() =>
            {
                if(IsRunning is false)
                {
                    EllapseTime = 0;
                    _stopwatch.Start();
                    _timer.Start();
                    IsRunning = true;

                }
                else
                {
                    _stopwatch.Stop();
                    _timer.Stop();
                    EllapseTime = Convert.ToInt32(Math.Round(_stopwatch.Elapsed.TotalSeconds));
                    _stopwatch.Reset();
                    IsRunning = false;
                }
            });

        public ChronoViewModel(IDispatcher dispatcher)
        {
            EllapseTime = 0;

            _timer = dispatcher.CreateTimer();
            _timer.Interval = TimeSpan.FromMilliseconds(200);
            _timer.Tick += OnTick;
        }

        private void OnTick(object? sender, EventArgs e)
        {
            if (IsRunning is false)
            {
                return;
            }

            EllapseTime = Convert.ToInt32(Math.Round(_stopwatch.Elapsed.TotalSeconds));
        }
    }
}
