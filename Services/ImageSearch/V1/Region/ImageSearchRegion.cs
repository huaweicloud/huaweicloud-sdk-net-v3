using System;
using System.Collections.Generic;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.ImageSearch.V1
{
    public class ImageSearchRegion
    {
        public static readonly Region CN_NORTH_4 = new Region("cn-north-4", "https://imagesearch.cn-north-4.myhuaweicloud.com");
        public static readonly Region CN_NORTH_1 = new Region("cn-north-1", "https://imagesearch.cn-north-1.myhuaweicloud.com");
        public static readonly Region AP_SOUTHEAST_1 = new Region("ap-southeast-1", "https://imagesearch.ap-southeast-1.myhuaweicloud.com");
        
        private static readonly Dictionary<string, Region> StaticFields = new Dictionary<string, Region>()
        {
                { "cn-north-4", CN_NORTH_4 },
                { "cn-north-1", CN_NORTH_1 },
                { "ap-southeast-1", AP_SOUTHEAST_1 },
        };

        public static Region ValueOf(string regionId)
        {
            if (string.IsNullOrEmpty(regionId))
            {
                throw new ArgumentNullException(regionId);
            }

            if (StaticFields.ContainsKey(regionId))
            {
                return StaticFields[regionId];
            }

            throw new ArgumentException("Unexpected regionId: ", regionId);
        }
    }
}