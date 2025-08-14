using System;
using System.Collections.Generic;
using System.Linq;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.IdentityCenterOIDC.V1
{
    public class IdentityCenterOIDCRegion
    {
        public static readonly Region CN_EAST_3 = new Region("cn-east-3",
            "https://oidc.cn-east-3.myhuaweicloud.com");
        public static readonly Region CN_NORTH_4 = new Region("cn-north-4",
            "https://oidc.cn-north-4.myhuaweicloud.com");
        public static readonly Region AP_SOUTHEAST_4 = new Region("ap-southeast-4",
            "https://oidc.ap-southeast-4.myhuaweicloud.com");
        public static readonly Region AP_SOUTHEAST_3 = new Region("ap-southeast-3",
            "https://oidc.ap-southeast-3.myhuaweicloud.com");
        public static readonly Region AP_SOUTHEAST_2 = new Region("ap-southeast-2",
            "https://oidc.ap-southeast-2.myhuaweicloud.com");
        public static readonly Region LA_SOUTH_2 = new Region("la-south-2",
            "https://oidc.la-south-2.myhuaweicloud.com");
        public static readonly Region AF_SOUTH_1 = new Region("af-south-1",
            "https://oidc.af-south-1.myhuaweicloud.com");
        public static readonly Region AP_SOUTHEAST_1 = new Region("ap-southeast-1",
            "https://oidc.ap-southeast-1.myhuaweicloud.com");
        public static readonly Region CN_SOUTH_4 = new Region("cn-south-4",
            "https://oidc.cn-south-4.myhuaweicloud.com");
        public static readonly Region ME_EAST_1 = new Region("me-east-1",
            "https://oidc.me-east-1.myhuaweicloud.com");
        public static readonly Region TR_WEST_1 = new Region("tr-west-1",
            "https://oidc.tr-west-1.myhuaweicloud.com");
        public static readonly Region LA_NORTH_2 = new Region("la-north-2",
            "https://oidc.la-north-2.myhuaweicloud.com");
        public static readonly Region SA_BRAZIL_1 = new Region("sa-brazil-1",
            "https://oidc.sa-brazil-1.myhuaweicloud.com");
        public static readonly Region CN_SOUTH_1 = new Region("cn-south-1",
            "https://oidc.cn-south-1.myhuaweicloud.com");
        public static readonly Region CN_SOUTHWEST_2 = new Region("cn-southwest-2",
            "https://oidc.cn-southwest-2.myhuaweicloud.com");
        public static readonly Region AF_NORTH_1 = new Region("af-north-1",
            "https://oidc.af-north-1.myhuaweicloud.com");
        public static readonly Region AP_SOUTHEAST_5 = new Region("ap-southeast-5",
            "https://oidc.ap-southeast-5.myhuaweicloud.com");
        
        private static readonly IRegionProvider Provider = RegionProviderChain.GetDefault("IDENTITYCENTEROIDC");

        private static readonly Dictionary<string, Region> StaticFields = new Dictionary<string, Region>
        {
                { "cn-east-3", CN_EAST_3 },
                { "cn-north-4", CN_NORTH_4 },
                { "ap-southeast-4", AP_SOUTHEAST_4 },
                { "ap-southeast-3", AP_SOUTHEAST_3 },
                { "ap-southeast-2", AP_SOUTHEAST_2 },
                { "la-south-2", LA_SOUTH_2 },
                { "af-south-1", AF_SOUTH_1 },
                { "ap-southeast-1", AP_SOUTHEAST_1 },
                { "cn-south-4", CN_SOUTH_4 },
                { "me-east-1", ME_EAST_1 },
                { "tr-west-1", TR_WEST_1 },
                { "la-north-2", LA_NORTH_2 },
                { "sa-brazil-1", SA_BRAZIL_1 },
                { "cn-south-1", CN_SOUTH_1 },
                { "cn-southwest-2", CN_SOUTHWEST_2 },
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

            throw new ArgumentException($"region id '{regionId}' is not in the following supported regions of service 'IdentityCenterOIDC': [{string.Join(", ", StaticFields.Keys.OrderBy(key => key))}]");
        }
    }
}