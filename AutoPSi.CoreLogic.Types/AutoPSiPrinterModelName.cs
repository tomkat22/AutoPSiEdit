using System;

namespace AutoPSi.CoreLogic.Types
{
    public class AutoPSiPrinterModelName
    {
        public static readonly string KEY = "PRTLNAME";
        private static readonly int MAX_MODEL_NAME_LENGTH = 32;
        private string _modelName = null;

        public AutoPSiPrinterModelName() { }
        public AutoPSiPrinterModelName(string modelName)
        {
            if (!Validate(modelName)) throw new Exception(KEY + " name length incorrect.");
            _modelName = modelName;
        }

        public static bool Validate(string modelName)
        {
            if (modelName.Length <= MAX_MODEL_NAME_LENGTH) return true;
            return true;
        }
        public string Value { get { return _modelName; } set { if (Validate(value)) _modelName = value;  } }
        public override string ToString()  { return KEY;  }



    }
}