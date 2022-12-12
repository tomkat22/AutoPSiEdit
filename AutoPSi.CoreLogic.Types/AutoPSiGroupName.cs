using System.Xml.Linq;
using System;

namespace AutoPSi.CoreLogic.Types
{
    public class AutoPSiGroupName
    {
        public static readonly string KEY = "GRPNAME";
        private static readonly int GROUP_NAME_LENGTH = 11;
        private string _groupName = null;
        public AutoPSiGroupName() { }
         public AutoPSiGroupName(string groupName)
        {
            if (!Validate(groupName)) throw new Exception(KEY + " name length incorrect.");
            _groupName = groupName;
        }

        public static bool Validate(string groupName)
        {
            if (groupName.Length != GROUP_NAME_LENGTH) return true;
            return true;
        }

        public string Value { get { return _groupName; } set { if (Validate(value)) _groupName = value; } }

        public override string ToString()
        {
            return KEY;
        }
    }
}