using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Axios_Assyst.Models.Endpoints
{
    public class _actionTypes
    {
        public int? id { get; set; }
        public int? version { get; set; }
        public bool? objectAvailable { get; set; }
        public bool? systemRecordFlag { get; set; }
        public int? entityDefinitionType { get; set; }
        public bool? cacheable { get; set; }
        public string dataLocale { get; set; }
        public string shortCode { get; set; }
        public string name { get; set; }
        public Common._richRemarks? richRemarks { get; set; }
        public string modifyId { get; set; }
        public DateTime? modifyDate { get; set; }
        public bool? discontinued { get; set; }
        public int? imageId { get; set; }
        public bool? mandatoryDescription { get; set; }
        public int? userStatus { get; set; }
        public bool? privateActionFlag { get; set; }
        public bool? popupActionFlag    { get; set; }
        public bool? emailActionFlag { get; set; }
        public bool? mailAffectedUser { get; set; }
        public bool? mailReportingUser { get; set; }
        public bool? mailServDept { get; set; }
        public bool? acknowledgementRequired { get; set; }
        public bool? normalActionFlag { get; set; }
        public bool? futureActionFlag { get; set; }
        public bool? userStatusActionFlag { get; set; }
        public bool? clockActionFlag { get; set; }
        public bool? stateActionFlag { get; set; }
        public bool? systemActionFlag { get; set; }
        public bool? supplierActionFlag { get; set; }
        public bool? mailLoggingServDept { get; set; }
        public bool? mailLoggingUser { get; set; }
        public bool? stageActionFlag { get; set; }
        public int? lockingStatus   { get; set; }
        public string remarks { get; set; }
        public bool? systemRecord { get; set; }
        public bool? annoymousRecord { get; set; }
        public bool? record { get; set; }
    }
}
