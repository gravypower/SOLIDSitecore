using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversion.Adapters
{
    public interface ILogAdapter
    {
        void LogInfo(string message);
    }
}
