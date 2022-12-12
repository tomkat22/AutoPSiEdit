using System;

namespace AutoPSi.CoreLogic.Types
{
    public class AutoPSiDateTime
    {
        public static readonly string KEY_TIME_LOCAL = "_TimeLocal";
        public static readonly string KEY_PROC_TIME  = "_procTime";
        private string _KEY;
        private string _DateTime = null;

        public AutoPSiDateTime() { }
        public AutoPSiDateTime(string dateTime,string KEY)
        {
            if (!Validate(dateTime)) throw new Exception(KEY + " name length incorrect.");
            _KEY = KEY;
            _DateTime = dateTime;
        }

        public static bool Validate(string dateTime)
        {

            return true;
        }

        public string Value { get { return _DateTime; } set { if (Validate(value)) _DateTime = value; } }
        public override string ToString()
        {
            return _KEY;
        }
    }
}