using System;
using System.Collections.Generic;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Vpcep.V1
{
    public class VpcepRegion
    {
        public static readonly Region CN_NORTH_4 = new Region("cn-north-4", "https://vpcep.cn-north-4.myhuaweicloud.com");
        public static readonly Region CN_NORTH_1 = new Region("cn-north-1", "https://vpcep.cn-north-1.myhuaweicloud.com");
        public static readonly Region CN_EAST_2 = new Region("cn-east-2", "https://vpcep.cn-east-2.myhuaweicloud.com");
        public static readonly Region CN_EAST_3 = new Region("cn-east-3", "https://vpcep.cn-east-3.myhuaweicloud.com");
        public static readonly Region CN_SOUTH_1 = new Region("cn-south-1", "https://vpcep.cn-south-1.myhuaweicloud.com");
        public static readonly Region CN_SOUTHWEST_2 = new Region("cn-southwest-2", "https://vpcep.cn-southwest-2.myhuaweicloud.com");
        public static readonly Region AP_SOUTHEAST_1 = new Region("ap-southeast-1", "https://vpc.ap-southeast-1.myhuaweicloud.com");
        public static readonly Region LA_SOUTH_2 = new Region("la-south-2", "https://vpc.la-south-2.myhuaweicloud.com");
        public static readonly Region NA_MEXICO_1 = new Region("na-mexico-1", "https://vpc.na-mexico-1.myhuaweicloud.com");
        
        private static readonly Dictionary<string, Region> StaticFields = new Dictionary<string, Region>()
        {
                { "cn-north-4", CN_NORTH_4 },
                { "cn-north-1", CN_NORTH_1 },
                { "cn-east-2", CN_EAST_2 },
                { "cn-east-3", CN_EAST_3 },
                { "cn-south-1", CN_SOUTH_1 },
                { "cn-southwest-2", CN_SOUTHWEST_2 },
                { "ap-southeast-1", AP_SOUTHEAST_1 },
                { "la-south-2", LA_SOUTH_2 },
                { "na-mexico-1", NA_MEXICO_1 },
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