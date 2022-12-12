using System.Collections.Generic;
using System.Windows.Controls.Ribbon;
using AutoPSi.Persistence.Interface;
using AutoPSi.Persistence.Service;
using AutoPSi.CoreLogic.Types;
using System.Windows;
using System.Windows.Controls;
using AutoPSi.CoreLogic.Interface;

namespace AutoPSiEdit
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : RibbonWindow
    {
    internal AutoPSiPrinter             SelectedPrinter { get; set; }
    internal IList<AutoPSiPrinter>      PrinterList     { get; set; }
    internal string                     CurrentFileName { get; set; }
    internal ICoreLogicInterface        DocumentSrv     { get; set; }

        private void OnLoadedMainWindow(object sender, RoutedEventArgs e)
        {
            SelectedPrinter = null;
            PrinterList     = new List<AutoPSiPrinter>();
            CurrentFileName = null;

            if (Properties.Settings.Default.Test_LoadDemo)
            {
                CurrentFileName = Properties.Settings.Default.Test_DemoJsonFile;

                PrinterList = DocumentSrv.GetAllPrinter(CurrentFileName);

                foreach (AutoPSiPrinter p in PrinterList)
                {
                    lvDeviceList.Items.Add(p);
                }
            }

        OnReflectStateInUI();
        }

        private void OnClosingMainWindow(object sender, System.ComponentModel.CancelEventArgs e)
        {
            //log.Info("Shuting down AutoPSi ...");
            //ModelessDebugWindow mdw = App.Current.Properties["LogWindow"] as ModelessDebugWindow;

        }
    }
}
