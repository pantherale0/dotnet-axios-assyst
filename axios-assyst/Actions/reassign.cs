using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Axios_Assyst.Actions
{
    public class reassign : action
    {
        public int assignedServDeptId { get; set; }

        public reassign(int eventId, int assignedServDeptId, int serviceTime, string remarks)
        {
            this.eventId = eventId;
            this.remarks = remarks;
            this.assignedServDeptId = assignedServDeptId;
            this.actionType = new Models._actionType { resolvingParameters = new Models._resolvingParameters { parameterName = "shortCode", parameterValue = "REASSIGN" } };
            this.serviceTime = new Models._serviceTime { value = serviceTime };
        }
    }
}
