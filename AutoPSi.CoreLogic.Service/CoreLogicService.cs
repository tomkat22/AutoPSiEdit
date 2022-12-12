using System;
using System.Collections.Generic;
using AutoPSi.Persistence.Interface;
using AutoPSi.CoreLogic.Interface;
using AutoPSi.CoreLogic.Types;

namespace AutoPSi.CoreLogic.Service
{
    public class CoreLogicService : ICoreLogicInterface
    {
    internal IPeristenceInterface _persSrv;
        public CoreLogicService(IPeristenceInterface iPersSrv) { 
        
           if (null != iPersSrv) { _persSrv= iPersSrv;}
        else  throw new ArgumentNullException();
            
        }

        public IList<AutoPSiPrinter> GetAllPrinter(string strFileSpec)
        {
            return _persSrv.LoadFile(strFileSpec);
        }
    }
}
