using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Axios_Assyst
{
    public partial class Enums
    {
        public enum moveReasonId
        {
            CustomerRequest = 1,
            InitialLoad=2,
            Replacement=3,
            ProjectMovement=4,
            IllegalMovement=5,
            DataChange = 6,
            AssetAllocation=7,
            StockAllocation=8,
            BAULocationChange=9,
            Damaged=10,
            Missing=11,
            Decommission=12,
            Build=13,
            HPSupplierReplacement=14,
            UpdataSupplierReplacement=15,
            ReAssetTagged=16,
            ShippedToHPE=17,
            SignedIn=18,
            SignedOut=19,
            ImportCorrection=20,
            TransferToSchools=21,
            DeployedToNCHC=22,
            NewDeviceFromSupplier=23,
            AssetsToGYBCStock=24,
            PendingDeviceRefresh=25,
            PendingDeviceRefreshDelivery=26,
            DeviceRefreshSuccess=27,
            DeviceRefreshUnsuccessfulDelivery=28
        }
    }
}
