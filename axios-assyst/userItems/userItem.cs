using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Axios_Assyst.userItems
{
    public class userItem
    {
        public string remarks = "";
        public bool? discontinued;
        public int? itemId;
        public int? numUsers;
        public int? userId;
        public int? userItemAssociationReasonId;

        public userItem() { } // Defined to allow an empty class
        public userItem(string remarks, bool discontinued) // Defined to allow discontinue of an item
        {
            this.remarks = remarks;
            this.discontinued = discontinued;
        }
        
        public userItem(int itemId, int numUsers, int userId, int userItemAssociationReasonId, string remarks) // Defined to allow creation of a new userItem
        {
            this.itemId = itemId;
            this.numUsers = numUsers;
            this.userId = userId;
            this.userItemAssociationReasonId = userItemAssociationReasonId;
            this.remarks=remarks;
        }
    }
}
