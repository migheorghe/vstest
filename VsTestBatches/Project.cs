using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VsTestBatches
{
    public class Project
    {
        public bool IsVersionSupported(string version)
        {
            return version == "V2";
        }
    }
}
