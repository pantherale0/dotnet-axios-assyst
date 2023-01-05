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
            this.actionType = new Models.Lookups._actionType { resolvingParameters = new Models.Lookups._resolvingParameters[1] };
            this.actionType.resolvingParameters[0] = new Models.Lookups._resolvingParameters { parameterName = "shortCode", parameterValue = "EMAIL CUSTOMER" };
        }

        public emailUser(int eventId, string remarks, int serviceTime, int affectedUserId, System.Data.DataTable attachments)
        {
            this.affectedUserId = affectedUserId;
            this.eventId = eventId;
            this.remarks = remarks;
            this.serviceTime = new Models.Common._serviceTime { value = serviceTime };
            this.actionType = new Models.Lookups._actionType { resolvingParameters = new Models.Lookups._resolvingParameters[1] };
            this.actionType.resolvingParameters[0] = new Models.Lookups._resolvingParameters { parameterName = "shortCode", parameterValue = "EMAIL CUSTOMER" };

            this.attachments = new Models.Common._attachments[attachments.Rows.Count];

            for (int i = 0; i < attachments.Rows.Count; i++) {
                this.attachments[i].attachment = Convert.ToBase64String((byte[])attachments.Rows[i]["attachment"]);
                this.attachments[i].name = (string)attachments.Rows[i]["name"];
                this.attachments[i].fileName = (string)attachments.Rows[i]["fileName"];
                this.attachments[i].deleteAfterSend = (bool)attachments.Rows[i]["deleteAfterSend"];
                this.attachments[i].attachmentToSend = (bool)attachments.Rows[i]["attachmentToSend"];
            }

        }
    }
}
