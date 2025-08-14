using System;
using System.Collections.Generic;
using System.Linq;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.GaussDBforNoSQL.V3
{
    public class GaussDBforNoSQLRegion
    {
        public static readonly Region AF_SOUTH_1 = new Region("af-south-1",
            "https://gaussdb-nosql.af-south-1.myhuaweicloud.com");
        public static readonly Region CN_NORTH_4 = new Region("cn-north-4",
            "https://gaussdb-nosql.cn-north-4.myhuaweicloud.com");
        public static readonly Region CN_NORTH_1 = new Region("cn-north-1",
            "https://gaussdb-nosql.cn-north-1.myhuaweicloud.com");
        public static readonly Region CN_EAST_2 = new Region("cn-east-2",
            "https://gaussdb-nosql.cn-east-2.myhuaweicloud.com");
        public static readonly Region CN_EAST_3 = new Region("cn-east-3",
            "https://gaussdb-nosql.cn-east-3.myhuaweicloud.com");
        public static readonly Region CN_SOUTH_1 = new Region("cn-south-1",
            "https://gaussdb-nosql.cn-south-1.myhuaweicloud.com");
        public static readonly Region CN_SOUTHWEST_2 = new Region("cn-southwest-2",
            "https://gaussdb-nosql.cn-southwest-2.myhuaweicloud.com");
        public static readonly Region AP_SOUTHEAST_2 = new Region("ap-southeast-2",
            "https://gaussdb-nosql.ap-southeast-2.myhuaweicloud.com");
        public static readonly Region AP_SOUTHEAST_1 = new Region("ap-southeast-1",
            "https://gaussdb-nosql.ap-southeast-1.myhuaweicloud.com");
        public static readonly Region AP_SOUTHEAST_3 = new Region("ap-southeast-3",
            "https://gaussdb-nosql.ap-southeast-3.myhuaweicloud.com");
        public static readonly Region AP_SOUTHEAST_4 = new Region("ap-southeast-4",
            "https://gaussdb-nosql.ap-southeast-4.myhuaweicloud.com");
        public static readonly Region AP_SOUTHEAST_5 = new Region("ap-southeast-5",
            "https://gaussdb-nosql.ap-southeast-5.myhuaweicloud.com");
        public static readonly Region ME_EAST_1 = new Region("me-east-1",
            "https://gaussdb-nosql.me-east-1.myhuaweicloud.com");
        public static readonly Region CN_EAST_4 = new Region("cn-east-4",
            "https://gaussdb-nosql.cn-east-4.myhuaweicloud.com");
        public static readonly Region CN_SOUTH_4 = new Region("cn-south-4",
            "https://nosql-gemini.cn-south-4.myhuaweicloud.com");
        public static readonly Region CN_SOUTHWEST_3 = new Region("cn-southwest-3",
            "https://gaussdb-nosql.cn-southwest-3.myhuaweicloud.com");
        public static readonly Region TR_WEST_1 = new Region("tr-west-1",
            "https://gaussdb-nosql.tr-west-1.myhuaweicloud.com");
        public static readonly Region RU_NORTHWEST_2 = new Region("ru-northwest-2",
            "https://gaussdb-nosql.ru-northwest-2.myhuaweicloud.com");
        public static readonly Region CN_SOUTH_2 = new Region("cn-south-2",
            "https://gaussdb-nosql.cn-south-2.myhuaweicloud.com");
        public static readonly Region CN_NORTH_2 = new Region("cn-north-2",
            "https://gaussdb-nosql.cn-north-2.myhuaweicloud.com");
        public static readonly Region LA_NORTH_2 = new Region("la-north-2",
            "https://gaussdb-nosql.la-north-2.myhuaweicloud.com");
        public static readonly Region SA_BRAZIL_1 = new Region("sa-brazil-1",
            "https://gaussdb-nosql.sa-brazil-1.myhuaweicloud.com");
        public static readonly Region LA_SOUTH_2 = new Region("la-south-2",
            "https://gaussdb-nosql.la-south-2.myhuaweicloud.com");
        public static readonly Region CN_NORTH_9 = new Region("cn-north-9",
            "https://gaussdb-nosql.cn-north-9.myhuaweicloud.com");
        public static readonly Region EU_WEST_101 = new Region("eu-west-101",
            "https://gaussdb-nosql.eu-west-101.myhuaweicloud.eu");
        
        private static readonly IRegionProvider Provider = RegionProviderChain.GetDefault("GAUSSDBFORNOSQL");

        private static readonly Dictionary<string, Region> StaticFields = new Dictionary<string, Region>
        {
                { "af-south-1", AF_SOUTH_1 },
                { "cn-north-4", CN_NORTH_4 },
                { "cn-north-1", CN_NORTH_1 },
                { "cn-east-2", CN_EAST_2 },
                { "cn-east-3", CN_EAST_3 },
                { "cn-south-1", CN_SOUTH_1 },
                { "cn-southwest-2", CN_SOUTHWEST_2 },
                { "ap-southeast-2", AP_SOUTHEAST_2 },
                { "ap-southeast-1", AP_SOUTHEAST_1 },
                { "ap-southeast-3", AP_SOUTHEAST_3 },
                { "ap-southeast-4", AP_SOUTHEAST_4 },
                { "ap-southeast-5", AP_SOUTHEAST_5 },
                { "me-east-1", ME_EAST_1 },
                { "cn-east-4", CN_EAST_4 },
                { "cn-south-4", CN_SOUTH_4 },
                { "cn-southwest-3", CN_SOUTHWEST_3 },
                { "tr-west-1", TR_WEST_1 },
                { "ru-northwest-2", RU_NORTHWEST_2 },
                { "cn-south-2", CN_SOUTH_2 },
                { "cn-north-2", CN_NORTH_2 },
                { "la-north-2", LA_NORTH_2 },
                { "sa-brazil-1", SA_BRAZIL_1 },
                { "la-south-2", LA_SOUTH_2 },
                { "cn-north-9", CN_NORTH_9 },
                { "eu-west-101", EU_WEST_101 },
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

            throw new ArgumentException($"region id '{regionId}' is not in the following supported regions of service 'GaussDBforNoSQL': [{string.Join(", ", StaticFields.Keys.OrderBy(key => key))}]");
        }
    }
}