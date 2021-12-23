using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Axios_Assyst.Actions
{
    public class decisionAction
    {
        public Models.Common._decision decision;
        public string remarks;
        public Models.Common._serviceTime serviceTime;
        public int eventId;

        public decisionAction(int eventId, int serviceTime, string remarks, string decision)
        {
            this.eventId = eventId;
            this.remarks = remarks;
            this.serviceTime = new Models.Common._serviceTime { value = serviceTime };
            this.decision = new Models.Common._decision { answer = decision };
        }
    }
}
