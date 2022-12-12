using System;

namespace AutoPSi.CoreLogic.Types
{
    public class AutoPSiProcType
    {
        public static readonly string KEY = "_procType";
        private string _procType = null;

        public AutoPSiProcType() { }
        public AutoPSiProcType(string procType)
        {
            if (!Validate(procType)) throw new Exception(KEY + " name length incorrect.");
            _procType = procType;
        }

        public static bool Validate(string procType)
        {
           
            return true;
        }

        public string Value { get { return _procType; } set { if (Validate(value)) _procType = value;  } }
        public override string ToString()
        {
            return KEY;
        }
    }
}