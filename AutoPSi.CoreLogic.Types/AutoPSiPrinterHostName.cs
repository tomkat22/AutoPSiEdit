using System;

namespace AutoPSi.CoreLogic.Types
{
    public class AutoPSiPrinterHostName
    {
        public static readonly string KEY = "TCPHOST";
        private static readonly int PRINTER_HOSTNAME_LENGTH = 255;
        private string _printerHostName = null;
        public AutoPSiPrinterHostName() { }
        public AutoPSiPrinterHostName(string hostName)
        {
            if (!Validate(hostName)) throw new Exception(KEY + " name length incorrect.");
            _printerHostName = hostName;
        }

        public static bool Validate(string hostName)
        {
            if (hostName.Length <= PRINTER_HOSTNAME_LENGTH) return true;
            return true;
        }
        public string Value { get { return _printerHostName; } set { if (Validate(value)) _printerHostName = value; }  }
        public override string ToString() { return KEY; }
    }
}