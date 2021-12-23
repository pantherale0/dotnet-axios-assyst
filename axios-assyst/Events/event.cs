using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Axios_Assyst.Events
{
    public class @event
    {
        public Models.Common._customFields? customFields;
        public int? eventId;
        public Models.Common._category? category;
        public Models.Common._priority? priority;
        public int? seriousnessId;
        public string remarks;
        public int? assignedServDeptId;
        public int? itemAId;
        public Models.Lookups._item? itemA;
        public int? itemBId;
        public Models.Lookups._item? itemB;
        public int? affectedUserId;
        public Enums.eventTypeEnum? eventType;
        public Enums.subEventTypeEnum? subEventType;
        public string shortDescription;
    }
}
