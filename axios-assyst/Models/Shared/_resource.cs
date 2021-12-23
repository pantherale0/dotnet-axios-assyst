using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Axios_Assyst.Models.Shared
{
    // Defines a common resource that is shared between person, supplier resource types
    public class _resource : _base
    {
        public int? csgId { get; set; }
        public string name { get; set; }
        public string shortCode { get; set; }
        public bool? csgActive { get; set; }
        public bool? csgEnabled { get; set; }
        public string csgShortCode { get; set; }
        public int? imageId { get; set; }
        public int? docketId { get; set; }
    }
}
