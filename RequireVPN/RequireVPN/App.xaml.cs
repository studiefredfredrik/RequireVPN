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
        

        protected override void OnStartup(StartupEventArgs e)
        {
            // Add tray icon
            //App.icon = new NotifyIcon();
            //icon.Click += new EventHandler(icon_Click);
            //icon.Icon = new System.Drawing.Icon(RequireVPN.Properties.Resources.rvpnTray, new System.Drawing.Size(128,128));
            //icon.Visible = true;

            

            //this.notifyIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info; //Shows the info icon so the user doesn't thing there is an error.
            //this.notifyIcon.BalloonTipText = "[Balloon Text when Minimized]";
            //this.notifyIcon.BalloonTipTitle = "[Balloon Title when Minimized]";
            //this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon"))); //The tray icon to use
            //this.notifyIcon.Text = "[Message shown when hovering over tray icon]";

            base.OnStartup(e);
        }


    }
}
