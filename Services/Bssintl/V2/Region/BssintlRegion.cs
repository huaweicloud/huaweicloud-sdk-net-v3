using System;
using System.Collections.Generic;
using System.Linq;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Bssintl.V2
{
    public class BssintlRegion
    {
        public static readonly Region AP_SOUTHEAST_1 = new Region("ap-southeast-1",
            "https://bss-intl.myhuaweicloud.com");
        
        private static readonly IRegionProvider Provider = RegionProviderChain.GetDefault("BSSINTL");

        private static readonly Dictionary<string, Region> StaticFields = new Dictionary<string, Region>
        {
                { "ap-southeast-1", AP_SOUTHEAST_1 },
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

            throw new ArgumentException($"region id '{regionId}' is not in the following supported regions of service 'BSSINTL': [{string.Join(", ", StaticFields.Keys.OrderBy(key => key))}]");
        }
    }
}