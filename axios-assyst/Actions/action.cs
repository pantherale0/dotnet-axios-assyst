using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Axios_Assyst.Actions
{
    public class action
    {
        public int eventId { get; set; }
        public string remarks { get; set; }
        public Axios_Assyst.Models._serviceTime serviceTime { get; set; }
        public Axios_Assyst.Models._actionType actionType { get; set; }

        // Default constructor
        public action()
        {
            eventId = 0;
            remarks = "";
            serviceTime = new Axios_Assyst.Models._serviceTime { value = 0 };
            actionType = new Axios_Assyst.Models._actionType { resolvingParameters = new Models._resolvingParameters { parameterName = "shortCode", parameterValue = "" } };
        }

        // Constructor specifying event, remarks, service time and actiontype
        public action(int eventId, string remarks, int serviceTime, string actionShortcode)
        {
            this.eventId = eventId;
            this.remarks = remarks;
            this.serviceTime = new Models._serviceTime { value=serviceTime };
            this.actionType = new Models._actionType { resolvingParameters = new Models._resolvingParameters { parameterName = "shortCode", parameterValue = actionShortcode } };
        }

    }
}
