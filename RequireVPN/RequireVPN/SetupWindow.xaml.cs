using System.Diagnostics;
using System.Net.NetworkInformation;
using System.Windows;

namespace RequireVPN
{
    public partial class SetupWindow : Window
    {
        public SetupWindow()
        {
            InitializeComponent();
            btn_bindProcesses.IsEnabled = false;
            btn_bindAdapter.IsEnabled = false;
        }

        private void btn_refreshProcesses_Click(object sender, RoutedEventArgs e)
        {
            lst_processes.Items.Clear();
            lst_processes.IsEnabled = true;
            btn_bindProcesses.IsEnabled = true;
            Process[] processes = Process.GetProcesses();
            lst_processes.DisplayMemberPath = "ProcessName";
            foreach(Process process in processes)
            {
                lst_processes.Items.Add(process);
            }
        }

        private void btn_bindProcesses_Click(object sender, RoutedEventArgs e)
        {
            if(lst_processes.SelectedItem != null)
            {
                AppTerminator.selectedProcess = (Process)lst_processes.SelectedItem;
                lst_processes.IsEnabled = false;
                btn_bindProcesses.IsEnabled = false;
            }
        }

        private void btn_refreshAdapters_Click(object sender, RoutedEventArgs e)
        {
            lst_adapters.Items.Clear();
            lst_adapters.IsEnabled = true;
            btn_bindAdapter.IsEnabled = true;
            NetworkInterface[] adapters = NetworkInterface.GetAllNetworkInterfaces();
            lst_adapters.DisplayMemberPath = "Name";
            foreach (NetworkInterface adapter in adapters)
            {
                lst_adapters.Items.Add(adapter);
            }
        }

        private void btn_bindAdapter_Click(object sender, RoutedEventArgs e)
        {
            if(lst_adapters.SelectedItem != null)
            {
                AdapterWatcher.adapter = (NetworkInterface)lst_adapters.SelectedItem;
                lst_adapters.IsEnabled = false;
                btn_bindAdapter.IsEnabled = false;
            }
        }

        private void btn_Save_Click(object sender, RoutedEventArgs e)
        {
            ApplicationSettings settings = new ApplicationSettings();
            settings.adapterName = AdapterWatcher.adapter.Name;
            settings.processName = AppTerminator.selectedProcess.ProcessName;
            SettingsHandler.SetApplicationSetting(settings);
            this.Close();
        }
    }
}