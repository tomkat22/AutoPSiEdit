using System;

namespace AutoPSi.CoreLogic.Types
{
    public class AutoPSiPrinterLocation
    {
        public static readonly string KEY = "LOCATION";
        private static readonly int PRINTER_LOCATION_LENGTH = 255;
        private string _location = null;

        public AutoPSiPrinterLocation() { }
        public AutoPSiPrinterLocation(string location)
        {
            if (!Validate(location)) throw new Exception(KEY + " name length incorrect.");
            _location = location;
        }

        public static bool Validate(string location)
        {
            if (location.Length <= PRINTER_LOCATION_LENGTH) return true;
            return true;
        }
        public string Value { get { return _location; } set { if (Validate(value)) _location = value; }  }
        public override string ToString() { return KEY; }
    }
}