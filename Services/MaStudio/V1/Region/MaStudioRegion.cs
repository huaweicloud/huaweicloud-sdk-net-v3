using System;
using System.Collections.Generic;
using System.Linq;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.MaStudio.V1
{
    public class MaStudioRegion
    {
        public static readonly Region CN_SOUTHWEST_2 = new Region("cn-southwest-2",
            "https://mastudio.cn-southwest-2.myhuaweicloud.com");
        
        private static readonly IRegionProvider Provider = RegionProviderChain.GetDefault("MASTUDIO");

        private static readonly Dictionary<string, Region> StaticFields = new Dictionary<string, Region>
        {
                { "cn-southwest-2", CN_SOUTHWEST_2 },
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

            throw new ArgumentException($"region id '{regionId}' is not in the following supported regions of service 'MaStudio': [{string.Join(", ", StaticFields.Keys.OrderBy(key => key))}]");
        }
    }
}