using System.Collections.Generic;
using System.Windows.Controls.Ribbon;
using AutoPSi.Persistence.Interface;
using AutoPSi.Persistence.Service;
using AutoPSi.CoreLogic.Types;
using System.Windows;
using AutoPSiEdit.Dialogs;

namespace AutoPSiEdit
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : RibbonWindow
    {
        private void OnClick_EditPrinter(object sender, RoutedEventArgs e)
        {
            AutoPSi_Dlg_EditPrinter dlg = new AutoPSi_Dlg_EditPrinter(SelectedPrinter);

            if (true == dlg.ShowDialog())
            {
                lvDeviceList.Items.Refresh();
            }

        }
    }
}
