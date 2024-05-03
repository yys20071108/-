using Microsoft.Win32;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Input;

namespace WpfApp2
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ConnectButton_Click(object sender, RoutedEventArgs e)
        {
            string deviceId = DeviceIdTextBox.Text;
            Process.Start("cmd", $"/c adb connect {deviceId}");
        }

        private void DisconnectButton_Click(object sender, RoutedEventArgs e)
        {
            string deviceId = DeviceIdTextBox.Text;
            Process.Start("cmd", $"/c adb disconnect {deviceId}");
        }

        private void InstallButton_Click(object sender, RoutedEventArgs e)
        {
            string apkPath = ApkPathTextBox.Text;
            Process.Start("cmd", $"/c adb install {apkPath}");
        }

        private void UninstallButton_Click(object sender, RoutedEventArgs e)
        {
            string packageName = "com.example.app"; // 替换为实际的包名
            Process.Start("cmd", $"/c adb uninstall {packageName}");
        }

        private void GetDeviceInfoButton_Click(object sender, RoutedEventArgs e)
        {
            Process.Start("cmd", "/c adb shell getprop");
        }
        private void SelectApkButton_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "APK files (*.apk)|*.apk";
            if (openFileDialog.ShowDialog() == true)
            {
                string selectedApkPath = openFileDialog.FileName;
                // 在这里处理选中的apk文件路径
            }
        }

        private void ApkPathTextBox_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {

        }
    }
}
