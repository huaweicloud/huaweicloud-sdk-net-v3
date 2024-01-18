using System;
using System.Collections.Generic;
using System.Linq;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Image.V2
{
    public class ImageRegion
    {
        public static readonly Region CN_NORTH_4 = new Region("cn-north-4",
            "https://image.cn-north-4.myhuaweicloud.com",
            "https://image.cn-north-4.myhuaweicloud.cn");
        public static readonly Region CN_NORTH_1 = new Region("cn-north-1",
            "https://image.cn-north-1.myhuaweicloud.com",
            "https://image.cn-north-1.myhuaweicloud.cn");
        public static readonly Region AP_SOUTHEAST_1 = new Region("ap-southeast-1",
            "https://image.ap-southeast-1.myhuaweicloud.com",
            "https://image.ap-southeast-1.myhuaweicloud.cn");
        public static readonly Region AP_SOUTHEAST_3 = new Region("ap-southeast-3",
            "https://image.ap-southeast-3.myhuaweicloud.com",
            "https://image.ap-southeast-3.myhuaweicloud.cn");
        public static readonly Region CN_EAST_3 = new Region("cn-east-3",
            "https://image.cn-east-3.myhuaweicloud.com",
            "https://image.cn-east-3.myhuaweicloud.cn");
        
        private static readonly IRegionProvider Provider = RegionProviderChain.GetDefault("IMAGE");

        private static readonly Dictionary<string, Region> StaticFields = new Dictionary<string, Region>
        {
                { "cn-north-4", CN_NORTH_4 },
                { "cn-north-1", CN_NORTH_1 },
                { "ap-southeast-1", AP_SOUTHEAST_1 },
                { "ap-southeast-3", AP_SOUTHEAST_3 },
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

            throw new ArgumentException($"region id '{regionId}' is not in the following supported regions of service 'Image': [{string.Join(", ", StaticFields.Keys.OrderBy(key => key))}]");
        }
    }
}