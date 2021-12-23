using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Axios_Assyst.Models.Common
{
    public class _category
    {
        public _resolvingParameters resolvingParameters;
        public _category()
        {

        }
        public _category(string parameterName, string parameterValue)
        {
            resolvingParameters = new _resolvingParameters() { parameterName = parameterName, parameterValue = parameterValue};
        }
    }
}
