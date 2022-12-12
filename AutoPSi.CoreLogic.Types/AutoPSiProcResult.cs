using System;

namespace AutoPSi.CoreLogic.Types
{
    public class AutoPSiProcResult
    {
        public static readonly string KEY = "_procResult";
        private string _procResult = null;

        public AutoPSiProcResult() { }
        public AutoPSiProcResult(string procResult)
        {
            if (!Validate(procResult)) throw new Exception(KEY + " name length incorrect.");
            _procResult = procResult;
        }

        public static bool Validate(string procResult)
        {

            return true;
        }

        public string Value { get { return _procResult; } set { if (Validate(value)) _procResult = value; } }
        public override string ToString()
        {
            return KEY;
        }
    }
}