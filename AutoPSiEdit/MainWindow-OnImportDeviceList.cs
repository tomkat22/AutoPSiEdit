using System;
using System.Windows;
using System.Windows.Controls.Ribbon;
using System.IO;
using AutoPSi.CoreLogic.Types;

namespace AutoPSiEdit
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : RibbonWindow
    {
        private void OnOpenDeviceList(object sender, RoutedEventArgs e)
        {
            //open a browser for .txt files
            Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog();

            dlg.DefaultExt = "*.json";
            dlg.FileName = "*.json";
            dlg.Filter = "Java Script Object Notion (*.json)|*.jsn";

            Nullable<bool> result = dlg.ShowDialog();

            if (result == true)
            {
                if (File.Exists(dlg.FileName))
                {
                    CurrentFileName = dlg.FileName;

                    PrinterList = DocumentSrv.GetAllPrinter(CurrentFileName);
                    lvDeviceList.Items.Clear();
                    foreach (AutoPSiPrinter p in PrinterList)
                    {
                        lvDeviceList.Items.Add(p);
                    }

                 OnReflectStateInUI();
                }

            }
        }
        
    }
}
