using System;
using System.Collections.Generic;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cce.V3
{
    public class CceRegion
    {
        public static readonly Region CN_NORTH_1 = new Region("cn-north-1",
            "https://cce.cn-north-1.myhuaweicloud.com");
        public static readonly Region CN_NORTH_2 = new Region("cn-north-2",
            "https://cce.cn-north-2.myhuaweicloud.com");
        public static readonly Region CN_NORTH_4 = new Region("cn-north-4",
            "https://cce.cn-north-4.myhuaweicloud.com");
        public static readonly Region CN_NORTH_9 = new Region("cn-north-9",
            "https://cce.cn-north-9.myhuaweicloud.com");
        public static readonly Region CN_SOUTH_1 = new Region("cn-south-1",
            "https://cce.cn-south-1.myhuaweicloud.com");
        public static readonly Region CN_SOUTH_2 = new Region("cn-south-2",
            "https://cce.cn-south-2.myhuaweicloud.com");
        public static readonly Region CN_SOUTH_4 = new Region("cn-south-4",
            "https://cce.cn-south-4.myhuaweicloud.com");
        public static readonly Region CN_EAST_2 = new Region("cn-east-2",
            "https://cce.cn-east-2.myhuaweicloud.com");
        public static readonly Region CN_EAST_3 = new Region("cn-east-3",
            "https://cce.cn-east-3.myhuaweicloud.com");
        public static readonly Region CN_SOUTHWEST_2 = new Region("cn-southwest-2",
            "https://cce.cn-southwest-2.myhuaweicloud.com");
        public static readonly Region AP_SOUTHEAST_1 = new Region("ap-southeast-1",
            "https://cce.ap-southeast-1.myhuaweicloud.com");
        public static readonly Region AP_SOUTHEAST_2 = new Region("ap-southeast-2",
            "https://cce.ap-southeast-2.myhuaweicloud.com");
        public static readonly Region AP_SOUTHEAST_3 = new Region("ap-southeast-3",
            "https://cce.ap-southeast-3.myhuaweicloud.com");
        public static readonly Region AF_SOUTH_1 = new Region("af-south-1",
            "https://cce.af-south-1.myhuaweicloud.com");
        public static readonly Region SA_BRAZIL_1 = new Region("sa-brazil-1",
            "https://cce.sa-brazil-1.myhuaweicloud.com");
        public static readonly Region LA_SOUTH_2 = new Region("la-south-2",
            "https://cce.la-south-2.myhuaweicloud.com");
        public static readonly Region LA_NORTH_2 = new Region("la-north-2",
            "https://cce.la-north-2.myhuaweicloud.com");
        public static readonly Region NA_MEXICO_1 = new Region("na-mexico-1",
            "https://cce.na-mexico-1.myhuaweicloud.com");
        public static readonly Region RU_NORTHWEST_2 = new Region("ru-northwest-2",
            "https://cce.ru-northwest-2.myhuaweicloud.com");
        public static readonly Region AP_SOUTHEAST_4 = new Region("ap-southeast-4",
            "https://cce.ap-southeast-4.myhuaweicloud.com");
        public static readonly Region TR_WEST_1 = new Region("tr-west-1",
            "https://cce.tr-west-1.myhuaweicloud.com");
        
        private static readonly Dictionary<string, Region> StaticFields = new Dictionary<string, Region>()
        {
                { "cn-north-1", CN_NORTH_1 },
                { "cn-north-2", CN_NORTH_2 },
                { "cn-north-4", CN_NORTH_4 },
                { "cn-north-9", CN_NORTH_9 },
                { "cn-south-1", CN_SOUTH_1 },
                { "cn-south-2", CN_SOUTH_2 },
                { "cn-south-4", CN_SOUTH_4 },
                { "cn-east-2", CN_EAST_2 },
                { "cn-east-3", CN_EAST_3 },
                { "cn-southwest-2", CN_SOUTHWEST_2 },
                { "ap-southeast-1", AP_SOUTHEAST_1 },
                { "ap-southeast-2", AP_SOUTHEAST_2 },
                { "ap-southeast-3", AP_SOUTHEAST_3 },
                { "af-south-1", AF_SOUTH_1 },
                { "sa-brazil-1", SA_BRAZIL_1 },
                { "la-south-2", LA_SOUTH_2 },
                { "la-north-2", LA_NORTH_2 },
                { "na-mexico-1", NA_MEXICO_1 },
                { "ru-northwest-2", RU_NORTHWEST_2 },
                { "ap-southeast-4", AP_SOUTHEAST_4 },
                { "tr-west-1", TR_WEST_1 },
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