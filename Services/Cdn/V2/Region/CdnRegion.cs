using System;
using System.Collections.Generic;
using System.Linq;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cdn.V2
{
    public class CdnRegion
    {
        public static readonly Region CN_NORTH_1 = new Region("cn-north-1",
            "https://cdn.myhuaweicloud.com");
        public static readonly Region AP_SOUTHEAST_1 = new Region("ap-southeast-1",
            "https://cdn.myhuaweicloud.com");
        public static readonly Region EU_WEST_101 = new Region("eu-west-101",
            "https://cdn.myhuaweicloud.eu");
        
        private static readonly IRegionProvider Provider = RegionProviderChain.GetDefault("CDN");

        private static readonly Dictionary<string, Region> StaticFields = new Dictionary<string, Region>
        {
                { "cn-north-1", CN_NORTH_1 },
                { "ap-southeast-1", AP_SOUTHEAST_1 },
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

            throw new ArgumentException($"region id '{regionId}' is not in the following supported regions of service 'CDN': [{string.Join(", ", StaticFields.Keys.OrderBy(key => key))}]");
        }
    }
}