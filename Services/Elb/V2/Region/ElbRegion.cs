using System;
using System.Collections.Generic;
using System.Linq;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Elb.V2
{
    public class ElbRegion
    {
        public static readonly Region EU_WEST_101 = new Region("eu-west-101",
            "https://elb.eu-west-101.myhuaweicloud.com");
        public static readonly Region AF_SOUTH_1 = new Region("af-south-1",
            "https://elb.af-south-1.myhuaweicloud.com");
        public static readonly Region CN_NORTH_4 = new Region("cn-north-4",
            "https://elb.cn-north-4.myhuaweicloud.com");
        public static readonly Region CN_NORTH_1 = new Region("cn-north-1",
            "https://elb.cn-north-1.myhuaweicloud.com");
        public static readonly Region CN_NORTH_2 = new Region("cn-north-2",
            "https://elb.cn-north-2.myhuaweicloud.com");
        public static readonly Region CN_EAST_2 = new Region("cn-east-2",
            "https://elb.cn-east-2.myhuaweicloud.com");
        public static readonly Region CN_EAST_3 = new Region("cn-east-3",
            "https://elb.cn-east-3.myhuaweicloud.com");
        public static readonly Region CN_SOUTH_1 = new Region("cn-south-1",
            "https://elb.cn-south-1.myhuaweicloud.com");
        public static readonly Region CN_SOUTH_2 = new Region("cn-south-2",
            "https://elb.cn-south-2.myhuaweicloud.com");
        public static readonly Region CN_SOUTHWEST_2 = new Region("cn-southwest-2",
            "https://elb.cn-southwest-2.myhuaweicloud.com");
        public static readonly Region AP_SOUTHEAST_2 = new Region("ap-southeast-2",
            "https://elb.ap-southeast-2.myhuaweicloud.com");
        public static readonly Region AP_SOUTHEAST_1 = new Region("ap-southeast-1",
            "https://elb.ap-southeast-1.myhuaweicloud.com");
        public static readonly Region AP_SOUTHEAST_3 = new Region("ap-southeast-3",
            "https://elb.ap-southeast-3.myhuaweicloud.com");
        public static readonly Region CN_NORTH_9 = new Region("cn-north-9",
            "https://elb.cn-north-9.myhuaweicloud.com");
        public static readonly Region LA_SOUTH_2 = new Region("la-south-2",
            "https://elb.la-south-2.myhuaweicloud.com");
        public static readonly Region SA_BRAZIL_1 = new Region("sa-brazil-1",
            "https://elb.sa-brazil-1.myhuaweicloud.com");
        public static readonly Region NA_MEXICO_1 = new Region("na-mexico-1",
            "https://elb.na-mexico-1.myhuaweicloud.com");
        public static readonly Region LA_NORTH_2 = new Region("la-north-2",
            "https://elb.la-north-2.myhuaweicloud.com");
        public static readonly Region AP_SOUTHEAST_4 = new Region("ap-southeast-4",
            "https://elb.ap-southeast-4.myhuaweicloud.com");
        public static readonly Region TR_WEST_1 = new Region("tr-west-1",
            "https://elb.tr-west-1.myhuaweicloud.com");
        public static readonly Region AE_AD_1 = new Region("ae-ad-1",
            "https://elb.ae-ad-1.myhuaweicloud.com");
        public static readonly Region EU_WEST_0 = new Region("eu-west-0",
            "https://elb.eu-west-0.myhuaweicloud.com");
        public static readonly Region ME_EAST_1 = new Region("me-east-1",
            "https://elb.me-east-1.myhuaweicloud.com");
        public static readonly Region MY_KUALALUMPUR_1 = new Region("my-kualalumpur-1",
            "https://elb.my-kualalumpur-1.myhuaweicloud.com");
        public static readonly Region RU_MOSCOW_1 = new Region("ru-moscow-1",
            "https://elb.ru-moscow-1.myhuaweicloud.com");
        
        private static readonly IRegionProvider Provider = RegionProviderChain.GetDefault("ELB");

        private static readonly Dictionary<string, Region> StaticFields = new Dictionary<string, Region>
        {
                { "eu-west-101", EU_WEST_101 },
                { "af-south-1", AF_SOUTH_1 },
                { "cn-north-4", CN_NORTH_4 },
                { "cn-north-1", CN_NORTH_1 },
                { "cn-north-2", CN_NORTH_2 },
                { "cn-east-2", CN_EAST_2 },
                { "cn-east-3", CN_EAST_3 },
                { "cn-south-1", CN_SOUTH_1 },
                { "cn-south-2", CN_SOUTH_2 },
                { "cn-southwest-2", CN_SOUTHWEST_2 },
                { "ap-southeast-2", AP_SOUTHEAST_2 },
                { "ap-southeast-1", AP_SOUTHEAST_1 },
                { "ap-southeast-3", AP_SOUTHEAST_3 },
                { "cn-north-9", CN_NORTH_9 },
                { "la-south-2", LA_SOUTH_2 },
                { "sa-brazil-1", SA_BRAZIL_1 },
                { "na-mexico-1", NA_MEXICO_1 },
                { "la-north-2", LA_NORTH_2 },
                { "ap-southeast-4", AP_SOUTHEAST_4 },
                { "tr-west-1", TR_WEST_1 },
                { "ae-ad-1", AE_AD_1 },
                { "eu-west-0", EU_WEST_0 },
                { "me-east-1", ME_EAST_1 },
                { "my-kualalumpur-1", MY_KUALALUMPUR_1 },
                { "ru-moscow-1", RU_MOSCOW_1 },
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

            throw new ArgumentException($"region id '{regionId}' is not in the following supported regions of service 'ELB': [{string.Join(", ", StaticFields.Keys.OrderBy(key => key))}]");
        }
    }
}