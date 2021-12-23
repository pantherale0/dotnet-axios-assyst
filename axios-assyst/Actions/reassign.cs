using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Axios_Assyst.Actions
{
    public class reassign : Models.Endpoints._action
    {
        public int assignedServDeptId { get; set; }

        public reassign(int eventId, int assignedServDeptId, int serviceTime, string remarks)
        {
            this.eventId = eventId;
            this.remarks = remarks;
            this.assignedServDeptId = assignedServDeptId;
            this.actionType = new Models.Lookups._actionType { resolvingParameters = new Models.Lookups._resolvingParameters[1]  };
            this.actionType.resolvingParameters[0] = new Models.Lookups._resolvingParameters { parameterName = "shortCode", parameterValue = "REASSIGN" };
            this.serviceTime = new Models.Common._serviceTime { value = serviceTime };
        }
    }
}
