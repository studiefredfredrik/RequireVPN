using System;
using System.Windows.Media;
using System.Linq;
using System.Net.NetworkInformation;
using System.Timers;

namespace RequireVPN
{
    class AdapterWatcher
    {
        public static NetworkInterface adapter;
        private static Timer timer;
        private static MainWindow reportBackWindow;

        public static bool StartWatching(MainWindow sender)
        {
            if(adapter != null)
            {
                reportBackWindow = sender;
                reportBackWindow.txt_status.Text = "Watcher running...";
                timer = new Timer(1000);
                timer.Elapsed += new ElapsedEventHandler(timer_Elapsed);
                timer.Enabled = true;
            }
            return false;
        }

        public static bool StopWatching()
        {
            reportBackWindow.txt_status.Text = "Stopped by user";
            timer.Enabled = false;
            return true;
        }

        static void timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            if(NetworkInterface.GetAllNetworkInterfaces().First(net => net.Id == adapter.Id).OperationalStatus != OperationalStatus.Up)
            { 
                if(AppTerminator.KillApp())
                {
                    reportBackWindow.Dispatcher.Invoke((Action)(() => {
                        reportBackWindow.txt_status.Text = "Stopped - Application killed";
                        reportBackWindow.txt_status.Background = Brushes.Green;
                    }));
                }
                else
                {
                    {
                        reportBackWindow.Dispatcher.Invoke((Action)(() => {
                            reportBackWindow.txt_status.Text = "Stopped - Application killed w/exception";
                            reportBackWindow.txt_status.Background = Brushes.Yellow;
                        }));
                    }
                }
                timer.Enabled = false;
            }
        }
    }
}
