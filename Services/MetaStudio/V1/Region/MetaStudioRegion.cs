using System;
using System.Collections.Generic;
using System.Linq;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.MetaStudio.V1
{
    public class MetaStudioRegion
    {
        public static readonly Region CN_NORTH_4 = new Region("cn-north-4",
            "https://metastudio.cn-north-4.myhuaweicloud.com");
        public static readonly Region CN_EAST_3 = new Region("cn-east-3",
            "https://metastudio.cn-east-3.myhuaweicloud.com");
        
        private static readonly IRegionProvider Provider = RegionProviderChain.GetDefault("METASTUDIO");

        private static readonly Dictionary<string, Region> StaticFields = new Dictionary<string, Region>
        {
                { "cn-north-4", CN_NORTH_4 },
                { "cn-east-3", CN_EAST_3 },
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

            throw new ArgumentException($"region id '{regionId}' is not in the following supported regions of service 'MetaStudio': [{string.Join(", ", StaticFields.Keys.OrderBy(key => key))}]");
        }
    }
}