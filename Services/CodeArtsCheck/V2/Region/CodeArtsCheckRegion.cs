using System;
using System.Collections.Generic;
using System.Linq;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CodeArtsCheck.V2
{
    public class CodeArtsCheckRegion
    {
        public static readonly Region CN_NORTH_4 = new Region("cn-north-4",
            "https://codearts-check.cn-north-4.myhuaweicloud.com",
            "https://codearts-check.cn-north-4.myhuaweicloud.cn");
        public static readonly Region CN_NORTH_1 = new Region("cn-north-1",
            "https://codearts-check.cn-north-1.myhuaweicloud.com",
            "https://codearts-check.cn-north-1.myhuaweicloud.cn");
        public static readonly Region CN_EAST_2 = new Region("cn-east-2",
            "https://codearts-check.cn-east-2.myhuaweicloud.com",
            "https://codearts-check.cn-east-2.myhuaweicloud.cn");
        public static readonly Region CN_SOUTH_1 = new Region("cn-south-1",
            "https://codearts-check.cn-south-1.myhuaweicloud.com",
            "https://codearts-check.cn-south-1.myhuaweicloud.cn");
        public static readonly Region CN_EAST_3 = new Region("cn-east-3",
            "https://codearts-check.cn-east-3.myhuaweicloud.com",
            "https://codearts-check.cn-east-3.myhuaweicloud.cn");
        public static readonly Region LA_NORTH_2 = new Region("la-north-2",
            "https://codearts-check.la-north-2.myhuaweicloud.com");
        public static readonly Region SA_BRAZIL_1 = new Region("sa-brazil-1",
            "https://codearts-check.sa-brazil-1.myhuaweicloud.com");
        public static readonly Region AP_SOUTHEAST_3 = new Region("ap-southeast-3",
            "https://codearts-check.ap-southeast-3.myhuaweicloud.com");
        
        private static readonly IRegionProvider Provider = RegionProviderChain.GetDefault("CODEARTSCHECK");

        private static readonly Dictionary<string, Region> StaticFields = new Dictionary<string, Region>
        {
                { "cn-north-4", CN_NORTH_4 },
                { "cn-north-1", CN_NORTH_1 },
                { "cn-east-2", CN_EAST_2 },
                { "cn-south-1", CN_SOUTH_1 },
                { "cn-east-3", CN_EAST_3 },
                { "la-north-2", LA_NORTH_2 },
                { "sa-brazil-1", SA_BRAZIL_1 },
                { "ap-southeast-3", AP_SOUTHEAST_3 },
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

            throw new ArgumentException($"region id '{regionId}' is not in the following supported regions of service 'CodeArtsCheck': [{string.Join(", ", StaticFields.Keys.OrderBy(key => key))}]");
        }
    }
}