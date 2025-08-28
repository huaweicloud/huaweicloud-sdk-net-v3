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
    /// 分支网络。
    /// </summary>
    public class SiteNetworkEntry 
    {

        /// <summary>
        /// 实例ID。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 实例名称。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 实例描述。不支持 &lt;&gt;。
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// 实例创建时间。UTC时间格式，yyyy-MM-ddTHH:mm:ss。
        /// </summary>
        [JsonProperty("created_at", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// 实例更新时间。UTC时间格式，yyyy-MM-ddTHH:mm:ss。
        /// </summary>
        [JsonProperty("updated_at", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// 实例所属账号ID。
        /// </summary>
        [JsonProperty("domain_id", NullValueHandling = NullValueHandling.Ignore)]
        public string DomainId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("state", NullValueHandling = NullValueHandling.Ignore)]
        public SiteNetworkStateEnum State { get; set; }
        /// <summary>
        /// 实例所属企业项目ID。
        /// </summary>
        [JsonProperty("enterprise_project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EnterpriseProjectId { get; set; }

        /// <summary>
        /// 应用策略ID。
        /// </summary>
        [JsonProperty("apply_policy_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ApplyPolicyId { get; set; }

        /// <summary>
        /// 实例标签。
        /// </summary>
        [JsonProperty("tags", NullValueHandling = NullValueHandling.Ignore)]
        public List<Tag> Tags { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("topology", NullValueHandling = NullValueHandling.Ignore)]
        public SiteNetworkTopologyEnum Topology { get; set; }
        /// <summary>
        /// 分支连接列表。
        /// </summary>
        [JsonProperty("connections", NullValueHandling = NullValueHandling.Ignore)]
        public List<SiteConnection> Connections { get; set; }

        /// <summary>
        /// 点对点拓扑或者网状拓扑中的节点。
        /// </summary>
        [JsonProperty("sites", NullValueHandling = NullValueHandling.Ignore)]
        public List<SiteInformation> Sites { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("hub_site", NullValueHandling = NullValueHandling.Ignore)]
        public SiteInformation HubSite { get; set; }

        /// <summary>
        /// 分支列表。
        /// </summary>
        [JsonProperty("spoke_sites", NullValueHandling = NullValueHandling.Ignore)]
        public List<SiteInformation> SpokeSites { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SiteNetworkEntry {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  createdAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  updatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  domainId: ").Append(DomainId).Append("\n");
            sb.Append("  state: ").Append(State).Append("\n");
            sb.Append("  enterpriseProjectId: ").Append(EnterpriseProjectId).Append("\n");
            sb.Append("  applyPolicyId: ").Append(ApplyPolicyId).Append("\n");
            sb.Append("  tags: ").Append(Tags).Append("\n");
            sb.Append("  topology: ").Append(Topology).Append("\n");
            sb.Append("  connections: ").Append(Connections).Append("\n");
            sb.Append("  sites: ").Append(Sites).Append("\n");
            sb.Append("  hubSite: ").Append(HubSite).Append("\n");
            sb.Append("  spokeSites: ").Append(SpokeSites).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SiteNetworkEntry);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SiteNetworkEntry input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;
            if (this.CreatedAt != input.CreatedAt || (this.CreatedAt != null && !this.CreatedAt.Equals(input.CreatedAt))) return false;
            if (this.UpdatedAt != input.UpdatedAt || (this.UpdatedAt != null && !this.UpdatedAt.Equals(input.UpdatedAt))) return false;
            if (this.DomainId != input.DomainId || (this.DomainId != null && !this.DomainId.Equals(input.DomainId))) return false;
            if (this.State != input.State) return false;
            if (this.EnterpriseProjectId != input.EnterpriseProjectId || (this.EnterpriseProjectId != null && !this.EnterpriseProjectId.Equals(input.EnterpriseProjectId))) return false;
            if (this.ApplyPolicyId != input.ApplyPolicyId || (this.ApplyPolicyId != null && !this.ApplyPolicyId.Equals(input.ApplyPolicyId))) return false;
            if (this.Tags != input.Tags || (this.Tags != null && input.Tags != null && !this.Tags.SequenceEqual(input.Tags))) return false;
            if (this.Topology != input.Topology) return false;
            if (this.Connections != input.Connections || (this.Connections != null && input.Connections != null && !this.Connections.SequenceEqual(input.Connections))) return false;
            if (this.Sites != input.Sites || (this.Sites != null && input.Sites != null && !this.Sites.SequenceEqual(input.Sites))) return false;
            if (this.HubSite != input.HubSite || (this.HubSite != null && !this.HubSite.Equals(input.HubSite))) return false;
            if (this.SpokeSites != input.SpokeSites || (this.SpokeSites != null && input.SpokeSites != null && !this.SpokeSites.SequenceEqual(input.SpokeSites))) return false;

            return true;
        }

        /// <summary>
        /// Get hash code
        /// </summary>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                var hashCode = 41;
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.CreatedAt != null) hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.UpdatedAt != null) hashCode = hashCode * 59 + this.UpdatedAt.GetHashCode();
                if (this.DomainId != null) hashCode = hashCode * 59 + this.DomainId.GetHashCode();
                hashCode = hashCode * 59 + this.State.GetHashCode();
                if (this.EnterpriseProjectId != null) hashCode = hashCode * 59 + this.EnterpriseProjectId.GetHashCode();
                if (this.ApplyPolicyId != null) hashCode = hashCode * 59 + this.ApplyPolicyId.GetHashCode();
                if (this.Tags != null) hashCode = hashCode * 59 + this.Tags.GetHashCode();
                hashCode = hashCode * 59 + this.Topology.GetHashCode();
                if (this.Connections != null) hashCode = hashCode * 59 + this.Connections.GetHashCode();
                if (this.Sites != null) hashCode = hashCode * 59 + this.Sites.GetHashCode();
                if (this.HubSite != null) hashCode = hashCode * 59 + this.HubSite.GetHashCode();
                if (this.SpokeSites != null) hashCode = hashCode * 59 + this.SpokeSites.GetHashCode();
                return hashCode;
            }
        }
    }
}
