using System;
using System.Collections.Generic;
using AutoPSi.CoreLogic.Types;

namespace AutoPSi.CoreLogic.Interface
{
    public interface ICoreLogicInterface
    {
        IList<AutoPSiPrinter> GetAllPrinter(string strFileSpec);
    }
}
