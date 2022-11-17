using System;
using System.Collections.Generic;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Sis.V1
{
    public class SisRegion
    {
        public static readonly Region CN_NORTH_1 = new Region("cn-north-1", "https://sis-ext.cn-north-1.myhuaweicloud.com");
        public static readonly Region CN_NORTH_4 = new Region("cn-north-4", "https://sis-ext.cn-north-4.myhuaweicloud.com");
        public static readonly Region CN_EAST_3 = new Region("cn-east-3", "https://sis-ext.cn-east-3.myhuaweicloud.com");
        
        private static readonly Dictionary<string, Region> StaticFields = new Dictionary<string, Region>()
        {
                { "cn-north-1", CN_NORTH_1 },
                { "cn-north-4", CN_NORTH_4 },
                { "cn-east-3", CN_EAST_3 },
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