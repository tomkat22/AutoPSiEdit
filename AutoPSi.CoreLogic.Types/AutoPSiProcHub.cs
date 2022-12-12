using System.Xml.Linq;
using System;

namespace AutoPSi.CoreLogic.Types
{
    public class AutoPSiProcHub
    {
        public static readonly string KEY = "_procHUB";
        
        private string _hubName = null;
        public AutoPSiProcHub() { }
        public AutoPSiProcHub(string hubName)
        {
            if (!Validate(hubName)) throw new Exception(KEY + " name length incorrect.");
            _hubName = hubName;
        }

        public static bool Validate(string groupName)
        {
            
            return true;
        }

        public string Value { get { return _hubName; } set { if (Validate(value)) _hubName = value; } }

        public override string ToString()
        {
            return KEY;
        }
    }
}