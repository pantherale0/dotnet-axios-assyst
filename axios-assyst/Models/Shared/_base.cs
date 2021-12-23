using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Axios_Assyst.Models.Shared
{
    // This class defines some of the shared objects between all endpoint data types, some endpoints may have a handler between its endpoint model and this model where other functions may be shared specific to areas (such as events, suppliers etc)
    public class _base
    {
        public bool? cacheable { get; set; }
        public string dataLocale { get; set; }
        public int? entityDefinitionType { get; set; }
        public int? entityDefinitionId { get; set; }
        public int? id { get; set; }
        public bool? objectAvailable { get; set; }
        public bool? systemRecordFlag { get; set; }
        public int? version { get; set; }
        public bool? discontinued { get; set; }
        public DateTime? modifyDate { get; set; }
        public string modifyId { get; set; }
        public string remarks { get; set; }
        public Common._richRemarks? richRemarks { get; set; }
    }
}
