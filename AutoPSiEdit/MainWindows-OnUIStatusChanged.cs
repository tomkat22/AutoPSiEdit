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
        private void OnReflectStateInUI ()
        {
          if(null != SelectedPrinter) btEditPrinter.IsEnabled = true;
            else                      btEditPrinter.IsEnabled = false;



        }
    }
}
