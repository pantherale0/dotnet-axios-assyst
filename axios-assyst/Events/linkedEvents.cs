using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Axios_Assyst.Events
{
    public static class linkedEvents
    {
        public static Models.Endpoints._linkedEventGroup createLinkedEvent()
        {
            Models.Endpoints._linkedEventGroup linkedEventGroup = new Models.Endpoints._linkedEventGroup();
            linkedEventGroup.id = 0;
            return linkedEventGroup;
        }

        public static Models.Endpoints._linkedEventGroup updateLinkedEvent()
        {
            Models.Endpoints._linkedEventGroup linkedEventGroup = new Models.Endpoints._linkedEventGroup();
            linkedEventGroup.id = 0;
            return linkedEventGroup ;
        }
    }
}
