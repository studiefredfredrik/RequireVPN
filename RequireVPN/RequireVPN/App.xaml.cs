using System;
using System.Windows;
using System.Windows.Forms;
//using NotifyIcon = System.Windows.Forms.NotifyIcon;

namespace RequireVPN
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : System.Windows.Application
    {
        public static NotifyIcon icon;

        protected override void OnStartup(StartupEventArgs e)
        {
            App.icon = new NotifyIcon();
            icon.Click += new EventHandler(icon_Click);
            icon.Icon = new System.Drawing.Icon(RequireVPN.Properties.Resources.rvpnTray, new System.Drawing.Size(128,128));
            icon.Visible = true;
           

            base.OnStartup(e);
        }

        private void icon_Click(Object sender, EventArgs e)
        {
            System.Windows.MessageBox.Show("Thanks for clicking me");
        }
    }
}
