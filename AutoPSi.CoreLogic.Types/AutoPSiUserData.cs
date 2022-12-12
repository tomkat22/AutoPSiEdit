using System;
using System.Collections.Generic;

namespace AutoPSi.CoreLogic.Types
{
    public class AutoPSiUserData
    {
        public static readonly string KEYUD1 = "UDATA1";
        public static readonly string KEYUD2 = "UDATA2";
        
        private Dictionary<string,string> _uDataDic = null;

        public AutoPSiUserData(string userData)
        {
            _uDataDic=new Dictionary<string,string>(2);  

            string[] strKeyValuePairSequence = userData.Split(';');

            foreach(string strKeyValuePair in strKeyValuePairSequence)
            {
                string[] strKeyAndValue = strKeyValuePair.Split('=');

                if(strKeyAndValue.Length == 2 )
                {
                    _uDataDic[strKeyAndValue[0]] = strKeyAndValue[1];
                }
            }
        }

        public string QueryUserDataField (string fieldName)
        {
            return _uDataDic[fieldName];
        }

        public void SetUserDataField (string fieldName, string value)
        {
            _uDataDic[fieldName] = value;
        }
    }
}