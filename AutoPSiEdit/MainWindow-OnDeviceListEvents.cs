
using System.Collections.Generic;
using System.Windows.Controls.Ribbon;
using AutoPSi.Persistence.Interface;
using AutoPSi.Persistence.Service;
using AutoPSi.CoreLogic.Types;

namespace AutoPSiEdit
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : RibbonWindow
    {
        private void OnDeviceSelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {

            // Item was selected
            if (e.AddedItems.Count > 0)
            {
                for (int i = 0; i < e.AddedItems.Count; i++)
                {
                    if (e.AddedItems[i] is AutoPSiPrinter)
                    {
                        SelectedPrinter = (AutoPSiPrinter)e.AddedItems[i];

                    }
                }
            }
            else
            {
                // Item was deselected
                if (e.RemovedItems.Count > 0)
                {
                    for (int i = 0; i < e.AddedItems.Count; i++)
                    {
                        if (e.AddedItems[i] is AutoPSiPrinter)
                        {
                            if (SelectedPrinter == (AutoPSiPrinter)e.RemovedItems[i])
                                SelectedPrinter = null;
                        }
                    }
                }
            }

        OnReflectStateInUI();
        }
    }
}
