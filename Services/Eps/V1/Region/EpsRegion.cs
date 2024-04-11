using System;
using System.Collections.Generic;
using System.Linq;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Eps.V1
{
    public class EpsRegion
    {
        public static readonly Region CN_NORTH_4 = new Region("cn-north-4",
            "https://eps.myhuaweicloud.com",
            "https://eps.myhuaweicloud.cn");
        public static readonly Region EU_WEST_101 = new Region("eu-west-101",
            "https://eps.eu-west-101.myhuaweicloud.eu");
        
        private static readonly IRegionProvider Provider = RegionProviderChain.GetDefault("EPS");

        private static readonly Dictionary<string, Region> StaticFields = new Dictionary<string, Region>
        {
                { "cn-north-4", CN_NORTH_4 },
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

            throw new ArgumentException($"region id '{regionId}' is not in the following supported regions of service 'EPS': [{string.Join(", ", StaticFields.Keys.OrderBy(key => key))}]");
        }
    }
}