using System;
using System.Collections.Generic;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.ImageSearch.V2
{
    public class ImageSearchRegion
    {
        public static readonly Region CN_NORTH_4 = new Region("cn-north-4",
            "https://mms.cn-north-4.myhuaweicloud.com",
            "https://mms.cn-north-4.myhuaweicloud.cn");
        
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

            if (StaticFields.ContainsKey(regionId))
            {
                return StaticFields[regionId];
            }

            throw new ArgumentException("Unexpected regionId: ", regionId);
        }
    }
}