using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Axios_Assyst.Actions
{
    public class decisionAction
    {
        public Models._decision decision;
        public string remarks;
        public Models._serviceTime serviceTime;
        public int eventId;

        public decisionAction(int eventId, int serviceTime, string remarks, string decision)
        {
            this.eventId = eventId;
            this.remarks = remarks;
            this.serviceTime = new Models._serviceTime { value = serviceTime };
            this.decision = new Models._decision { answer = decision };
        }
    }
}
