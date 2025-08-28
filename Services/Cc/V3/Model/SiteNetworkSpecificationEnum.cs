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
    /// 分支网络的规格类型定义： - site-network.is-support: 支持分支网络。 - site-network.is-support-enterprise-project: 支持分支网络的企业项目。 - site-network.is-support-tag: 支持分支网络的标签能力。 - site-network.is-support-intra-region: 支持同region创建分支网络。 - site-network.support-topologies: 支持分支网络拓扑。 - site-network.support-regions: 支持分支接入的Region列表。 - site-network.support-dscp-regions: 支持分支接入的Region列表 - site-network.support-freeze-regions: 支持分支网络冻结的Region列表 - site-network.support-locations: 支持分支接入点列表。 - site-connection-bandwidth.size-range: 分支连接带宽大小的范围。 - site-connection-bandwidth.charge-mode: 分支连接带宽计费类型。 - site-connection-bandwidth.free-line: 分支连接带宽免费线路。
    /// </summary>
    /// <value>分支网络的规格类型定义： - site-network.is-support: 支持分支网络。 - site-network.is-support-enterprise-project: 支持分支网络的企业项目。 - site-network.is-support-tag: 支持分支网络的标签能力。 - site-network.is-support-intra-region: 支持同region创建分支网络。 - site-network.support-topologies: 支持分支网络拓扑。 - site-network.support-regions: 支持分支接入的Region列表。 - site-network.support-dscp-regions: 支持分支接入的Region列表 - site-network.support-freeze-regions: 支持分支网络冻结的Region列表 - site-network.support-locations: 支持分支接入点列表。 - site-connection-bandwidth.size-range: 分支连接带宽大小的范围。 - site-connection-bandwidth.charge-mode: 分支连接带宽计费类型。 - site-connection-bandwidth.free-line: 分支连接带宽免费线路。</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum SiteNetworkSpecificationEnum
    {
        /// <summary>
        /// Enum SITE_NETWORK_IS_SUPPORT for value: site-network.is-support
        /// </summary>
        [EnumMember(Value = "site-network.is-support")]
        SITE_NETWORK_IS_SUPPORT = 1,

        /// <summary>
        /// Enum SITE_NETWORK_IS_SUPPORT_ENTERPRISE_PROJECT for value: site-network.is-support-enterprise-project
        /// </summary>
        [EnumMember(Value = "site-network.is-support-enterprise-project")]
        SITE_NETWORK_IS_SUPPORT_ENTERPRISE_PROJECT = 2,

        /// <summary>
        /// Enum SITE_NETWORK_IS_SUPPORT_TAG for value: site-network.is-support-tag
        /// </summary>
        [EnumMember(Value = "site-network.is-support-tag")]
        SITE_NETWORK_IS_SUPPORT_TAG = 3,

        /// <summary>
        /// Enum SITE_NETWORK_IS_SUPPORT_INTRA_REGION for value: site-network.is-support-intra-region
        /// </summary>
        [EnumMember(Value = "site-network.is-support-intra-region")]
        SITE_NETWORK_IS_SUPPORT_INTRA_REGION = 4,

        /// <summary>
        /// Enum SITE_NETWORK_SUPPORT_TOPOLOGIES for value: site-network.support-topologies
        /// </summary>
        [EnumMember(Value = "site-network.support-topologies")]
        SITE_NETWORK_SUPPORT_TOPOLOGIES = 5,

        /// <summary>
        /// Enum SITE_NETWORK_SUPPORT_REGIONS for value: site-network.support-regions
        /// </summary>
        [EnumMember(Value = "site-network.support-regions")]
        SITE_NETWORK_SUPPORT_REGIONS = 6,

        /// <summary>
        /// Enum SITE_NETWORK_SUPPORT_DSCP_REGIONS for value: site-network.support-dscp-regions
        /// </summary>
        [EnumMember(Value = "site-network.support-dscp-regions")]
        SITE_NETWORK_SUPPORT_DSCP_REGIONS = 7,

        /// <summary>
        /// Enum SITE_NETWORK_SUPPORT_FREEZE_REGIONS for value: site-network.support-freeze-regions
        /// </summary>
        [EnumMember(Value = "site-network.support-freeze-regions")]
        SITE_NETWORK_SUPPORT_FREEZE_REGIONS = 8,

        /// <summary>
        /// Enum SITE_NETWORK_SUPPORT_LOCATIONS for value: site-network.support-locations
        /// </summary>
        [EnumMember(Value = "site-network.support-locations")]
        SITE_NETWORK_SUPPORT_LOCATIONS = 9,

        /// <summary>
        /// Enum SITE_CONNECTION_BANDWIDTH_SIZE_RANGE for value: site-connection-bandwidth.size-range
        /// </summary>
        [EnumMember(Value = "site-connection-bandwidth.size-range")]
        SITE_CONNECTION_BANDWIDTH_SIZE_RANGE = 10,

        /// <summary>
        /// Enum SITE_CONNECTION_BANDWIDTH_CHARGE_MODE for value: site-connection-bandwidth.charge-mode
        /// </summary>
        [EnumMember(Value = "site-connection-bandwidth.charge-mode")]
        SITE_CONNECTION_BANDWIDTH_CHARGE_MODE = 11,

        /// <summary>
        /// Enum SITE_CONNECTION_BANDWIDTH_FREE_LINE for value: site-connection-bandwidth.free-line
        /// </summary>
        [EnumMember(Value = "site-connection-bandwidth.free-line")]
        SITE_CONNECTION_BANDWIDTH_FREE_LINE = 12

    }

}
