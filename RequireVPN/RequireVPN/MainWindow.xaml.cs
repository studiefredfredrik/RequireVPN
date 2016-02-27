using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace RequireVPN
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static NotifyIcon icon;
        private static bool baloonHasBeenShown = false;

        public MainWindow()
        {
            InitializeComponent();
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
        }

        private void icon_Click(Object sender, EventArgs e)
        {
            this.Show();
            this.WindowState = WindowState.Normal;
            this.ShowInTaskbar = true;
            icon.Visible = false;
            //System.Windows.MessageBox.Show("Thanks for clicking me");
        }

        private void Window_StateChanged(object sender, EventArgs e)
        {
            if (this.WindowState == WindowState.Minimized)
            {
                icon.Visible = true;
                if (!baloonHasBeenShown)
                {
                    icon.ShowBalloonTip(3000);
                    baloonHasBeenShown = true;
                }
                this.ShowInTaskbar = false;
            }
        }
    }
}
