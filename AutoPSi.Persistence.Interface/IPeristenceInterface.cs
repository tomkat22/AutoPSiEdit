
using System.Collections.Generic;
using AutoPSi.CoreLogic.Types;

namespace AutoPSi.Persistence.Interface
{
    public interface IPeristenceInterface
    {
        IList<AutoPSiPrinter> LoadFile(string strFileSpec);
    }
}
