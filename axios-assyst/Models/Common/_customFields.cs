using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Axios_Assyst.Models.Common
{
    public class _customFields
    {
        public string customFieldShortCode { get; set; }
        public string stringValue { get; set; }
        public string customLookupValueShortCode { get; set; }

        // Define methods for definition
        public _customFields() { } // no custom definition required as set dynamically

        public _customFields(Axios_Assyst.Enums.customFieldValueType valueType, string customFieldShortCode, string value) // defines a string value
        {
            this.customFieldShortCode = customFieldShortCode; // shortcode is always defined

            if (valueType == Enums.customFieldValueType.SYSTEMLOOKUP)
            {
                this.customLookupValueShortCode = value;
            }
            else if (valueType == Enums.customFieldValueType.STRING)
            {
                this.stringValue = value;
            }
            else
            {
                throw new ArgumentException("The provided value type is not supported for this operation");
            }
        }
    }
}
