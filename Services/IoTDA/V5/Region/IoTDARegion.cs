using System;
using System.Collections.Generic;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.IoTDA.V5
{
    public class IoTDARegion
    {
        public static readonly Region CN_NORTH_4 = new Region("cn-north-4", "https://iotda.cn-north-4.myhuaweicloud.com");
        public static readonly Region CN_SOUTH_4 = new Region("cn-south-4", "https://iotda.cn-south-4.myhuaweicloud.com");
        public static readonly Region CN_SOUTH_1 = new Region("cn-south-1", "https://iotda.cn-south-1.myhuaweicloud.com");
        public static readonly Region CN_EAST_3 = new Region("cn-east-3", "https://iotda.cn-east-3.myhuaweicloud.com");
        public static readonly Region AP_SOUTHEAST_3 = new Region("ap-southeast-3", "https://iotda.ap-southeast-3.myhuaweicloud.com");
        
        private static readonly Dictionary<string, Region> StaticFields = new Dictionary<string, Region>()
        {
                { "cn-north-4", CN_NORTH_4 },
                { "cn-south-4", CN_SOUTH_4 },
                { "cn-south-1", CN_SOUTH_1 },
                { "cn-east-3", CN_EAST_3 },
                { "ap-southeast-3", AP_SOUTHEAST_3 },
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