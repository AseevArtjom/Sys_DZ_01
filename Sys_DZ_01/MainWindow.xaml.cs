using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Reflection;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Sys_DZ_01
{
    public partial class MainWindow : Window
    {
        Process process = new Process();
        public MainWindow()
        {
            InitializeComponent();
            Process[] processes = Process.GetProcesses();
            foreach (Process proc in processes)
            {
                datagrid.Items.Add(new
                {
                    Id = proc.Id,
                    ProcessName = proc.ProcessName
                });
            }
        }
        private void Confirm_click(object sender, RoutedEventArgs e)
        {
            process.StartInfo.FileName = app_tb.Text;
            process.Start();
        }

        private void Close_click(object sender, RoutedEventArgs e)
        {
            process.Kill();
        }
    }
}
