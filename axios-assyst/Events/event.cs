using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Axios_Assyst.Events
{
    public class @event
    {
        public Models._customFields customFields;
        public int? eventId;
        public Models._category? category;
        public Models._priority? priority;
        public int? seriousnessId;
        public string remarks;
        public int? assignedServDeptId;
        public int? itemAId;
        public Models._item? itemA;
        public int? itemBId;
        public Models._item? itemB;
        public int? affectedUserId;
        public Enums.eventTypeEnum? eventType;
        public Enums.subEventTypeEnum? subEventType;
        public string shortDescription;
    }
}
