using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Axios_Assyst
{
    public partial class Enums
    {
        public enum eventTypeEnum
        {
            INCIDENT = 1,
            PROBLEM = 2,
            CHANGE = 4,
            NORMALTASK = 8,
            DECISIONTASK = 16,
            AUTHORISATIONTASK = 32
        }

        public enum subEventTypeEnum
        {
            CHANGE = 1,
            SERVICEREQUEST = 2,
            ORDER = 3
        }
    }
}
