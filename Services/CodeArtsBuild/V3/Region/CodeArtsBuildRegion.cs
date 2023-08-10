using System;
using System.Collections.Generic;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CodeArtsBuild.V3
{
    public class CodeArtsBuildRegion
    {
        public static readonly Region CN_NORTH_4 = new Region("cn-north-4",
            "https://cloudbuild-ext.cn-north-4.myhuaweicloud.com");
        public static readonly Region CN_NORTH_1 = new Region("cn-north-1",
            "https://cloudbuild-ext.cn-north-1.myhuaweicloud.com");
        public static readonly Region CN_EAST_2 = new Region("cn-east-2",
            "https://cloudbuild-ext.cn-east-2.myhuaweicloud.com");
        public static readonly Region CN_SOUTH_1 = new Region("cn-south-1",
            "https://cloudbuild-ext.cn-south-1.myhuaweicloud.com");
        public static readonly Region CN_EAST_3 = new Region("cn-east-3",
            "https://cloudbuild-ext.cn-east-3.myhuaweicloud.com");
        public static readonly Region CN_SOUTH_2 = new Region("cn-south-2",
            "https://cloudbuild-ext.cn-south-2.myhuaweicloud.com");
        public static readonly Region CN_SOUTHWEST_2 = new Region("cn-southwest-2",
            "https://cloudbuild-ext.cn-southwest-2.myhuaweicloud.com");
        public static readonly Region AP_SOUTHEAST_3 = new Region("ap-southeast-3",
            "https://cloudbuild-ext.ap-southeast-3.myhuaweicloud.com");
        public static readonly Region SA_BRAZIL_1 = new Region("sa-brazil-1",
            "https://cloudbuild-ext.sa-brazil-1.myhuaweicloud.com");
        public static readonly Region LA_NORTH_2 = new Region("la-north-2",
            "https://cloudbuild-ext.la-north-2.myhuaweicloud.com");
        
        private static readonly Dictionary<string, Region> StaticFields = new Dictionary<string, Region>()
        {
                { "cn-north-4", CN_NORTH_4 },
                { "cn-north-1", CN_NORTH_1 },
                { "cn-east-2", CN_EAST_2 },
                { "cn-south-1", CN_SOUTH_1 },
                { "cn-east-3", CN_EAST_3 },
                { "cn-south-2", CN_SOUTH_2 },
                { "cn-southwest-2", CN_SOUTHWEST_2 },
                { "ap-southeast-3", AP_SOUTHEAST_3 },
                { "sa-brazil-1", SA_BRAZIL_1 },
                { "la-north-2", LA_NORTH_2 },
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