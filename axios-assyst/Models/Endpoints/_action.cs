using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Axios_Assyst.Models.Endpoints
{
    public class _action
    {
        public int eventId { get; set; }
        public string remarks { get; set; }
        public Common._serviceTime serviceTime { get; set; }
        public Lookups._actionType actionType { get; set; }

        // Default contructor
        public _action() { }
        public _action(int eventId, string remarks, int serviceTime, string actionShortcode)
        {
            this.eventId = eventId;
            this.remarks = remarks;
            this.serviceTime = new Models.Common._serviceTime { value = serviceTime };
            this.actionType = new Models.Lookups._actionType { resolvingParameters = new Models.Lookups._resolvingParameters { parameterName = "shortCode", parameterValue = actionShortcode } };
        }
    }
}
