using AutoPSi.CoreLogic.Types;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AutoPSi.Persistence.Service
{

    internal class JsonAutoPSiDocument
    {
        private string CurrentFile { get; set; }
        private string JsonString  { get; set; }

        private JsonDocumentOptions JsonOptions { get; set; }   

        // -------------------------------------------------------------
        public JsonAutoPSiDocument(string strFileSpec)
        {
            if (strFileSpec == null)
            {
                throw new ArgumentNullException();
            }

            CurrentFile = strFileSpec;

            JsonOptions  = new JsonDocumentOptions
            {
                AllowTrailingCommas = true
            };
        }
        // -------------------------------------------------------------
        public void Load ()
        {

            try
            {
                using (var sr = new StreamReader(CurrentFile))
                {
                    JsonString = sr.ReadToEnd();
                }
            }
            catch (Exception ex) { }
        }

        // -------------------------------------------------------------

        public IList<AutoPSiPrinter> GetAllPrinters() {

            IList<AutoPSiPrinter> olPrinter = new List<AutoPSiPrinter>();

            using (JsonDocument document = JsonDocument.Parse(JsonString, JsonOptions))
            {
                foreach (JsonElement element in document.RootElement.EnumerateArray())
                {
                    olPrinter.Add(GetAndValidatePrinterFromElement(element));
                }
            }

        return olPrinter;
        }

        private AutoPSiPrinter GetAndValidatePrinterFromElement (JsonElement elm)
        {
            AutoPSiPrinter p = new AutoPSiPrinter();

            try
            {
                p.PRINTER  = new AutoPSiPrinterName(elm.GetProperty(AutoPSiPrinterName.KEY).GetString());
                p.GRPNAME  = new AutoPSiGroupName(elm.GetProperty(AutoPSiGroupName.KEY).GetString());
                p.PRTLNAME = new AutoPSiPrinterModelName(elm.GetProperty(AutoPSiPrinterModelName.KEY).GetString());
                p.TCPHOST = new AutoPSiPrinterHostName(elm.GetProperty(AutoPSiPrinterHostName.KEY).GetString());
                p.LOCATION = new AutoPSiPrinterLocation(elm.GetProperty(AutoPSiPrinterLocation.KEY).GetString());
                p.COLOR= new AutoPSiFlag(elm.GetProperty(AutoPSiFlag.KEYCOLOR).GetString());
                p.DUPLEX = new AutoPSiFlag(elm.GetProperty(AutoPSiFlag.KEYDUPLEX).GetString());
                p.STAPLE = new AutoPSiFlag(elm.GetProperty(AutoPSiFlag.KEYSTAPLE).GetString());
                p.UDATA1 = new AutoPSiUserData(elm.GetProperty(AutoPSiUserData.KEYUD1).GetString());
                p.UDATA2 = new AutoPSiUserData(elm.GetProperty(AutoPSiUserData.KEYUD2).GetString());
                p._procType = new AutoPSiProcType(elm.GetProperty(AutoPSiProcType.KEY).GetString());
                p._procHUB = new AutoPSiProcHub(elm.GetProperty(AutoPSiProcHub.KEY).GetString());
                p._procID = new AutoPSiProcId(elm.GetProperty(AutoPSiProcId.KEY).GetString());
                p._TimeLocal = new AutoPSiDateTime(elm.GetProperty(AutoPSiDateTime.KEY_TIME_LOCAL).GetString(), AutoPSiDateTime.KEY_TIME_LOCAL);
                p._procTime  = new AutoPSiDateTime(elm.GetProperty(AutoPSiDateTime.KEY_PROC_TIME).GetString(), AutoPSiDateTime.KEY_PROC_TIME);
                p._Modifier = new AutoPSiModifyingUser(elm.GetProperty(AutoPSiModifyingUser.KEY).GetString());
                p._procResult = new AutoPSiProcResult(elm.GetProperty(AutoPSiProcResult.KEY).GetString());
            }
            catch (Exception ex)
            {

            }

            return p;
        }
    }
}
