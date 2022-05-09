using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Axios_Assyst.Movements
{
    public class createMovement : Models.Endpoints._movement
    {
        public createMovement(int itemId, int moveReasonId, string remarks, int itemStatusId, int contactUserId = 0)
        {
            this.itemId = itemId;
            this.moveReasonId = moveReasonId;
            this.remarks = remarks;
            this.moveDate = DateTime.Now;
            this.contactUserId = contactUserId;
            this.itemStatusId = itemStatusId;
        }
    }
}
