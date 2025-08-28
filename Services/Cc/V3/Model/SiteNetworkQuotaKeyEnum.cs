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
    /// 分支网络配额类型。 - site_networks_per_account (每个账户的分支网络数) - sites_per_mesh_site_network (网状分支网络的分支数) - spoke_sites_per_star_site_network (星状分支网络的Spoke分支数) - sites_per_hybrid_site_network (混合分支网络的分支数)
    /// </summary>
    /// <value>分支网络配额类型。 - site_networks_per_account (每个账户的分支网络数) - sites_per_mesh_site_network (网状分支网络的分支数) - spoke_sites_per_star_site_network (星状分支网络的Spoke分支数) - sites_per_hybrid_site_network (混合分支网络的分支数)</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum SiteNetworkQuotaKeyEnum
    {
        /// <summary>
        /// Enum SITE_NETWORKS_PER_ACCOUNT for value: site_networks_per_account
        /// </summary>
        [EnumMember(Value = "site_networks_per_account")]
        SITE_NETWORKS_PER_ACCOUNT = 1,

        /// <summary>
        /// Enum SITES_PER_MESH_SITE_NETWORK for value: sites_per_mesh_site_network
        /// </summary>
        [EnumMember(Value = "sites_per_mesh_site_network")]
        SITES_PER_MESH_SITE_NETWORK = 2,

        /// <summary>
        /// Enum SPOKE_SITES_PER_STAR_SITE_NETWORK for value: spoke_sites_per_star_site_network
        /// </summary>
        [EnumMember(Value = "spoke_sites_per_star_site_network")]
        SPOKE_SITES_PER_STAR_SITE_NETWORK = 3,

        /// <summary>
        /// Enum SITES_PER_HYBRID_SITE_NETWORK for value: sites_per_hybrid_site_network
        /// </summary>
        [EnumMember(Value = "sites_per_hybrid_site_network")]
        SITES_PER_HYBRID_SITE_NETWORK = 4

    }

}
