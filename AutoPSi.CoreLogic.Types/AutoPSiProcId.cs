using System;

namespace AutoPSi.CoreLogic.Types
{
    public class AutoPSiProcId
    {
        public static readonly string KEY = "_procID";
        private string _procId = null;

        public AutoPSiProcId() { }
        public AutoPSiProcId(string procId)
        {
            if (!Validate(procId)) throw new Exception(KEY + " name length incorrect.");
            _procId = procId;
        }

        public static bool Validate(string procId)
        {

            return true;
        }

        public string Value { get { return _procId; } set { if (Validate(value)) _procId = value; } }
        public override string ToString()
        {
            return KEY;
        }
}
}