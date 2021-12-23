using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Axios_Assyst.Actions
{
    public class close : Models.Endpoints._action
    {
        public int causeItemId;
        public int causeCategoryId;

        public close(int eventId, string remarks, int serviceTime, int causeItemId, int causeCategoryId, bool isWithdraw)
        {
            this.eventId = eventId;
            this.remarks = remarks;
            this.serviceTime = new Models.Common._serviceTime { value = serviceTime };
            this.causeItemId = causeItemId;
            this.causeCategoryId = causeCategoryId;
            if (isWithdraw)
            {
                this.actionType = new Models.Lookups._actionType { resolvingParameters = new Models.Lookups._resolvingParameters { parameterName = "shortCode", parameterValue = "WITHDRAW" } };
            } else
            {
                this.actionType = new Models.Lookups._actionType { resolvingParameters = new Models.Lookups._resolvingParameters { parameterName = "shortCode", parameterValue = "CLOSURE" } };
            }
        }
    }
}
