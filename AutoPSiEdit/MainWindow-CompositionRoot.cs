using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using System.Windows.Controls.Ribbon;
using AutoPSi.CoreLogic.Interface;
using AutoPSi.CoreLogic.Service;
using AutoPSi.CoreLogic.Types;
using AutoPSi.Persistence.Interface;
using AutoPSi.Persistence.Service;

namespace AutoPSiEdit
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : RibbonWindow
    {
        internal void CompositionRoot ()
        {
   
            DocumentSrv = new CoreLogicService(new JasonPersistenceService());
        }

    }
}
