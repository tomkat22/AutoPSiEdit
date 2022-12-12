
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
        public MainWindow()
        {
            InitializeComponent();
            CompositionRoot();
        }

    }
}
