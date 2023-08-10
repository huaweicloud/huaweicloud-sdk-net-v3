using System;
using System.Collections.Generic;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Dns.V2
{
    public class DnsRegion
    {
        public static readonly Region CN_EAST_2 = new Region("cn-east-2",
            "https://dns.cn-east-2.myhuaweicloud.com");
        public static readonly Region CN_EAST_3 = new Region("cn-east-3",
            "https://dns.cn-east-3.myhuaweicloud.com");
        public static readonly Region CN_NORTH_1 = new Region("cn-north-1",
            "https://dns.cn-north-1.myhuaweicloud.com");
        public static readonly Region CN_NORTH_4 = new Region("cn-north-4",
            "https://dns.cn-north-4.myhuaweicloud.com");
        public static readonly Region CN_SOUTH_1 = new Region("cn-south-1",
            "https://dns.cn-south-1.myhuaweicloud.com");
        public static readonly Region CN_SOUTHWEST_2 = new Region("cn-southwest-2",
            "https://dns.cn-southwest-2.myhuaweicloud.com");
        public static readonly Region AF_SOUTH_1 = new Region("af-south-1",
            "https://dns.af-south-1.myhuaweicloud.com");
        public static readonly Region AP_SOUTHEAST_1 = new Region("ap-southeast-1",
            "https://dns.ap-southeast-1.myhuaweicloud.com");
        public static readonly Region AP_SOUTHEAST_2 = new Region("ap-southeast-2",
            "https://dns.ap-southeast-2.myhuaweicloud.com");
        public static readonly Region AP_SOUTHEAST_3 = new Region("ap-southeast-3",
            "https://dns.ap-southeast-3.myhuaweicloud.com");
        public static readonly Region SA_BRAZIL_1 = new Region("sa-brazil-1",
            "https://dns.sa-brazil-1.myhuaweicloud.com");
        public static readonly Region LA_SOUTH_2 = new Region("la-south-2",
            "https://dns.la-south-2.myhuaweicloud.com");
        public static readonly Region LA_NORTH_2 = new Region("la-north-2",
            "https://dns.la-north-2.myhuaweicloud.com");
        public static readonly Region NA_MEXICO_1 = new Region("na-mexico-1",
            "https://dns.na-mexico-1.myhuaweicloud.com");
        public static readonly Region CN_NORTH_9 = new Region("cn-north-9",
            "https://dns.cn-north-9.myhuaweicloud.com");
        public static readonly Region CN_NORTH_2 = new Region("cn-north-2",
            "https://dns.cn-north-2.myhuaweicloud.com");
        public static readonly Region CN_SOUTH_2 = new Region("cn-south-2",
            "https://dns.cn-south-2.myhuaweicloud.com");
        public static readonly Region AP_SOUTHEAST_4 = new Region("ap-southeast-4",
            "https://dns.ap-southeast-4.myhuaweicloud.com");
        
        private static readonly Dictionary<string, Region> StaticFields = new Dictionary<string, Region>()
        {
                { "cn-east-2", CN_EAST_2 },
                { "cn-east-3", CN_EAST_3 },
                { "cn-north-1", CN_NORTH_1 },
                { "cn-north-4", CN_NORTH_4 },
                { "cn-south-1", CN_SOUTH_1 },
                { "cn-southwest-2", CN_SOUTHWEST_2 },
                { "af-south-1", AF_SOUTH_1 },
                { "ap-southeast-1", AP_SOUTHEAST_1 },
                { "ap-southeast-2", AP_SOUTHEAST_2 },
                { "ap-southeast-3", AP_SOUTHEAST_3 },
                { "sa-brazil-1", SA_BRAZIL_1 },
                { "la-south-2", LA_SOUTH_2 },
                { "la-north-2", LA_NORTH_2 },
                { "na-mexico-1", NA_MEXICO_1 },
                { "cn-north-9", CN_NORTH_9 },
                { "cn-north-2", CN_NORTH_2 },
                { "cn-south-2", CN_SOUTH_2 },
                { "ap-southeast-4", AP_SOUTHEAST_4 },
        };

        public static Region ValueOf(string regionId)
        {
            if (string.IsNullOrEmpty(regionId))
            {
                throw new ArgumentNullException(regionId);
            }

            if (StaticFields.ContainsKey(regionId))
            {
                return StaticFields[regionId];
            }

            throw new ArgumentException("Unexpected regionId: ", regionId);
        }
    }
}