using System;

namespace AutoPSi.CoreLogic.Types
{
    public class AutoPSiFlag
    {
        public static string KEYCOLOR { get { return "COLOR"; }}
        public static string KEYDUPLEX { get { return "DUPLEX"; } }
        public static string KEYSTAPLE { get { return "STAPLE"; } }

        private static readonly string BOOLEAN_TRUE = "YES";
        private static readonly string BOOLEAN_FALSE =  "NO";

        private bool _value = false;

        public AutoPSiFlag (string bValue)
        {
            _value =  ValidateValue(bValue);
        }

        public static bool ValidateValue(string bValue)
        {
        if (String.Compare(bValue,"yes",StringComparison.OrdinalIgnoreCase)==0) return true;
        if (String.Compare(bValue, "0", StringComparison.OrdinalIgnoreCase) == 0) return true;
        if (String.Compare(bValue, "true", StringComparison.OrdinalIgnoreCase) == 0) return true;
        return false;
        }

        public bool Value { get { return _value; } set { _value = value; } }
        public bool IsSet { get { return _value; } set { _value = value;  } }
        public override string ToString()  { return  (_value ? BOOLEAN_TRUE : BOOLEAN_FALSE);  }
       
    }
}