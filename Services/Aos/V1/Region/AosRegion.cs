using System;
using System.Collections.Generic;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Aos.V1
{
    public class AosRegion
    {
        public static readonly Region CN_NORTH_4 = new Region("cn-north-4",
            "https://aos.cn-north-4.myhuaweicloud.com");
        public static readonly Region CN_SOUTH_1 = new Region("cn-south-1",
            "https://aos.cn-south-1.myhuaweicloud.com");
        public static readonly Region CN_EAST_3 = new Region("cn-east-3",
            "https://aos.cn-east-3.myhuaweicloud.com");
        public static readonly Region CN_NORTH_9 = new Region("cn-north-9",
            "https://aos.cn-north-9.myhuaweicloud.com");
        public static readonly Region CN_SOUTHWEST_2 = new Region("cn-southwest-2",
            "https://aos.cn-southwest-2.myhuaweicloud.com");
        public static readonly Region AP_SOUTHEAST_3 = new Region("ap-southeast-3",
            "https://aos.ap-southeast-3.myhuaweicloud.com");
        public static readonly Region AP_SOUTHEAST_2 = new Region("ap-southeast-2",
            "https://aos.ap-southeast-2.myhuaweicloud.com");
        public static readonly Region AP_SOUTHEAST_1 = new Region("ap-southeast-1",
            "https://aos.ap-southeast-1.myhuaweicloud.com");
        public static readonly Region AP_SOUTHEAST_4 = new Region("ap-southeast-4",
            "https://aos.ap-southeast-4.myhuaweicloud.com");
        public static readonly Region ME_EAST_1 = new Region("me-east-1",
            "https://aos.me-east-1.myhuaweicloud.com");
        public static readonly Region TR_WEST_1 = new Region("tr-west-1",
            "https://aos.tr-west-1.myhuaweicloud.com");
        
        private static readonly IRegionProvider Provider = RegionProviderChain.GetDefault("AOS");

        private static readonly Dictionary<string, Region> StaticFields = new Dictionary<string, Region>()
        {
                { "cn-north-4", CN_NORTH_4 },
                { "cn-south-1", CN_SOUTH_1 },
                { "cn-east-3", CN_EAST_3 },
                { "cn-north-9", CN_NORTH_9 },
                { "cn-southwest-2", CN_SOUTHWEST_2 },
                { "ap-southeast-3", AP_SOUTHEAST_3 },
                { "ap-southeast-2", AP_SOUTHEAST_2 },
                { "ap-southeast-1", AP_SOUTHEAST_1 },
                { "ap-southeast-4", AP_SOUTHEAST_4 },
                { "me-east-1", ME_EAST_1 },
                { "tr-west-1", TR_WEST_1 },
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

            throw new ArgumentException("Unexpected regionId: ", regionId);
        }
    }
}