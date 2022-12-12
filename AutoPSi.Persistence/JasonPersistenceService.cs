using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Text.Json;
using System.Text.Json.Serialization;

using AutoPSi.Persistence.Interface;
using AutoPSi.CoreLogic.Types;


namespace AutoPSi.Persistence.Service
{
    public class JasonPersistenceService : IPeristenceInterface
    {
    public string CurrentFile { get; set; } 

        public JasonPersistenceService()
        {
 
        }

        public IList<AutoPSiPrinter> LoadFile (string strFileSpec)
        { 
            if (strFileSpec == null)
            {
                throw new ArgumentNullException();
            }

        CurrentFile = strFileSpec;  

            JsonAutoPSiDocument printerListDoc = new JsonAutoPSiDocument(CurrentFile);
            



           
            try
            {
                printerListDoc.Load();

               return  printerListDoc.GetAllPrinters();


            } catch (Exception ex) { }

            return null;
        }

    }
}
