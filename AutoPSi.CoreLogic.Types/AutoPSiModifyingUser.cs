using System;

namespace AutoPSi.CoreLogic.Types
{
    public class AutoPSiModifyingUser
    {
        public static readonly string KEY = "_Modifier";
        private string _Modifier = null;

        public AutoPSiModifyingUser() { }
        public AutoPSiModifyingUser(string modifier)
        {
            if (!Validate(modifier)) throw new Exception(KEY + " name length incorrect.");
            _Modifier = modifier;
        }

        public static bool Validate(string modifier)
        {

            return true;
        }

        public string Value { get { return _Modifier; } set { if (Validate(value)) _Modifier = value; } }
        public override string ToString()
        {
            return KEY;
        }
    }
}