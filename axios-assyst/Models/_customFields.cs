using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Axios_Assyst.Models
{
    public class _customFields
    {
        public string customFieldShortCode { get; set; }
    }

    public class _customFieldString : _customFields
    {
        public string stringValue { get; set; }
    }

    public class _customFieldLookup : _customFields
    {
        public string customLookupValueShortCode { get; set; }
    }
}
