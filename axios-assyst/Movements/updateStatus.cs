using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Axios_Assyst.Movements
{
    public class updateStatus : Models.Endpoints._movement
    {
        public updateStatus(int itemId, int statusId, string remarks)
        {
            this.itemId = itemId;
            this.itemStatusId = statusId;
            this.remarks = remarks;
        }
        public updateStatus(int itemId, int statusId, string remarks, Enums.moveReasonId moveReasonId)
        {
            this.itemId = itemId;
            this.itemStatusId = statusId;
            this.remarks = remarks;
            this.moveReasonId = ((int)moveReasonId);
        }
    }
}
