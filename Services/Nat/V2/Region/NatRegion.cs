using System;
using System.Collections.Generic;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Nat.V2
{
    public class NatRegion
    {
        public static readonly Region AF_SOUTH_1 = new Region("af-south-1",
            "https://nat.af-south-1.myhuaweicloud.com");
        public static readonly Region CN_NORTH_4 = new Region("cn-north-4",
            "https://nat.cn-north-4.myhuaweicloud.com");
        public static readonly Region CN_NORTH_1 = new Region("cn-north-1",
            "https://nat.cn-north-1.myhuaweicloud.com");
        public static readonly Region CN_EAST_2 = new Region("cn-east-2",
            "https://nat.cn-east-2.myhuaweicloud.com");
        public static readonly Region CN_EAST_3 = new Region("cn-east-3",
            "https://nat.cn-east-3.myhuaweicloud.com");
        public static readonly Region CN_SOUTH_1 = new Region("cn-south-1",
            "https://nat.cn-south-1.myhuaweicloud.com");
        public static readonly Region CN_SOUTHWEST_2 = new Region("cn-southwest-2",
            "https://nat.cn-southwest-2.myhuaweicloud.com");
        public static readonly Region AP_SOUTHEAST_2 = new Region("ap-southeast-2",
            "https://nat.ap-southeast-2.myhuaweicloud.com");
        public static readonly Region AP_SOUTHEAST_1 = new Region("ap-southeast-1",
            "https://nat.ap-southeast-1.myhuaweicloud.com");
        public static readonly Region AP_SOUTHEAST_3 = new Region("ap-southeast-3",
            "https://nat.ap-southeast-3.myhuaweicloud.com");
        public static readonly Region CN_SOUTH_2 = new Region("cn-south-2",
            "https://nat.cn-south-2.myhuaweicloud.com");
        public static readonly Region CN_NORTH_2 = new Region("cn-north-2",
            "https://nat.cn-north-2.myhuaweicloud.com");
        public static readonly Region RU_NORTHWEST_2 = new Region("ru-northwest-2",
            "https://nat.ru-northwest-2.myhuaweicloud.com");
        public static readonly Region NA_MEXICO_1 = new Region("na-mexico-1",
            "https://nat.na-mexico-1.myhuaweicloud.com");
        public static readonly Region SA_BRAZIL_1 = new Region("sa-brazil-1",
            "https://nat.sa-brazil-1.myhuaweicloud.com");
        public static readonly Region LA_SOUTH_2 = new Region("la-south-2",
            "https://nat.la-south-2.myhuaweicloud.com");
        public static readonly Region LA_NORTH_2 = new Region("la-north-2",
            "https://nat.la-north-2.myhuaweicloud.com");
        public static readonly Region CN_NORTH_9 = new Region("cn-north-9",
            "https://nat.cn-north-9.myhuaweicloud.com");
        public static readonly Region ME_EAST_1 = new Region("me-east-1",
            "https://nat.me-east-1.myhuaweicloud.com");
        
        private static readonly Dictionary<string, Region> StaticFields = new Dictionary<string, Region>()
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
                { "cn-south-2", CN_SOUTH_2 },
                { "cn-north-2", CN_NORTH_2 },
                { "ru-northwest-2", RU_NORTHWEST_2 },
                { "na-mexico-1", NA_MEXICO_1 },
                { "sa-brazil-1", SA_BRAZIL_1 },
                { "la-south-2", LA_SOUTH_2 },
                { "la-north-2", LA_NORTH_2 },
                { "cn-north-9", CN_NORTH_9 },
                { "me-east-1", ME_EAST_1 },
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