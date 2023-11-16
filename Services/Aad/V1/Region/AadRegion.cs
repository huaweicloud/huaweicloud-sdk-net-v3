using System;
using System.Collections.Generic;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Aad.V1
{
    public class AadRegion
    {
        public static readonly Region CN_NORTH_4 = new Region("cn-north-4",
            "https://aad.myhuaweicloud.com");
        
        private static readonly IRegionProvider Provider = RegionProviderChain.GetDefault("AAD");

        private static readonly Dictionary<string, Region> StaticFields = new Dictionary<string, Region>()
        {
                { "cn-north-4", CN_NORTH_4 },
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

            throw new ArgumentException("Unexpected regionId: ", regionId);
        }
    }
}