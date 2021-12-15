using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Axios_Assyst.Models
{
    public class _item
    {
        public _resolvingParameters resolvingParameters;
        public _item()
        {

        }
        public _item(string parameterName, string parameterValue)
        {
            resolvingParameters = new _resolvingParameters() { parameterName = parameterName, parameterValue = parameterValue };
        }
    }
}
