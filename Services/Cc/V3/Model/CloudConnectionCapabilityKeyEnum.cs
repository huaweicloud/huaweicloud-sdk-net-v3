using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cc.V3.Model
{
    /// <summary>
    /// 租户能力类型，分为： - v2（V2的API） - v3（V3的API） - billing_mode_period_reduce（包周期实时降配） - billing_mode_demand（按需计费） - bwp95（按需计费-95） - bwp95Avg（按需计费-日95） - network-quality（丢包和时延统计） - er（是否支持ER） - domain_bandwidth（租户带宽值） - ipv6（是否支持IPV6） - ipv6_support_regions（IPV6支持的区域列表） - enterprise-cloud-connection.is-support（支持企业版云连接） - enterprise-cloud-connection.support-sites（支持企业版云连接的站点列表） - enterprise-cloud-connection-segment.is-support（支持企业版云连接平面） - enterprise-cloud-connection-dc-attachment.is-support（支持企业版云连接的专线网关连接）
    /// </summary>
    /// <value>租户能力类型，分为： - v2（V2的API） - v3（V3的API） - billing_mode_period_reduce（包周期实时降配） - billing_mode_demand（按需计费） - bwp95（按需计费-95） - bwp95Avg（按需计费-日95） - network-quality（丢包和时延统计） - er（是否支持ER） - domain_bandwidth（租户带宽值） - ipv6（是否支持IPV6） - ipv6_support_regions（IPV6支持的区域列表） - enterprise-cloud-connection.is-support（支持企业版云连接） - enterprise-cloud-connection.support-sites（支持企业版云连接的站点列表） - enterprise-cloud-connection-segment.is-support（支持企业版云连接平面） - enterprise-cloud-connection-dc-attachment.is-support（支持企业版云连接的专线网关连接）</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum CloudConnectionCapabilityKeyEnum
    {
        /// <summary>
        /// Enum V2 for value: v2
        /// </summary>
        [EnumMember(Value = "v2")]
        V2 = 1,

        /// <summary>
        /// Enum V3 for value: v3
        /// </summary>
        [EnumMember(Value = "v3")]
        V3 = 2,

        /// <summary>
        /// Enum BILLING_MODE_PERIOD_REDUCE for value: billing_mode_period_reduce
        /// </summary>
        [EnumMember(Value = "billing_mode_period_reduce")]
        BILLING_MODE_PERIOD_REDUCE = 3,

        /// <summary>
        /// Enum BILLING_MODE_DEMAND for value: billing_mode_demand
        /// </summary>
        [EnumMember(Value = "billing_mode_demand")]
        BILLING_MODE_DEMAND = 4,

        /// <summary>
        /// Enum BWP95 for value: bwp95
        /// </summary>
        [EnumMember(Value = "bwp95")]
        BWP95 = 5,

        /// <summary>
        /// Enum BWP95AVG for value: bwp95Avg
        /// </summary>
        [EnumMember(Value = "bwp95Avg")]
        BWP95AVG = 6,

        /// <summary>
        /// Enum NETWORK_QUALITY for value: network-quality
        /// </summary>
        [EnumMember(Value = "network-quality")]
        NETWORK_QUALITY = 7,

        /// <summary>
        /// Enum ER for value: er
        /// </summary>
        [EnumMember(Value = "er")]
        ER = 8,

        /// <summary>
        /// Enum DOMAIN_BANDWIDTH for value: domain_bandwidth
        /// </summary>
        [EnumMember(Value = "domain_bandwidth")]
        DOMAIN_BANDWIDTH = 9,

        /// <summary>
        /// Enum IPV6 for value: ipv6
        /// </summary>
        [EnumMember(Value = "ipv6")]
        IPV6 = 10,

        /// <summary>
        /// Enum IPV6_SUPPORT_REGIONS for value: ipv6_support_regions
        /// </summary>
        [EnumMember(Value = "ipv6_support_regions")]
        IPV6_SUPPORT_REGIONS = 11,

        /// <summary>
        /// Enum ENTERPRISE_CLOUD_CONNECTION_IS_SUPPORT for value: enterprise-cloud-connection.is-support
        /// </summary>
        [EnumMember(Value = "enterprise-cloud-connection.is-support")]
        ENTERPRISE_CLOUD_CONNECTION_IS_SUPPORT = 12,

        /// <summary>
        /// Enum ENTERPRISE_CLOUD_CONNECTION_SUPPORT_SITES for value: enterprise-cloud-connection.support-sites
        /// </summary>
        [EnumMember(Value = "enterprise-cloud-connection.support-sites")]
        ENTERPRISE_CLOUD_CONNECTION_SUPPORT_SITES = 13,

        /// <summary>
        /// Enum ENTERPRISE_CLOUD_CONNECTION_SEGMENT_IS_SUPPORT for value: enterprise-cloud-connection-segment.is-support
        /// </summary>
        [EnumMember(Value = "enterprise-cloud-connection-segment.is-support")]
        ENTERPRISE_CLOUD_CONNECTION_SEGMENT_IS_SUPPORT = 14,

        /// <summary>
        /// Enum ENTERPRISE_CLOUD_CONNECTION_DC_ATTACHMENT_IS_SUPPORT for value: enterprise-cloud-connection-dc-attachment.is-support
        /// </summary>
        [EnumMember(Value = "enterprise-cloud-connection-dc-attachment.is-support")]
        ENTERPRISE_CLOUD_CONNECTION_DC_ATTACHMENT_IS_SUPPORT = 15

    }

}
