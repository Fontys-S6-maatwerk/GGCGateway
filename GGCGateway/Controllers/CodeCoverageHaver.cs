using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GGCGateway.Controllers
{
    public class CodeCoverageHaver
    {
        public int GiveACoolNumber(int coolNumber, int coolerNumber)
        {
            int i = coolNumber * coolerNumber;

            return i + coolerNumber + coolNumber;
        }
    }
}
