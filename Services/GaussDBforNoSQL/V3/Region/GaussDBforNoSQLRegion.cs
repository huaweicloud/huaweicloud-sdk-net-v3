using System;
using System.Collections.Generic;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.GaussDBforNoSQL.V3
{
    public class GaussDBforNoSQLRegion
    {
        public static readonly Region CN_NORTH_4 = new Region("cn-north-4", "https://gaussdb-nosql.cn-north-4.myhuaweicloud.com");
        public static readonly Region CN_EAST_2 = new Region("cn-east-2", "https://gaussdb-nosql.cn-east-2.myhuaweicloud.com");
        public static readonly Region CN_EAST_3 = new Region("cn-east-3", "https://gaussdb-nosql.cn-east-3.myhuaweicloud.com");
        public static readonly Region CN_SOUTH_1 = new Region("cn-south-1", "https://gaussdb-nosql.cn-south-1.myhuaweicloud.com");
        public static readonly Region AP_SOUTHEAST_1 = new Region("ap-southeast-1", "https://gaussdb-nosql.ap-southeast-1.myhuaweicloud.com");
        public static readonly Region AP_SOUTHEAST_3 = new Region("ap-southeast-3", "https://gaussdb-nosql.ap-southeast-3.myhuaweicloud.com");
        public static readonly Region CN_NORTH_9 = new Region("cn-north-9", "https://gaussdb-nosql.cn-north-9.myhuaweicloud.com");
        
        private static readonly Dictionary<string, Region> StaticFields = new Dictionary<string, Region>()
        {
                { "cn-north-4", CN_NORTH_4 },
                { "cn-east-2", CN_EAST_2 },
                { "cn-east-3", CN_EAST_3 },
                { "cn-south-1", CN_SOUTH_1 },
                { "ap-southeast-1", AP_SOUTHEAST_1 },
                { "ap-southeast-3", AP_SOUTHEAST_3 },
                { "cn-north-9", CN_NORTH_9 },
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