
using System;
using System.Runtime.CompilerServices;

namespace AutoPSi.CoreLogic.Types
{
    public class AutoPSiPrinterName
    {
        public static readonly string KEY = "PRINTER";
        private static  readonly int  PRINTER_NAME_LENGTH = 12;
        private string _printerName = null;

        public AutoPSiPrinterName() { }
        public AutoPSiPrinterName(string name)
        {
            if (!Validate(name)) throw new Exception(KEY+" name length incorrect.");
            _printerName = name;
        }

        public Boolean Validate (string printerName)
        {
            if (printerName.Length > PRINTER_NAME_LENGTH) return false;

            return true;
        }



        public string Value  { get { return _printerName; } set { if (Validate(value)) _printerName = value; } }
        public override string ToString()
        {
            return KEY;
        }
    }
}