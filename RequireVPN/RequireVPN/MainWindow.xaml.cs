using System;
using System.Diagnostics;
using System.Linq;
using System.Net.NetworkInformation;
using System.Windows;
using System.Windows.Forms;
using System.Windows.Media;

namespace RequireVPN
{
    public partial class MainWindow : Window
    {
        public static NotifyIcon icon;
        private static bool baloonHasBeenShown = false;
        private AppTerminator appTerminator = new AppTerminator();

        public MainWindow()
        {
            InitializeComponent();
            try
            {
                ApplicationSettings settings = SettingsHandler.GetApplicationSetting();
                if(Process.GetProcessesByName(settings.processName).Any())
                    AppTerminator.selectedProcess = Process.GetProcessesByName(settings.processName).First();
                if(NetworkInterface.GetAllNetworkInterfaces().Any(s => s.Name == settings.adapterName))
                    AdapterWatcher.adapter = NetworkInterface.GetAllNetworkInterfaces().First(s => s.Name == settings.adapterName);
                UpdateTextboxStatus();
            }
            catch(Exception)
            {
            }
            Properties.Settings.Default.Save();

            Loaded += MainWindow_Loaded;
        }

        void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            MainWindow.icon = new NotifyIcon();
            icon.Click += new EventHandler(icon_Click);
            icon.Icon = new System.Drawing.Icon(RequireVPN.Properties.Resources.rvpnTray, new System.Drawing.Size(128, 128));
            icon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info; //Shows the info icon so the user doesn't thing there is an error.
            icon.BalloonTipText = "rVPN is running in the background";
            icon.BalloonTipTitle = "rVPN";
            icon.Text = "rVPN";
            txt_adapter.IsReadOnly = true;
            txt_process.IsReadOnly = true;
        }

        private void icon_Click(Object sender, EventArgs e)
        {
            this.Show();
            this.WindowState = WindowState.Normal;
            this.ShowInTaskbar = true;
            icon.Visible = false;
        }

        private void Window_StateChanged(object sender, EventArgs e)
        {
            if (this.WindowState == WindowState.Minimized)
            {
                icon.Visible = true;
                if (!baloonHasBeenShown)
                {
                    icon.ShowBalloonTip(500);
                    baloonHasBeenShown = true;
                }
                this.ShowInTaskbar = false;
            }
        }

        private void btn_configure_Click(object sender, RoutedEventArgs e)
        {
            SetupWindow setup = new SetupWindow();
            setup.ShowDialog();
            UpdateTextboxStatus();
        }

        private void btn_start_Click(object sender, RoutedEventArgs e)
        {
            AdapterWatcher.StartWatching(this);
        }

        private void UpdateTextboxStatus()
        {
            if (AppTerminator.selectedProcess != null)
            {
                txt_process.Text = AppTerminator.selectedProcess.ProcessName;
                txt_process.Background = Brushes.Green;
            }
            else
            {
                txt_process.Text = "none";
                txt_process.Background = Brushes.White;
            }


            if (AdapterWatcher.adapter != null)
            {
                txt_adapter.Text = AdapterWatcher.adapter.Name;
                txt_adapter.Background = Brushes.Green;
            }
            else
            {
                txt_adapter.Text = "none";
                txt_adapter.Background = Brushes.White;
            }
        }
    }
}