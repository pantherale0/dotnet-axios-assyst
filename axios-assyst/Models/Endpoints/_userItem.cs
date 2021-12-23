using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Axios_Assyst.Models.Endpoints
{
    public class _userItem : Shared._base
    {
        public string accessNote { get; set; }
        public int? defaultSlaId { get; set; }
        public int? itemId { get; set; }
        public int? numUsers { get; set; }
        public int? userId { get; set; }
        public int? userItemAssociationReasonId { get; set; }
        
    }
}
