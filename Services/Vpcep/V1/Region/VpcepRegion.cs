using System;
using System.Collections.Generic;
using System.Linq;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Vpcep.V1
{
    public class VpcepRegion
    {
        public static readonly Region CN_NORTH_4 = new Region("cn-north-4",
            "https://vpcep.cn-north-4.myhuaweicloud.com");
        public static readonly Region CN_NORTH_1 = new Region("cn-north-1",
            "https://vpcep.cn-north-1.myhuaweicloud.com");
        public static readonly Region CN_EAST_2 = new Region("cn-east-2",
            "https://vpcep.cn-east-2.myhuaweicloud.com");
        public static readonly Region CN_EAST_3 = new Region("cn-east-3",
            "https://vpcep.cn-east-3.myhuaweicloud.com");
        public static readonly Region CN_SOUTH_1 = new Region("cn-south-1",
            "https://vpcep.cn-south-1.myhuaweicloud.com");
        public static readonly Region CN_SOUTHWEST_2 = new Region("cn-southwest-2",
            "https://vpcep.cn-southwest-2.myhuaweicloud.com");
        public static readonly Region AP_SOUTHEAST_1 = new Region("ap-southeast-1",
            "https://vpcep.ap-southeast-1.myhuaweicloud.com");
        public static readonly Region LA_SOUTH_2 = new Region("la-south-2",
            "https://vpcep.la-south-2.myhuaweicloud.com");
        public static readonly Region NA_MEXICO_1 = new Region("na-mexico-1",
            "https://vpcep.na-mexico-1.myhuaweicloud.com");
        public static readonly Region CN_NORTH_9 = new Region("cn-north-9",
            "https://vpcep.cn-north-9.myhuaweicloud.com");
        public static readonly Region AP_SOUTHEAST_3 = new Region("ap-southeast-3",
            "https://vpcep.ap-southeast-3.myhuaweicloud.com");
        public static readonly Region AP_SOUTHEAST_2 = new Region("ap-southeast-2",
            "https://vpcep.ap-southeast-2.myhuaweicloud.com");
        public static readonly Region CN_NORTH_2 = new Region("cn-north-2",
            "https://vpcep.cn-north-2.myhuaweicloud.com");
        public static readonly Region AF_SOUTH_1 = new Region("af-south-1",
            "https://vpcep.af-south-1.myhuaweicloud.com");
        public static readonly Region CN_SOUTH_2 = new Region("cn-south-2",
            "https://vpcep.cn-south-2.myhuaweicloud.com");
        public static readonly Region SA_BRAZIL_1 = new Region("sa-brazil-1",
            "https://vpcep.sa-brazil-1.myhuaweicloud.com");
        public static readonly Region LA_NORTH_2 = new Region("la-north-2",
            "https://vpcep.la-north-2.myhuaweicloud.com");
        public static readonly Region TR_WEST_1 = new Region("tr-west-1",
            "https://vpcep.tr-west-1.myhuaweicloud.com");
        public static readonly Region EU_WEST_101 = new Region("eu-west-101",
            "https://vpcep.eu-west-101.myhuaweicloud.eu");
        public static readonly Region AP_SOUTHEAST_4 = new Region("ap-southeast-4",
            "https://vpcep.ap-southeast-4.myhuaweicloud.com");
        public static readonly Region EU_WEST_0 = new Region("eu-west-0",
            "https://vpcep.eu-west-0.myhuaweicloud.com");
        public static readonly Region MY_KUALALUMPUR_1 = new Region("my-kualalumpur-1",
            "https://vpcep.my-kualalumpur-1.myhuaweicloud.com");
        public static readonly Region AE_AD_1 = new Region("ae-ad-1",
            "https://vpcep.ae-ad-1.myhuaweicloud.com");
        public static readonly Region RU_MOSCOW_1 = new Region("ru-moscow-1",
            "https://vpcep.ru-moscow-1.myhuaweicloud.com");
        public static readonly Region CN_EAST_5 = new Region("cn-east-5",
            "https://vpcep.cn-east-5.myhuaweicloud.com");
        public static readonly Region CN_SOUTH_4 = new Region("cn-south-4",
            "https://vpcep.cn-south-4.myhuaweicloud.com");
        public static readonly Region ME_EAST_1 = new Region("me-east-1",
            "https://vpcep.me-east-1.myhuaweicloud.com");
        public static readonly Region RU_NORTHWEST_2 = new Region("ru-northwest-2",
            "https://vpcep.ru-northwest-2.myhuaweicloud.com");
        public static readonly Region CN_NORTH_11 = new Region("cn-north-11",
            "https://vpcep.cn-north-11.myhuaweicloud.com");
        public static readonly Region CN_EAST_4 = new Region("cn-east-4",
            "https://vpcep.cn-east-4.myhuaweicloud.com");
        public static readonly Region AF_NORTH_1 = new Region("af-north-1",
            "https://vpcep.af-north-1.myhuaweicloud.com");
        public static readonly Region AP_SOUTHEAST_5 = new Region("ap-southeast-5",
            "https://vpcep.ap-southeast-5.myhuaweicloud.com");
        
        private static readonly IRegionProvider Provider = RegionProviderChain.GetDefault("VPCEP");

        private static readonly Dictionary<string, Region> StaticFields = new Dictionary<string, Region>
        {
                { "cn-north-4", CN_NORTH_4 },
                { "cn-north-1", CN_NORTH_1 },
                { "cn-east-2", CN_EAST_2 },
                { "cn-east-3", CN_EAST_3 },
                { "cn-south-1", CN_SOUTH_1 },
                { "cn-southwest-2", CN_SOUTHWEST_2 },
                { "ap-southeast-1", AP_SOUTHEAST_1 },
                { "la-south-2", LA_SOUTH_2 },
                { "na-mexico-1", NA_MEXICO_1 },
                { "cn-north-9", CN_NORTH_9 },
                { "ap-southeast-3", AP_SOUTHEAST_3 },
                { "ap-southeast-2", AP_SOUTHEAST_2 },
                { "cn-north-2", CN_NORTH_2 },
                { "af-south-1", AF_SOUTH_1 },
                { "cn-south-2", CN_SOUTH_2 },
                { "sa-brazil-1", SA_BRAZIL_1 },
                { "la-north-2", LA_NORTH_2 },
                { "tr-west-1", TR_WEST_1 },
                { "eu-west-101", EU_WEST_101 },
                { "ap-southeast-4", AP_SOUTHEAST_4 },
                { "eu-west-0", EU_WEST_0 },
                { "my-kualalumpur-1", MY_KUALALUMPUR_1 },
                { "ae-ad-1", AE_AD_1 },
                { "ru-moscow-1", RU_MOSCOW_1 },
                { "cn-east-5", CN_EAST_5 },
                { "cn-south-4", CN_SOUTH_4 },
                { "me-east-1", ME_EAST_1 },
                { "ru-northwest-2", RU_NORTHWEST_2 },
                { "cn-north-11", CN_NORTH_11 },
                { "cn-east-4", CN_EAST_4 },
                { "af-north-1", AF_NORTH_1 },
                { "ap-southeast-5", AP_SOUTHEAST_5 },
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

            throw new ArgumentException($"region id '{regionId}' is not in the following supported regions of service 'VPCEP': [{string.Join(", ", StaticFields.Keys.OrderBy(key => key))}]");
        }
    }
}