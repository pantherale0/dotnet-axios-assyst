using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Axios_Assyst.Actions
{
    public class emailUser : Models.Endpoints._action
    {
        public int affectedUserId;

        public emailUser(int eventId, string remarks, int serviceTime, int affectedUserId)
        {
            this.affectedUserId = affectedUserId;
            this.eventId = eventId;
            this.remarks = remarks;
            this.serviceTime = new Models.Common._serviceTime { value = serviceTime };
            this.actionType = new Models.Lookups._actionType { resolvingParameters = new Models.Lookups._resolvingParameters { parameterName = "shortCode", parameterValue = "EMAIL CUSTOMER" } };
        }
    }
}
