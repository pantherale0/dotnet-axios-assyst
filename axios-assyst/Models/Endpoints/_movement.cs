using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Axios_Assyst.Models.Endpoints
{
    public class _movement : Shared._base
    {
        public int? itemId;
        public DateTime? moveDate;
        public int? moveReasonId;
        public int? roomId;
        public int? departmentId;
        public int? contactUserId;
        public int? itemStatusId;
        public int? costCentreId;
        public int? slaId;

        public _movement() // Allow definition for an empty object
        {
            this.moveDate = DateTime.Now;
        }

        public _movement(int itemId, string remarks, int moveReasonId, int itemStatusId) // A basic movement with no change to contact user etc.
        {
            this.itemId = itemId;
            this.remarks = remarks;
            this.moveReasonId = moveReasonId;
            this.itemStatusId = itemStatusId;
            this.moveDate = DateTime.Now;
        }

        public _movement(int itemId, string remarks, int moveReasonId, int itemStatusId, int contactUserId) // Basic movement with contactUserId
        {
            this.itemId = itemId;
            this.remarks = remarks;
            this.moveReasonId = moveReasonId;
            this.contactUserId = contactUserId;
            this.itemStatusId = itemStatusId;
            this.moveDate = DateTime.Now;
        }

        public _movement(int itemId, string remarks, int moveReasonId, int itemStatusId, int contactUserId, DateTime moveDate) // Defines same as above but with move date
        {
            this.itemId = itemId;
            this.remarks = remarks;
            this.moveReasonId = moveReasonId;
            this.contactUserId = contactUserId;
            this.itemStatusId = itemStatusId;
            this.moveDate = moveDate;
        }
    }
}
