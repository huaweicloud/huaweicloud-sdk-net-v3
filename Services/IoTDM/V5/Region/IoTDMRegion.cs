using System;
using System.Collections.Generic;
using System.Linq;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.IoTDM.V5
{
    public class IoTDMRegion
    {
        public static readonly Region CN_NORTH_4 = new Region("cn-north-4",
            "https://iotda-mgmt.cn-north-4.myhuaweicloud.com");
        public static readonly Region CN_SOUTH_4 = new Region("cn-south-4",
            "https://iotda-mgmt.cn-south-4.myhuaweicloud.com");
        public static readonly Region CN_SOUTH_1 = new Region("cn-south-1",
            "https://iotda-mgmt.cn-south-1.myhuaweicloud.com");
        public static readonly Region CN_EAST_3 = new Region("cn-east-3",
            "https://iotda-mgmt.cn-east-3.myhuaweicloud.com");
        public static readonly Region AP_SOUTHEAST_3 = new Region("ap-southeast-3",
            "https://iotda-mgmt.ap-southeast-3.myhuaweicloud.com");
        public static readonly Region AP_SOUTHEAST_2 = new Region("ap-southeast-2",
            "https://iotda-mgmt.ap-southeast-2.myhuaweicloud.com");
        public static readonly Region AP_SOUTHEAST_1 = new Region("ap-southeast-1",
            "https://iotda-mgmt.ap-southeast-1.myhuaweicloud.com");
        public static readonly Region AF_SOUTH_1 = new Region("af-south-1",
            "https://iotda-mgmt.af-south-1.myhuaweicloud.com");
        public static readonly Region ME_EAST_1 = new Region("me-east-1",
            "https://iotda-mgmt.me-east-1.myhuaweicloud.com");
        public static readonly Region LA_SOUTH_2 = new Region("la-south-2",
            "https://iotda-mgmt.la-south-2.myhuaweicloud.com");
        
        private static readonly IRegionProvider Provider = RegionProviderChain.GetDefault("IOTDM");

        private static readonly Dictionary<string, Region> StaticFields = new Dictionary<string, Region>
        {
                { "cn-north-4", CN_NORTH_4 },
                { "cn-south-4", CN_SOUTH_4 },
                { "cn-south-1", CN_SOUTH_1 },
                { "cn-east-3", CN_EAST_3 },
                { "ap-southeast-3", AP_SOUTHEAST_3 },
                { "ap-southeast-2", AP_SOUTHEAST_2 },
                { "ap-southeast-1", AP_SOUTHEAST_1 },
                { "af-south-1", AF_SOUTH_1 },
                { "me-east-1", ME_EAST_1 },
                { "la-south-2", LA_SOUTH_2 },
        };

        public static Region ValueOf(string regionId)
        {
            if (string.IsNullOrEmpty(regionId))
            {
                throw new ArgumentNullException(regionId);
            }

            var region = Provider.GetRegion(regionId);
            if (region != null)
            {
                return region;
            }

            if (StaticFields.ContainsKey(regionId))
            {
                return StaticFields[regionId];
            }

            throw new ArgumentException($"region id '{regionId}' is not in the following supported regions of service 'IoTDM': [{string.Join(", ", StaticFields.Keys.OrderBy(key => key))}]");
        }
    }
}