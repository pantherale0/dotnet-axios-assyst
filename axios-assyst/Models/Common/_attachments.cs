using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Axios_Assyst.Models.Common
{
    public class _attachments
    {
        public string name { get; set; }
        public string attachment { get; set; }
        public bool? attachmentToSend { get; set; }
        public int? attachmentType { get; set; }
        public bool? deleteAfterSend { get; set; }
        public string fileName { get; set; }
        public string linkedObjectClassName { get; set; }
        public int? linkedObjectId { get; set; }
        public int? linkedObjectTypeId { get; set; }
    }
}
