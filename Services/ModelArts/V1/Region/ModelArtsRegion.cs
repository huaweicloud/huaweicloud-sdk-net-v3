using System;
using System.Collections.Generic;
using System.Linq;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.ModelArts.V1
{
    public class ModelArtsRegion
    {
        public static readonly Region CN_NORTH_1 = new Region("cn-north-1",
            "https://modelarts.cn-north-1.myhuaweicloud.com");
        public static readonly Region CN_NORTH_4 = new Region("cn-north-4",
            "https://modelarts.cn-north-4.myhuaweicloud.com");
        public static readonly Region CN_SOUTH_1 = new Region("cn-south-1",
            "https://modelarts.cn-south-1.myhuaweicloud.com");
        public static readonly Region AP_SOUTHEAST_1 = new Region("ap-southeast-1",
            "https://modelarts.ap-southeast-1.myhuaweicloud.cn");
        public static readonly Region AP_SOUTHEAST_2 = new Region("ap-southeast-2",
            "https://modelarts.ap-southeast-2.myhuaweicloud.com");
        public static readonly Region AP_SOUTHEAST_3 = new Region("ap-southeast-3",
            "https://modelarts.ap-southeast-3.myhuaweicloud.com");
        public static readonly Region CN_EAST_3 = new Region("cn-east-3",
            "https://modelarts.cn-east-3.myhuaweicloud.com");
        public static readonly Region CN_EAST_4 = new Region("cn-east-4",
            "https://modelarts.cn-east-4.myhuaweicloud.com");
        public static readonly Region LA_SOUTH_2 = new Region("la-south-2",
            "https://modelarts.la-south-2.myhuaweicloud.com");
        public static readonly Region AF_SOUTH_1 = new Region("af-south-1",
            "https://modelarts.af-south-1.myhuaweicloud.com");
        public static readonly Region CN_NORTH_9 = new Region("cn-north-9",
            "https://modelarts.cn-north-9.myhuaweicloud.com");
        public static readonly Region TR_WEST_1 = new Region("tr-west-1",
            "https://modelarts.tr-west-1.myhuaweicloud.com");
        public static readonly Region AP_SOUTHEAST_4 = new Region("ap-southeast-4",
            "https://modelarts.ap-southeast-4.myhuaweicloud.com");
        public static readonly Region ME_EAST_1 = new Region("me-east-1",
            "https://modelarts.me-east-1.myhuaweicloud.com");
        public static readonly Region CN_SOUTHWEST_2 = new Region("cn-southwest-2",
            "https://modelarts.cn-southwest-2.myhuaweicloud.com");
        public static readonly Region CN_NORTH_2 = new Region("cn-north-2",
            "https://modelarts.cn-north-2.myhuaweicloud.com");
        public static readonly Region SA_BRAZIL_1 = new Region("sa-brazil-1",
            "https://modelarts.sa-brazil-1.myhuaweicloud.com");
        public static readonly Region LA_NORTH_2 = new Region("la-north-2",
            "https://modelarts.la-north-2.myhuaweicloud.com");
        public static readonly Region AF_NORTH_1 = new Region("af-north-1",
            "https://modelarts.af-north-1.myhuaweicloud.com");
        public static readonly Region CN_NORTH_12 = new Region("cn-north-12",
            "https://modelarts.cn-north-12.myhuaweicloud.com");
        public static readonly Region CN_SOUTHWEST_3 = new Region("cn-southwest-3",
            "https://modelarts.cn-southwest-3.myhuaweicloud.com");
        public static readonly Region CN_NORTH_11 = new Region("cn-north-11",
            "https://modelarts.cn-north-11.myhuaweicloud.com");
        
        private static readonly IRegionProvider Provider = RegionProviderChain.GetDefault("MODELARTS");

        private static readonly Dictionary<string, Region> StaticFields = new Dictionary<string, Region>
        {
                { "cn-north-1", CN_NORTH_1 },
                { "cn-north-4", CN_NORTH_4 },
                { "cn-south-1", CN_SOUTH_1 },
                { "ap-southeast-1", AP_SOUTHEAST_1 },
                { "ap-southeast-2", AP_SOUTHEAST_2 },
                { "ap-southeast-3", AP_SOUTHEAST_3 },
                { "cn-east-3", CN_EAST_3 },
                { "cn-east-4", CN_EAST_4 },
                { "la-south-2", LA_SOUTH_2 },
                { "af-south-1", AF_SOUTH_1 },
                { "cn-north-9", CN_NORTH_9 },
                { "tr-west-1", TR_WEST_1 },
                { "ap-southeast-4", AP_SOUTHEAST_4 },
                { "me-east-1", ME_EAST_1 },
                { "cn-southwest-2", CN_SOUTHWEST_2 },
                { "cn-north-2", CN_NORTH_2 },
                { "sa-brazil-1", SA_BRAZIL_1 },
                { "la-north-2", LA_NORTH_2 },
                { "af-north-1", AF_NORTH_1 },
                { "cn-north-12", CN_NORTH_12 },
                { "cn-southwest-3", CN_SOUTHWEST_3 },
                { "cn-north-11", CN_NORTH_11 },
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

            throw new ArgumentException($"region id '{regionId}' is not in the following supported regions of service 'ModelArts': [{string.Join(", ", StaticFields.Keys.OrderBy(key => key))}]");
        }
    }
}