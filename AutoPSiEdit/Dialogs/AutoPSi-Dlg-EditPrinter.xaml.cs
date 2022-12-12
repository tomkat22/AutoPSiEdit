using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Ribbon;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using AutoPSi.CoreLogic.Types;

namespace AutoPSiEdit.Dialogs
{
    /// <summary>
    /// Interaktionslogik für AutoPSi_Dlg_EditPrinter.xaml
    /// </summary>
    public partial class AutoPSi_Dlg_EditPrinter : Window
    {
        public AutoPSiPrinter   Printer { get; set; }   
        public AutoPSi_Dlg_EditPrinter(AutoPSiPrinter _Printer)
        {
            Printer = _Printer;

            InitializeComponent();

            if(null!= Printer)
            {
                tbPrinterName.Text  = Printer.PRINTER.Value;
                tbHostname.Text     = Printer.TCPHOST.Value;
                tbLocation.Text     = Printer.LOCATION.Value;

                foreach (string group in Properties.Settings.Default.UserDataRef_GroupName)
                    cbGroupName.Items.Add(group);
                cbGroupName.SelectedItem = Printer.GRPNAME.Value;

                foreach (string model in Properties.Settings.Default.UserDataRef_ModelName)
                    cbModelName.Items.Add(model);
                cbModelName.SelectedItem = Printer.PRTLNAME.Value;

                foreach (string owner in Properties.Settings.Default.UserDataRef_AssetOwner)
                        cbProvider.Items.Add(owner);
                cbProvider.SelectedItem = Printer.UDATA1.QueryUserDataField(Properties.Settings.Default.UserDataKey_AssetOwner);

                foreach (string source in Properties.Settings.Default.UserDataRef_Source)
                    cbSource.Items.Add(source);
                cbSource.SelectedItem = Printer.UDATA1.QueryUserDataField(Properties.Settings.Default.UserDataKey_Source);

                tbSerialNumber.Text = Printer.UDATA2.QueryUserDataField(Properties.Settings.Default.UserDataKey_SerialNumber);
                tbMAC.Text          = Printer.UDATA2.QueryUserDataField(Properties.Settings.Default.UserDataKey_MACAddress);

                btColor.IsChecked   = Printer.COLOR.IsSet;
                btDuplex.IsChecked  = Printer.DUPLEX.IsSet;
                btStaple.IsChecked  = Printer.STAPLE.IsSet;

                foreach (string procType in Properties.Settings.Default.UserDataRef_ProcType)
                    cbProcType.Items.Add(procType);
                cbProcType.SelectedItem = Printer._procType.Value;
            }
        }

        private void OnOk(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
            MoveControlDataToReferencedPrinterObject();
            Close();
        }

        private void OnCancel(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
            Close();
        }

        private void MoveControlDataToReferencedPrinterObject()
        {
            Printer.PRINTER.Value  = tbPrinterName.Text;
            Printer.TCPHOST.Value  = tbHostname.Text;
            Printer.LOCATION.Value = tbLocation.Text;

            Printer.GRPNAME.Value = cbGroupName.SelectedItem.ToString();
            Printer.PRTLNAME.Value = cbModelName.SelectedItem.ToString();

            Printer.UDATA1.SetUserDataField(Properties.Settings.Default.UserDataKey_AssetOwner, cbProvider.SelectedItem.ToString());
            Printer.UDATA1.SetUserDataField(Properties.Settings.Default.UserDataKey_Source, cbSource.SelectedItem.ToString());

            Printer.UDATA2.SetUserDataField(Properties.Settings.Default.UserDataKey_SerialNumber, tbSerialNumber.Text);
            Printer.UDATA2.SetUserDataField(Properties.Settings.Default.UserDataKey_MACAddress, tbMAC.Text);

            Printer.COLOR.Value = btColor.IsChecked.Value;
            Printer.DUPLEX.Value = btDuplex.IsChecked.Value;
            Printer.STAPLE.Value = btStaple.IsChecked.Value;
 
            Printer._procType.Value = cbProcType.SelectedItem.ToString();  
           }


    }
}
