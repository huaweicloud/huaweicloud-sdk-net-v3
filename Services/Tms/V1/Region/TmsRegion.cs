using System;
using System.Collections.Generic;
using System.Linq;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Tms.V1
{
    public class TmsRegion
    {
        public static readonly Region CN_NORTH_4 = new Region("cn-north-4",
            "https://tms.myhuaweicloud.com",
            "https://tms.myhuaweicloud.cn");
        public static readonly Region AP_SOUTHEAST_1 = new Region("ap-southeast-1",
            "https://tms-intl.myhuaweicloud.com",
            "https://tms.ap-southeast-1.myhuaweicloud.com",
            "https://tms.ap-southeast-1.myhuaweicloud.cn");
        public static readonly Region EU_WEST_101 = new Region("eu-west-101",
            "https://tms.eu-west-101.myhuaweicloud.eu");
        public static readonly Region RU_MOSCOW_1 = new Region("ru-moscow-1",
            "https://tms.ru-moscow-1.myhuaweicloud.com",
            "https://tms.ru-moscow-1.myhuaweicloud.cn");
        
        private static readonly IRegionProvider Provider = RegionProviderChain.GetDefault("TMS");

        private static readonly Dictionary<string, Region> StaticFields = new Dictionary<string, Region>
        {
                { "cn-north-4", CN_NORTH_4 },
                { "ap-southeast-1", AP_SOUTHEAST_1 },
                { "eu-west-101", EU_WEST_101 },
                { "ru-moscow-1", RU_MOSCOW_1 },
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

            throw new ArgumentException($"region id '{regionId}' is not in the following supported regions of service 'TMS': [{string.Join(", ", StaticFields.Keys.OrderBy(key => key))}]");
        }
    }
}