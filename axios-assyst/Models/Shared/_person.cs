using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Axios_Assyst.Models.Shared
{
    // This class contains common properties for a person record (assystUser, contactUser)
    public class _person : _resource
    {
        public string emailAddress;
        public decimal latitude;
        public string loginName;
        public decimal longitude;
        public string officeTelephone;
        public string officeTelephoneExtension;
        public int? roleId;
        public string staffNumber;
        public bool? anetLicence;
        public int? assystUserAliasId;
        public string assystUserAliasShortCode;
        public int? departmentId;
        public int? equivalentUserId;
        public string firstName;
        public int? licenceRoleId;
        public int? managerId;
        public string middleName;
        public int? roomId;
        public string workMobile;
    }
}
