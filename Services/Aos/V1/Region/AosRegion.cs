using System;
using System.Collections.Generic;
using System.Linq;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Aos.V1
{
    public class AosRegion
    {
        public static readonly Region CN_NORTH_4 = new Region("cn-north-4",
            "https://rfs.cn-north-4.myhuaweicloud.com");
        public static readonly Region CN_SOUTH_1 = new Region("cn-south-1",
            "https://rfs.cn-south-1.myhuaweicloud.com");
        public static readonly Region CN_EAST_3 = new Region("cn-east-3",
            "https://rfs.cn-east-3.myhuaweicloud.com");
        public static readonly Region CN_EAST_4 = new Region("cn-east-4",
            "https://rfs.cn-east-4.myhuaweicloud.com");
        public static readonly Region CN_NORTH_9 = new Region("cn-north-9",
            "https://rfs.cn-north-9.myhuaweicloud.com");
        public static readonly Region CN_SOUTHWEST_2 = new Region("cn-southwest-2",
            "https://rfs.cn-southwest-2.myhuaweicloud.com");
        public static readonly Region AP_SOUTHEAST_3 = new Region("ap-southeast-3",
            "https://rfs.ap-southeast-3.myhuaweicloud.com");
        public static readonly Region AP_SOUTHEAST_2 = new Region("ap-southeast-2",
            "https://rfs.ap-southeast-2.myhuaweicloud.com");
        public static readonly Region AP_SOUTHEAST_1 = new Region("ap-southeast-1",
            "https://rfs.ap-southeast-1.myhuaweicloud.com");
        public static readonly Region AP_SOUTHEAST_4 = new Region("ap-southeast-4",
            "https://rfs.ap-southeast-4.myhuaweicloud.com");
        public static readonly Region MY_KUALALUMPUR_1 = new Region("my-kualalumpur-1",
            "https://rfs.my-kualalumpur-1.myhuaweicloud.com");
        public static readonly Region ME_EAST_1 = new Region("me-east-1",
            "https://rfs.me-east-1.myhuaweicloud.com");
        public static readonly Region TR_WEST_1 = new Region("tr-west-1",
            "https://rfs.tr-west-1.myhuaweicloud.com");
        public static readonly Region LA_SOUTH_2 = new Region("la-south-2",
            "https://rfs.la-south-2.myhuaweicloud.com");
        public static readonly Region SA_BRAZIL_1 = new Region("sa-brazil-1",
            "https://rfs.sa-brazil-1.myhuaweicloud.com");
        public static readonly Region LA_NORTH_2 = new Region("la-north-2",
            "https://rfs.la-north-2.myhuaweicloud.com");
        public static readonly Region AF_SOUTH_1 = new Region("af-south-1",
            "https://rfs.af-south-1.myhuaweicloud.com");
        public static readonly Region EU_WEST_101 = new Region("eu-west-101",
            "https://aos.myhuaweicloud.eu");
        public static readonly Region NA_MEXICO_1 = new Region("na-mexico-1",
            "https://rfs.na-mexico-1.myhuaweicloud.com");
        public static readonly Region CN_NORTH_11 = new Region("cn-north-11",
            "https://rfs.cn-north-11.myhuaweicloud.com");
        public static readonly Region CN_EAST_5 = new Region("cn-east-5",
            "https://rfs.cn-east-5.myhuaweicloud.com");
        public static readonly Region AF_NORTH_1 = new Region("af-north-1",
            "https://rfs.af-north-1.myhuaweicloud.com");
        public static readonly Region CN_NORTH_12 = new Region("cn-north-12",
            "https://rfs.cn-north-12.myhuaweicloud.com");
        
        private static readonly IRegionProvider Provider = RegionProviderChain.GetDefault("AOS");

        private static readonly Dictionary<string, Region> StaticFields = new Dictionary<string, Region>
        {
                { "cn-north-4", CN_NORTH_4 },
                { "cn-south-1", CN_SOUTH_1 },
                { "cn-east-3", CN_EAST_3 },
                { "cn-east-4", CN_EAST_4 },
                { "cn-north-9", CN_NORTH_9 },
                { "cn-southwest-2", CN_SOUTHWEST_2 },
                { "ap-southeast-3", AP_SOUTHEAST_3 },
                { "ap-southeast-2", AP_SOUTHEAST_2 },
                { "ap-southeast-1", AP_SOUTHEAST_1 },
                { "ap-southeast-4", AP_SOUTHEAST_4 },
                { "my-kualalumpur-1", MY_KUALALUMPUR_1 },
                { "me-east-1", ME_EAST_1 },
                { "tr-west-1", TR_WEST_1 },
                { "la-south-2", LA_SOUTH_2 },
                { "sa-brazil-1", SA_BRAZIL_1 },
                { "la-north-2", LA_NORTH_2 },
                { "af-south-1", AF_SOUTH_1 },
                { "eu-west-101", EU_WEST_101 },
                { "na-mexico-1", NA_MEXICO_1 },
                { "cn-north-11", CN_NORTH_11 },
                { "cn-east-5", CN_EAST_5 },
                { "af-north-1", AF_NORTH_1 },
                { "cn-north-12", CN_NORTH_12 },
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

            throw new ArgumentException($"region id '{regionId}' is not in the following supported regions of service 'AOS': [{string.Join(", ", StaticFields.Keys.OrderBy(key => key))}]");
        }
    }
}