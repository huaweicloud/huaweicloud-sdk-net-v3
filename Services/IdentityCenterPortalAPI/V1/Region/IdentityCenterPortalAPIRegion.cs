using System;
using System.Collections.Generic;
using System.Linq;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.IdentityCenterPortalAPI.V1
{
    public class IdentityCenterPortalAPIRegion
    {
        public static readonly Region CN_NORTH_4 = new Region("cn-north-4",
            "https://portal-identitycenter.myhuaweicloud.com");
        public static readonly Region CN_SOUTH_1 = new Region("cn-south-1",
            "https://portal-identitycenter.myhuaweicloud.com");
        
        private static readonly IRegionProvider Provider = RegionProviderChain.GetDefault("IDENTITYCENTERPORTALAPI");

        private static readonly Dictionary<string, Region> StaticFields = new Dictionary<string, Region>
        {
                { "cn-north-4", CN_NORTH_4 },
                { "cn-south-1", CN_SOUTH_1 },
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

            throw new ArgumentException($"region id '{regionId}' is not in the following supported regions of service 'IdentityCenterPortalAPI': [{string.Join(", ", StaticFields.Keys.OrderBy(key => key))}]");
        }
    }
}