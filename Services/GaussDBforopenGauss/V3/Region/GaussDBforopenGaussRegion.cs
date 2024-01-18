using System;
using System.Collections.Generic;
using System.Linq;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.GaussDBforopenGauss.V3
{
    public class GaussDBforopenGaussRegion
    {
        public static readonly Region CN_NORTH_4 = new Region("cn-north-4",
            "https://gaussdb-opengauss.cn-north-4.myhuaweicloud.com");
        public static readonly Region CN_SOUTHWEST_2 = new Region("cn-southwest-2",
            "https://gaussdb-opengauss.cn-southwest-2.myhuaweicloud.com");
        public static readonly Region CN_SOUTH_1 = new Region("cn-south-1",
            "https://gaussdb-opengauss.cn-south-1.myhuaweicloud.com");
        public static readonly Region RU_NORTHWEST_2 = new Region("ru-northwest-2",
            "https://gaussdb-opengauss.ru-northwest-2.myhuaweicloud.com");
        public static readonly Region AP_SOUTHEAST_3 = new Region("ap-southeast-3",
            "https://gaussdb-opengauss.ap-southeast-3.myhuaweicloud.com");
        public static readonly Region CN_NORTH_2 = new Region("cn-north-2",
            "https://gaussdb-opengauss.cn-north-2.myhuaweicloud.com");
        public static readonly Region AP_SOUTHEAST_2 = new Region("ap-southeast-2",
            "https://gaussdb-opengauss.ap-southeast-2.myhuaweicloud.com");
        public static readonly Region AP_SOUTHEAST_1 = new Region("ap-southeast-1",
            "https://gaussdb-opengauss.ap-southeast-1.myhuaweicloud.com");
        public static readonly Region CN_EAST_3 = new Region("cn-east-3",
            "https://gaussdb-opengauss.cn-east-3.myhuaweicloud.com");
        public static readonly Region SA_BRAZIL_1 = new Region("sa-brazil-1",
            "https://gaussdb-opengauss.sa-brazil-1.myhuaweicloud.com");
        public static readonly Region LA_SOUTH_2 = new Region("la-south-2",
            "https://gaussdb-opengauss.la-south-2.myhuaweicloud.com");
        public static readonly Region LA_NORTH_2 = new Region("la-north-2",
            "https://gaussdb-opengauss.la-north-2.myhuaweicloud.com");
        public static readonly Region AF_SOUTH_1 = new Region("af-south-1",
            "https://gaussdb-opengauss.af-south-1.myhuaweicloud.com");
        
        private static readonly IRegionProvider Provider = RegionProviderChain.GetDefault("GAUSSDBFOROPENGAUSS");

        private static readonly Dictionary<string, Region> StaticFields = new Dictionary<string, Region>
        {
                { "cn-north-4", CN_NORTH_4 },
                { "cn-southwest-2", CN_SOUTHWEST_2 },
                { "cn-south-1", CN_SOUTH_1 },
                { "ru-northwest-2", RU_NORTHWEST_2 },
                { "ap-southeast-3", AP_SOUTHEAST_3 },
                { "cn-north-2", CN_NORTH_2 },
                { "ap-southeast-2", AP_SOUTHEAST_2 },
                { "ap-southeast-1", AP_SOUTHEAST_1 },
                { "cn-east-3", CN_EAST_3 },
                { "sa-brazil-1", SA_BRAZIL_1 },
                { "la-south-2", LA_SOUTH_2 },
                { "la-north-2", LA_NORTH_2 },
                { "af-south-1", AF_SOUTH_1 },
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

            throw new ArgumentException($"region id '{regionId}' is not in the following supported regions of service 'GaussDBforopenGauss': [{string.Join(", ", StaticFields.Keys.OrderBy(key => key))}]");
        }
    }
}