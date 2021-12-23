using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Axios_Assyst.Models.Endpoints
{
    public class _contactUser : Shared._person
    {
        public bool? contactBleep;
        public bool? contactFax;
        public bool? contactMail;
        public bool? contactPrint;
        public bool? contactTele;
        public int? costCentreId; 
        public int? defaultSlaId;
        public int? orderApprovalThreshold;
    }
}
