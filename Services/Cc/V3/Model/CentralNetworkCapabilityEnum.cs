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
    /// 能力类型定义： - central-network.is-support: 支持中心网络 - central-network.is-support-enterprise-project: 支持中心网络的企业项目 - central-network.is-support-tag: 支持中心网络的标签能力 - central-network.is-support-custom-er-table: 支持中心网络的自定义路由表能力 - connection-bandwidth.size-range: 跨地域连接带宽大小的范围 - connection-bandwidth.charge-mode: 跨地域连接带宽计费类型 - connection-bandwidth.free-line: 跨地域连接免费线路 - er-instance.support-regions: 支持ER实例的Region列表 - er-instance.support-ipv6-regions: 支持IPV6的ER实例Region列表 - er-instance.support-dscp-regions:支持带宽包线路等级配置的region列表 - er-instance.support-sts5-regions:支持sts5调用ER服务的region列表 - er-instance.support-sites: 支持ER实例的站点列表 - custom-connections.is-support: 是否支持自定义连接 - custom-connections.support-regions: 支持创建自定义连接的region - gdgw-instance.support-dscp-regions:支持GDGW全域互联带宽线路等级配置的region列表 - gdgw-instance.support-freeze-regions:支持GDGW全域互联带宽冻结的region列表 - gdgw-attachment.is-support: 支持GDGW附件 - gdgw-attachment.support-regions: 支持GDGW附件的Region列表 - gdgw-attachment.support-sites: 支持GDGW附件的站点列表 - er-route-table-attachment.is-support: 支持路由表附件 - er-route-table-attachment.support-regions: 支持路由表附件的Region列表 - er-route-table-attachment.support-sites: 支持路由表附件的站点列表 - cloud-alliance.support-regions: 支持云联盟场景的Region列表
    /// </summary>
    /// <value>能力类型定义： - central-network.is-support: 支持中心网络 - central-network.is-support-enterprise-project: 支持中心网络的企业项目 - central-network.is-support-tag: 支持中心网络的标签能力 - central-network.is-support-custom-er-table: 支持中心网络的自定义路由表能力 - connection-bandwidth.size-range: 跨地域连接带宽大小的范围 - connection-bandwidth.charge-mode: 跨地域连接带宽计费类型 - connection-bandwidth.free-line: 跨地域连接免费线路 - er-instance.support-regions: 支持ER实例的Region列表 - er-instance.support-ipv6-regions: 支持IPV6的ER实例Region列表 - er-instance.support-dscp-regions:支持带宽包线路等级配置的region列表 - er-instance.support-sts5-regions:支持sts5调用ER服务的region列表 - er-instance.support-sites: 支持ER实例的站点列表 - custom-connections.is-support: 是否支持自定义连接 - custom-connections.support-regions: 支持创建自定义连接的region - gdgw-instance.support-dscp-regions:支持GDGW全域互联带宽线路等级配置的region列表 - gdgw-instance.support-freeze-regions:支持GDGW全域互联带宽冻结的region列表 - gdgw-attachment.is-support: 支持GDGW附件 - gdgw-attachment.support-regions: 支持GDGW附件的Region列表 - gdgw-attachment.support-sites: 支持GDGW附件的站点列表 - er-route-table-attachment.is-support: 支持路由表附件 - er-route-table-attachment.support-regions: 支持路由表附件的Region列表 - er-route-table-attachment.support-sites: 支持路由表附件的站点列表 - cloud-alliance.support-regions: 支持云联盟场景的Region列表</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum CentralNetworkCapabilityEnum
    {
        /// <summary>
        /// Enum CENTRAL_NETWORK_IS_SUPPORT for value: central-network.is-support
        /// </summary>
        [EnumMember(Value = "central-network.is-support")]
        CENTRAL_NETWORK_IS_SUPPORT = 1,

        /// <summary>
        /// Enum CENTRAL_NETWORK_IS_SUPPORT_ENTERPRISE_PROJECT for value: central-network.is-support-enterprise-project
        /// </summary>
        [EnumMember(Value = "central-network.is-support-enterprise-project")]
        CENTRAL_NETWORK_IS_SUPPORT_ENTERPRISE_PROJECT = 2,

        /// <summary>
        /// Enum CENTRAL_NETWORK_IS_SUPPORT_TAG for value: central-network.is-support-tag
        /// </summary>
        [EnumMember(Value = "central-network.is-support-tag")]
        CENTRAL_NETWORK_IS_SUPPORT_TAG = 3,

        /// <summary>
        /// Enum CENTRAL_NETWORK_IS_SUPPORT_CUSTOM_ER_TABLE for value: central-network.is-support-custom-er-table
        /// </summary>
        [EnumMember(Value = "central-network.is-support-custom-er-table")]
        CENTRAL_NETWORK_IS_SUPPORT_CUSTOM_ER_TABLE = 4,

        /// <summary>
        /// Enum CONNECTION_BANDWIDTH_SIZE_RANGE for value: connection-bandwidth.size-range
        /// </summary>
        [EnumMember(Value = "connection-bandwidth.size-range")]
        CONNECTION_BANDWIDTH_SIZE_RANGE = 5,

        /// <summary>
        /// Enum CONNECTION_BANDWIDTH_CHARGE_MODE for value: connection-bandwidth.charge-mode
        /// </summary>
        [EnumMember(Value = "connection-bandwidth.charge-mode")]
        CONNECTION_BANDWIDTH_CHARGE_MODE = 6,

        /// <summary>
        /// Enum CONNECTION_BANDWIDTH_FREE_LINE for value: connection-bandwidth.free-line
        /// </summary>
        [EnumMember(Value = "connection-bandwidth.free-line")]
        CONNECTION_BANDWIDTH_FREE_LINE = 7,

        /// <summary>
        /// Enum ER_INSTANCE_SUPPORT_REGIONS for value: er-instance.support-regions
        /// </summary>
        [EnumMember(Value = "er-instance.support-regions")]
        ER_INSTANCE_SUPPORT_REGIONS = 8,

        /// <summary>
        /// Enum ER_INSTANCE_SUPPORT_IPV6_REGIONS for value: er-instance.support-ipv6-regions
        /// </summary>
        [EnumMember(Value = "er-instance.support-ipv6-regions")]
        ER_INSTANCE_SUPPORT_IPV6_REGIONS = 9,

        /// <summary>
        /// Enum ER_INSTANCE_SUPPORT_DSCP_REGIONS for value: er-instance.support-dscp-regions
        /// </summary>
        [EnumMember(Value = "er-instance.support-dscp-regions")]
        ER_INSTANCE_SUPPORT_DSCP_REGIONS = 10,

        /// <summary>
        /// Enum ER_INSTANCE_SUPPORT_STS5_REGIONS for value: er-instance.support-sts5-regions
        /// </summary>
        [EnumMember(Value = "er-instance.support-sts5-regions")]
        ER_INSTANCE_SUPPORT_STS5_REGIONS = 11,

        /// <summary>
        /// Enum ER_INSTANCE_SUPPORT_SITES for value: er-instance.support-sites
        /// </summary>
        [EnumMember(Value = "er-instance.support-sites")]
        ER_INSTANCE_SUPPORT_SITES = 12,

        /// <summary>
        /// Enum CUSTOM_CONNECTIONS_IS_SUPPORT for value: custom-connections.is-support
        /// </summary>
        [EnumMember(Value = "custom-connections.is-support")]
        CUSTOM_CONNECTIONS_IS_SUPPORT = 13,

        /// <summary>
        /// Enum CUSTOM_CONNECTIONS_SUPPORT_REGIONS for value: custom-connections.support-regions
        /// </summary>
        [EnumMember(Value = "custom-connections.support-regions")]
        CUSTOM_CONNECTIONS_SUPPORT_REGIONS = 14,

        /// <summary>
        /// Enum GDGW_INSTANCE_SUPPORT_DSCP_REGIONS for value: gdgw-instance.support-dscp-regions
        /// </summary>
        [EnumMember(Value = "gdgw-instance.support-dscp-regions")]
        GDGW_INSTANCE_SUPPORT_DSCP_REGIONS = 15,

        /// <summary>
        /// Enum GDGW_INSTANCE_SUPPORT_FREEZE_REGIONS for value: gdgw-instance.support-freeze-regions
        /// </summary>
        [EnumMember(Value = "gdgw-instance.support-freeze-regions")]
        GDGW_INSTANCE_SUPPORT_FREEZE_REGIONS = 16,

        /// <summary>
        /// Enum GDGW_ATTACHMENT_IS_SUPPORT for value: gdgw-attachment.is-support
        /// </summary>
        [EnumMember(Value = "gdgw-attachment.is-support")]
        GDGW_ATTACHMENT_IS_SUPPORT = 17,

        /// <summary>
        /// Enum GDGW_ATTACHMENT_SUPPORT_REGIONS for value: gdgw-attachment.support-regions
        /// </summary>
        [EnumMember(Value = "gdgw-attachment.support-regions")]
        GDGW_ATTACHMENT_SUPPORT_REGIONS = 18,

        /// <summary>
        /// Enum GDGW_ATTACHMENT_SUPPORT_SITES for value: gdgw-attachment.support-sites
        /// </summary>
        [EnumMember(Value = "gdgw-attachment.support-sites")]
        GDGW_ATTACHMENT_SUPPORT_SITES = 19,

        /// <summary>
        /// Enum ER_ROUTE_TABLE_ATTACHMENT_IS_SUPPORT for value: er-route-table-attachment.is-support
        /// </summary>
        [EnumMember(Value = "er-route-table-attachment.is-support")]
        ER_ROUTE_TABLE_ATTACHMENT_IS_SUPPORT = 20,

        /// <summary>
        /// Enum ER_ROUTE_TABLE_ATTACHMENT_SUPPORT_REGIONS for value: er-route-table-attachment.support-regions
        /// </summary>
        [EnumMember(Value = "er-route-table-attachment.support-regions")]
        ER_ROUTE_TABLE_ATTACHMENT_SUPPORT_REGIONS = 21,

        /// <summary>
        /// Enum ER_ROUTE_TABLE_ATTACHMENT_SUPPORT_SITES for value: er-route-table-attachment.support-sites
        /// </summary>
        [EnumMember(Value = "er-route-table-attachment.support-sites")]
        ER_ROUTE_TABLE_ATTACHMENT_SUPPORT_SITES = 22,

        /// <summary>
        /// Enum CLOUD_ALLIANCE_SUPPORT_REGIONS for value: cloud-alliance.support-regions
        /// </summary>
        [EnumMember(Value = "cloud-alliance.support-regions")]
        CLOUD_ALLIANCE_SUPPORT_REGIONS = 23

    }

}
