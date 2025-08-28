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
    /// 中心网络配额类型。 - central_networks_per_account (每个账户的中心网数) - policy_versions_per_central_network (每个中心网的策略数) - size_of_document_per_central_network_policy_version (中心网络策略文档大小(KB)) - planes_per_central_network (每个中心网的平面数) - er_instances_per_region_per_central_network (每个中心网络每个区域的Er实例数) - connections_per_central_network (每个中心网的连接数) - attachments_per_central_network (每个中心网的附件数) - GDGW_attachments_per_region_per_central_network (每个中心网每个区域的GDGW附件数) - ER_ROUTE_TABLE_attachments_per_region_per_central_network (每个中心网每个区域的ER_ROUTE_TABLE附件数)
    /// </summary>
    /// <value>中心网络配额类型。 - central_networks_per_account (每个账户的中心网数) - policy_versions_per_central_network (每个中心网的策略数) - size_of_document_per_central_network_policy_version (中心网络策略文档大小(KB)) - planes_per_central_network (每个中心网的平面数) - er_instances_per_region_per_central_network (每个中心网络每个区域的Er实例数) - connections_per_central_network (每个中心网的连接数) - attachments_per_central_network (每个中心网的附件数) - GDGW_attachments_per_region_per_central_network (每个中心网每个区域的GDGW附件数) - ER_ROUTE_TABLE_attachments_per_region_per_central_network (每个中心网每个区域的ER_ROUTE_TABLE附件数)</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum CentralNetworkQuotaKeyEnum
    {
        /// <summary>
        /// Enum CENTRAL_NETWORKS_PER_ACCOUNT for value: central_networks_per_account
        /// </summary>
        [EnumMember(Value = "central_networks_per_account")]
        CENTRAL_NETWORKS_PER_ACCOUNT = 1,

        /// <summary>
        /// Enum POLICY_VERSIONS_PER_CENTRAL_NETWORK for value: policy_versions_per_central_network
        /// </summary>
        [EnumMember(Value = "policy_versions_per_central_network")]
        POLICY_VERSIONS_PER_CENTRAL_NETWORK = 2,

        /// <summary>
        /// Enum SIZE_OF_DOCUMENT_PER_CENTRAL_NETWORK_POLICY_VERSION for value: size_of_document_per_central_network_policy_version
        /// </summary>
        [EnumMember(Value = "size_of_document_per_central_network_policy_version")]
        SIZE_OF_DOCUMENT_PER_CENTRAL_NETWORK_POLICY_VERSION = 3,

        /// <summary>
        /// Enum PLANES_PER_CENTRAL_NETWORK for value: planes_per_central_network
        /// </summary>
        [EnumMember(Value = "planes_per_central_network")]
        PLANES_PER_CENTRAL_NETWORK = 4,

        /// <summary>
        /// Enum ER_INSTANCES_PER_REGION_PER_CENTRAL_NETWORK for value: er_instances_per_region_per_central_network
        /// </summary>
        [EnumMember(Value = "er_instances_per_region_per_central_network")]
        ER_INSTANCES_PER_REGION_PER_CENTRAL_NETWORK = 5,

        /// <summary>
        /// Enum CONNECTIONS_PER_CENTRAL_NETWORK for value: connections_per_central_network
        /// </summary>
        [EnumMember(Value = "connections_per_central_network")]
        CONNECTIONS_PER_CENTRAL_NETWORK = 6,

        /// <summary>
        /// Enum ATTACHMENTS_PER_CENTRAL_NETWORK for value: attachments_per_central_network
        /// </summary>
        [EnumMember(Value = "attachments_per_central_network")]
        ATTACHMENTS_PER_CENTRAL_NETWORK = 7,

        /// <summary>
        /// Enum GDGW_ATTACHMENTS_PER_REGION_PER_CENTRAL_NETWORK for value: GDGW_attachments_per_region_per_central_network
        /// </summary>
        [EnumMember(Value = "GDGW_attachments_per_region_per_central_network")]
        GDGW_ATTACHMENTS_PER_REGION_PER_CENTRAL_NETWORK = 8,

        /// <summary>
        /// Enum ER_ROUTE_TABLE_ATTACHMENTS_PER_REGION_PER_CENTRAL_NETWORK for value: ER_ROUTE_TABLE_attachments_per_region_per_central_network
        /// </summary>
        [EnumMember(Value = "ER_ROUTE_TABLE_attachments_per_region_per_central_network")]
        ER_ROUTE_TABLE_ATTACHMENTS_PER_REGION_PER_CENTRAL_NETWORK = 9

    }

}
