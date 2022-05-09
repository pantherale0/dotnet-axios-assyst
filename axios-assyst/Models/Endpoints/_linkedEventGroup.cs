using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Axios_Assyst.Models.Endpoints
{
    public class _linkedEventGroup
    {
        public int? id { get; set; }
        public bool? objectAvailable { get; set; }
        public bool? systemRecordFlag { get; set; }
        public int? entityDefinitionType { get; set; }
        public bool? cacheable { get; set; }
        public string dataLocale { get; set; }
        public DateTime? linkDate { get; set; }
        public int? assystUserId { get; set; }
        public string linkGroupRemarks { get; set; }
        public int? linkReasonId { get; set; }
        public bool? systemRecord { get; set; }
        public bool? annonymousRecord { get; set; }
        public bool? record { get; set; }
    }
}
