using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Axios_Assyst.Models.Endpoints
{
    public class _linkedEventGroup : Shared._base
    {
        public DateTime? linkDate { get; set; }
        public int? assystUserId { get; set; }
        public string linkGroupRemarks { get; set; }
        public int? linkReasonId { get; set; }
        public bool? systemRecord { get; set; }
        public bool? annonymousRecord { get; set; }
        public bool? record { get; set; }
        public Models.Common._linkedEvents[] linkedEvents { get; set; }
    }
}
