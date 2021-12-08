using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Axios_Assyst.userItems
{
    public class create
    {
        protected int itemId;
        protected int userId;
        protected int licenseCount;
        protected string remarks;
        protected int linkReasonId;

        public create(int itemId, int userId, int licenseCount, string remarks, int linkReasonId)
        {
            this.itemId = itemId;
            this.userId = userId;
            this.licenseCount = licenseCount;
            this.remarks = remarks;
            this.linkReasonId = linkReasonId;
        }
    }
}
