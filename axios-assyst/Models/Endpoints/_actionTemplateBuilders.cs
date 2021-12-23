using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Axios_Assyst.Models.Endpoints
{
    public class _actionTemplateBuilders : Shared._base
    {
        public int? actionTypeId { get; set; }
        public int? buildingId { get; set; }
        public int? categoryId { get; set; }
        public int? emailTemplateId { get; set; }
        public int? locType { get; set; }
        public int? majorCategoryId { get; set; }
        public int? siteAreaId { get; set; }
        public int? siteId { get; set; }
        public int? territoryId { get; set; }
    }
}
