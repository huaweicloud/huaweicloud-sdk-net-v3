using System;
using System.Collections.Generic;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cfw.V1
{
    public class CfwRegion
    {
        public static readonly Region CN_SOUTH_4 = new Region("cn-south-4", "https://cfw.cn-south-4.myhuaweicloud.com");
        public static readonly Region CN_SOUTHWEST_2 = new Region("cn-southwest-2", "https://cfw.cn-southwest-2.myhuaweicloud.com");
        public static readonly Region CN_SOUTH_1 = new Region("cn-south-1", "https://cfw.cn-south-1.myhuaweicloud.com");
        public static readonly Region CN_EAST_3 = new Region("cn-east-3", "https://cfw.cn-east-3.myhuaweicloud.com");
        public static readonly Region CN_NORTH_4 = new Region("cn-north-4", "https://cfw.cn-north-4.myhuaweicloud.com");
        
        private static readonly Dictionary<string, Region> StaticFields = new Dictionary<string, Region>()
        {
                { "cn-south-4", CN_SOUTH_4 },
                { "cn-southwest-2", CN_SOUTHWEST_2 },
                { "cn-south-1", CN_SOUTH_1 },
                { "cn-east-3", CN_EAST_3 },
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