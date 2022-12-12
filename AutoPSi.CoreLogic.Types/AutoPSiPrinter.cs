using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace AutoPSi.CoreLogic.Types
{
    public class AutoPSiPrinter
    {
        public  AutoPSiPrinterName         PRINTER          { get; set; }   
        public  AutoPSiGroupName           GRPNAME          { get; set; }   
        public  AutoPSiPrinterModelName    PRTLNAME         { get; set; }   

        public  AutoPSiPrinterHostName     TCPHOST          { get; set; }
        
        public  AutoPSiPrinterLocation     LOCATION         { get; set; }
        public  AutoPSiFlag                COLOR            { get; set; }
        public  AutoPSiFlag                DUPLEX           { get; set; }
        public  AutoPSiFlag                STAPLE           { get; set; }
        public  AutoPSiUserData            UDATA1           { get; set; }
        public  AutoPSiUserData            UDATA2           { get; set; } 
        
        public  AutoPSiProcId              _procID          { get; set; } 
        public  AutoPSiProcType            _procType        { get; set; } 
        public  AutoPSiProcHub             _procHUB         { get; set; }

        public  AutoPSiDateTime            _TimeLocal       { get; set; } 
        public  AutoPSiModifyingUser       _Modifier        { get; set; } 
        public  AutoPSiDateTime            _procTime        { get; set; } 
        public  AutoPSiProcResult          _procResult      { get; set; }

    }
}
