using System;
using System.Collections.Generic;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cbr.V1
{
    public class CbrRegion
    {
        public static readonly Region EU_WEST_101 = new Region("eu-west-101",
            "https://cbr.eu-west-101.myhuaweicloud.eu");
        public static readonly Region CN_NORTH_1 = new Region("cn-north-1",
            "https://cbr.cn-north-1.myhuaweicloud.com");
        public static readonly Region CN_NORTH_4 = new Region("cn-north-4",
            "https://cbr.cn-north-4.myhuaweicloud.com");
        public static readonly Region CN_SOUTH_1 = new Region("cn-south-1",
            "https://cbr.cn-south-1.myhuaweicloud.com");
        public static readonly Region CN_EAST_2 = new Region("cn-east-2",
            "https://cbr.cn-east-2.myhuaweicloud.com");
        public static readonly Region CN_EAST_3 = new Region("cn-east-3",
            "https://cbr.cn-east-3.myhuaweicloud.com");
        public static readonly Region CN_SOUTHWEST_2 = new Region("cn-southwest-2",
            "https://cbr.cn-southwest-2.myhuaweicloud.com");
        public static readonly Region AP_SOUTHEAST_1 = new Region("ap-southeast-1",
            "https://cbr.ap-southeast-1.myhuaweicloud.com");
        public static readonly Region AP_SOUTHEAST_2 = new Region("ap-southeast-2",
            "https://cbr.ap-southeast-2.myhuaweicloud.com");
        public static readonly Region AP_SOUTHEAST_3 = new Region("ap-southeast-3",
            "https://cbr.ap-southeast-3.myhuaweicloud.com");
        public static readonly Region AF_SOUTH_1 = new Region("af-south-1",
            "https://cbr.af-south-1.myhuaweicloud.com");
        public static readonly Region SA_BRAZIL_1 = new Region("sa-brazil-1",
            "https://cbr.sa-brazil-1.myhuaweicloud.com");
        public static readonly Region LA_NORTH_2 = new Region("la-north-2",
            "https://cbr.la-north-2.myhuaweicloud.com");
        public static readonly Region CN_SOUTH_4 = new Region("cn-south-4",
            "https://cbr.cn-south-4.myhuaweicloud.com");
        public static readonly Region NA_MEXICO_1 = new Region("na-mexico-1",
            "https://cbr.na-mexico-1.myhuaweicloud.com");
        public static readonly Region LA_SOUTH_2 = new Region("la-south-2",
            "https://cbr.la-south-2.myhuaweicloud.com");
        public static readonly Region CN_SOUTH_2 = new Region("cn-south-2",
            "https://cbr.cn-south-2.myhuaweicloud.com");
        public static readonly Region CN_NORTH_9 = new Region("cn-north-9",
            "https://cbr.cn-north-9.myhuaweicloud.com");
        public static readonly Region CN_NORTH_2 = new Region("cn-north-2",
            "https://cbr.cn-north-2.myhuaweicloud.com");
        public static readonly Region AP_SOUTHEAST_4 = new Region("ap-southeast-4",
            "https://cbr.ap-southeast-4.myhuaweicloud.com");
        public static readonly Region TR_WEST_1 = new Region("tr-west-1",
            "https://cbr.tr-west-1.myhuaweicloud.com");
        
        private static readonly Dictionary<string, Region> StaticFields = new Dictionary<string, Region>()
        {
                { "eu-west-101", EU_WEST_101 },
                { "cn-north-1", CN_NORTH_1 },
                { "cn-north-4", CN_NORTH_4 },
                { "cn-south-1", CN_SOUTH_1 },
                { "cn-east-2", CN_EAST_2 },
                { "cn-east-3", CN_EAST_3 },
                { "cn-southwest-2", CN_SOUTHWEST_2 },
                { "ap-southeast-1", AP_SOUTHEAST_1 },
                { "ap-southeast-2", AP_SOUTHEAST_2 },
                { "ap-southeast-3", AP_SOUTHEAST_3 },
                { "af-south-1", AF_SOUTH_1 },
                { "sa-brazil-1", SA_BRAZIL_1 },
                { "la-north-2", LA_NORTH_2 },
                { "cn-south-4", CN_SOUTH_4 },
                { "na-mexico-1", NA_MEXICO_1 },
                { "la-south-2", LA_SOUTH_2 },
                { "cn-south-2", CN_SOUTH_2 },
                { "cn-north-9", CN_NORTH_9 },
                { "cn-north-2", CN_NORTH_2 },
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