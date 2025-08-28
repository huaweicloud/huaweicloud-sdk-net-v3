using System;
using System.Collections.Generic;
using System.Linq;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Ddm.V1
{
    public class DdmRegion
    {
        public static readonly Region EU_WEST_101 = new Region("eu-west-101",
            "https://ddm.eu-west-101.myhuaweicloud.eu");
        public static readonly Region CN_SOUTHWEST_2 = new Region("cn-southwest-2",
            "https://ddm.cn-southwest-2.myhuaweicloud.com");
        public static readonly Region CN_SOUTH_2 = new Region("cn-south-2",
            "https://ddm.cn-south-2.myhuaweicloud.com");
        public static readonly Region CN_NORTH_4 = new Region("cn-north-4",
            "https://ddm.cn-north-4.myhuaweicloud.com");
        public static readonly Region CN_NORTH_9 = new Region("cn-north-9",
            "https://ddm.cn-north-9.myhuaweicloud.com");
        public static readonly Region CN_EAST_3 = new Region("cn-east-3",
            "https://ddm.cn-east-3.myhuaweicloud.com");
        public static readonly Region CN_EAST_2 = new Region("cn-east-2",
            "https://ddm.cn-east-2.myhuaweicloud.com");
        public static readonly Region CN_NORTH_1 = new Region("cn-north-1",
            "https://ddm.cn-north-1.myhuaweicloud.com");
        public static readonly Region CN_SOUTH_1 = new Region("cn-south-1",
            "https://ddm.cn-south-1.myhuaweicloud.com");
        public static readonly Region AP_SOUTHEAST_1 = new Region("ap-southeast-1",
            "https://ddm.ap-southeast-1.myhuaweicloud.com");
        public static readonly Region LA_NORTH_2 = new Region("la-north-2",
            "https://ddm.la-north-2.myhuaweicloud.com");
        public static readonly Region SA_BRAZIL_1 = new Region("sa-brazil-1",
            "https://ddm.sa-brazil-1.myhuaweicloud.com");
        public static readonly Region LA_SOUTH_2 = new Region("la-south-2",
            "https://ddm.la-south-2.myhuaweicloud.com");
        public static readonly Region MY_KUALALUMPUR_1 = new Region("my-kualalumpur-1",
            "https://ddm.my-kualalumpur-1.myhuaweicloud.com");
        public static readonly Region RU_MOSCOW_1 = new Region("ru-moscow-1",
            "https://ddm.ru-moscow-1.myhuaweicloud.com");
        public static readonly Region AE_AD_1 = new Region("ae-ad-1",
            "https://ddm.ae-ad-1.myhuaweicloud.com");
        
        private static readonly IRegionProvider Provider = RegionProviderChain.GetDefault("DDM");

        private static readonly Dictionary<string, Region> StaticFields = new Dictionary<string, Region>
        {
                { "eu-west-101", EU_WEST_101 },
                { "cn-southwest-2", CN_SOUTHWEST_2 },
                { "cn-south-2", CN_SOUTH_2 },
                { "cn-north-4", CN_NORTH_4 },
                { "cn-north-9", CN_NORTH_9 },
                { "cn-east-3", CN_EAST_3 },
                { "cn-east-2", CN_EAST_2 },
                { "cn-north-1", CN_NORTH_1 },
                { "cn-south-1", CN_SOUTH_1 },
                { "ap-southeast-1", AP_SOUTHEAST_1 },
                { "la-north-2", LA_NORTH_2 },
                { "sa-brazil-1", SA_BRAZIL_1 },
                { "la-south-2", LA_SOUTH_2 },
                { "my-kualalumpur-1", MY_KUALALUMPUR_1 },
                { "ru-moscow-1", RU_MOSCOW_1 },
                { "ae-ad-1", AE_AD_1 },
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

            throw new ArgumentException($"region id '{regionId}' is not in the following supported regions of service 'DDM': [{string.Join(", ", StaticFields.Keys.OrderBy(key => key))}]");
        }
    }
}